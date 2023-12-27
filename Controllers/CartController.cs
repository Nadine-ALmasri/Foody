using FoodRecipe.Data;
using FoodRecipe.Models.DTOs;
using FoodRecipe.Models.Interface;
using FoodRecipe.Models.Services;
using FoodRecipe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using Stripe;
using System.Security.Claims;

namespace FoodRecipe.Controllers
{
	public class CartController : Controller
	{
	
			 private readonly IEmailSender _emailSender;

		private readonly ICart _CartService;
		private UserManager<ApplicationUser> _userManager;
		private readonly IConfiguration _configuration;
		private readonly FoodDbContaxt _context;
		public CartController(IEmailSender emailSender, ICart CartService, UserManager<ApplicationUser> userManager, IConfiguration configuration, FoodDbContaxt context)
		{
			_CartService = CartService;
			_userManager = userManager;
			_configuration = configuration;
			_context = context;
			_emailSender = emailSender;
		}
		/// <summary>
		/// to display the user cart
		/// </summary>
		/// <param name="layout"></param>
		/// <returns></returns>
		[Authorize(Roles = "Administrator,Editor,User")]

		public async Task<IActionResult> Index(string layout)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

			if (string.IsNullOrEmpty(userId))
			{

				return RedirectToAction("Error");
			}

			var cart = await _CartService.GetCart(userId);
			ViewBag.Total = CalculateTotal();
			if (layout == "_Layout1")
				ViewBag.Layout = "_Layout1";
			else
				ViewBag.Layout = "_Layout";
			return View(cart);
		}/// <summary>
		 /// to delete product from user cart
		 /// </summary>
		 /// <param name="id"></param>
		 /// <returns></returns>

		[ActionName("DeleteProductFromCart")]
		public async Task<IActionResult> DeleteProductFromCartGet(int id)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{

				return RedirectToAction("Error");
			}

			var cart = await _CartService.GetCart(userId);
			var ProductInCart = cart.CartBooks.FirstOrDefault(x => x.BookId == id);
			return View(ProductInCart);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteProductFromCart(int id)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{

				return RedirectToAction("Error");
			}

			await _CartService.DeleteProduct(id);
			return RedirectToAction("Index");
		}
		/// <summary>
		/// to decrize the quentity
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[Authorize(Roles = "Administrator,Editor,User")]
		[HttpPost]
		public async Task<IActionResult> LessQuantityCon(int id)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{

				return RedirectToAction("Error");
			}

			await _CartService.LessQuantity(id);
			return RedirectToAction("Index");
		}


		/// <summary>
		/// /to get the total 
		/// </summary>
		/// <returns></returns>
		public async Task<double> CalculateTotal()
		{
			Cart UserCart = null;
			double total = 0;
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (!string.IsNullOrEmpty(userId))
			{
				UserCart = await _CartService.GetCart(userId);
				if (UserCart.CartBooks != null)
				{
					foreach (var item in UserCart.CartBooks)
					{
						if (item.Book != null)
						{
							total += item.Book.Price;
						}
					}
				}
				else
				{
					return total;
				}
			}
			return total;
		}/// <summary>
		 /// to checkout
		 /// </summary>
		 /// <returns></returns>
		public async Task<IActionResult> Checkout()
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

			if (string.IsNullOrEmpty(userId))
			{
				return RedirectToAction("Error");
			}

			var user = await _userManager.FindByIdAsync(userId);
			ViewBag.Email = user.Email;
			var shoppingCart = await _CartService.GetCart(userId);
			shoppingCart.Total = await CalculateTotal();

			var cartProductsDTO = new List<CartBooks>();

			foreach (var item in shoppingCart.CartBooks)
			{

				var cartProductDTO = new CartBooks
				{
					BookId = item.BookId,

					Book = new Book
					{
						Id = item.Book.Id,
						Title = item.Book.Title,
						Price = item.Book.Price,

					},
					Quantity = item.Quantity
				};

				cartProductsDTO.Add(cartProductDTO);
			}

			var UserOrder = new Order
			{
				UserId = user.Id,
				Email = user.Email,
				UserName = user.UserName,
				ShoppingCart = new Cart
				{
					Total = shoppingCart.Total,
					CartBooks = cartProductsDTO
				},
				Phone = user.PhoneNumber,

			};

			return View("Checkout", UserOrder);
		}
		[HttpPost]
		[ActionName("Checkout")]
		public async Task<IActionResult> CheckoutPOST(Order order)
		{

			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

			if (string.IsNullOrEmpty(userId))
			{
				return RedirectToAction("Error");
			}

			var user = await _userManager.FindByIdAsync(userId);
			ViewBag.Email = user.Email;
			var shoppingCart = await _CartService.GetCart(userId);
			shoppingCart.Total = await CalculateTotal();

			var cartProductsDTO = new List<CartBooks>();

			foreach (var item in shoppingCart.CartBooks)
			{

				var cartProductDTO = new CartBooks
				{
					UserId = userId,
					BookId = item.BookId,
					// Don't create a new 'Products' instance here
					// Instead, attach the existing one
					  Book = _context.Book.Find(item.BookId),
					Quantity = item.Quantity
				};

				cartProductsDTO.Add(cartProductDTO);

			}

			var UserOrder = new Order
			{
				UserId = user.Id,
				Email = user.Email,
				UserName = user.UserName,
				ShoppingCart = new Cart
				{
					UserId = shoppingCart.UserId,
					Total = shoppingCart.Total,
					CartBooks = cartProductsDTO

				},
				Phone = user.PhoneNumber,
				OrderDate = DateTime.Now,
				City = order.City,
				PostalCode = order.PostalCode,
				StreetAdress = order.StreetAdress,
			};
			StripeConfiguration.ApiKey = _configuration.GetSection("StripeSettings:SecretKey").Get<string>();

			var domain = "https://e-ccommerce.azurewebsites.net/";

			var options = new SessionCreateOptions
			{
				SuccessUrl = "https://localhost:7049/Cart/OrderConfirmation",
				CancelUrl = "https://localhost:7049/Cart",
				LineItems = new List<SessionLineItemOptions>(),
				Mode = "payment",

			};

			foreach (var item in UserOrder.ShoppingCart.CartBooks)
			{
				var sessionLineItem = new SessionLineItemOptions
				{
					PriceData = new SessionLineItemPriceDataOptions()
					{
						UnitAmount = (long)(item.Book.Price * 100), // 20.50 => 2050
						Currency = "usd",
						ProductData = new SessionLineItemPriceDataProductDataOptions()
						{
							Name = item.Book.Title
						}
					},
					Quantity = item.Quantity
				};

				options.LineItems.Add(sessionLineItem);
			}

			var service = new SessionService();
			var session = service.Create(options);

			var sessionId = session.Id;

			TempData["sessionId"] = sessionId;


			Response.Headers.Add("Location", session.Url);
			_context.Orders.Add(UserOrder);
			await _context.SaveChangesAsync();
			return new StatusCodeResult(303);

		}/// <summary>
		 /// to confirm the order and send email
		 /// </summary>
		 /// <returns></returns>
		public async Task<IActionResult> OrderConfirmation()
		{
			var sessionId = TempData["sessionId"].ToString();

			var service = new SessionService();

			Session session = service.Get(sessionId);

			if (session != null)
			{
				if (session.PaymentStatus.ToLower() == "paid")
				{
					var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

					if (string.IsNullOrEmpty(userId))
					{
						return RedirectToAction("Error");
					}

					var user = await _userManager.FindByIdAsync(userId);
					ViewBag.Email = user.Email;
					var shoppingCart = await _CartService.GetCart(userId);
					shoppingCart.Total = await CalculateTotal();
					var cartProductsDTO = new List<CartBooks>();
					foreach (var item in shoppingCart.CartBooks)
					{

						var cartProductDTO = new CartBooks
						{
							BookId = item.BookId,

							Book = new Book
							{
								Id = item.Book.Id,
								Title = item.Book.Title,
								Price = item.Book.Price,
							},
							Quantity = item.Quantity
						};
						cartProductsDTO.Add(cartProductDTO);
					}

					var userWithEmailAndCart = new UserEmailDTO
					{
						Email = user.Email,
						UserName = user.UserName,
						ShoppingCart = new CartEmail
						{
							Total = shoppingCart.Total,
							CartBooks = cartProductsDTO
						},
						Phone = user.PhoneNumber,

					};

					//RedirectToAction("ProcessOrder", userWithEmailAndCart);
					return View("OrderConfirmation", userWithEmailAndCart);

				}

				return Content("Not completed successfully");
			}
			return Content("Not completed successfully");
		}
		/// <summary>
		/// to senf email after confirm the order
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		[HttpPost]
		public async Task<IActionResult> ProcessOrder(UserEmailDTO user)
		{
			if (ModelState.IsValid)
			{
				string email = user.Email;
				string subject = "Thank you for your purchase. Here are the details of your order:\n\n";
				string HtmlMessage = "<table border='1'><tr><th>Product</th><th>Quantity</th><th>Price</th></tr>";

				foreach (var book in user.ShoppingCart.CartBooks)
				{
					HtmlMessage += $"<tr><td>{book.Book.Title}</td><td>{book.Quantity}</td><td>{book.Book.Price}</td></tr>";
				}

				HtmlMessage += $"<tr><td colspan='2'><strong>Total:</strong></td><td>{user.ShoppingCart.Total}</td></tr></table>";

				await _emailSender.SendEmailAsync(email, subject, HtmlMessage);
			}
			/* var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			 var shoppingCart = await _CartService.GetCart(userId);
			 var order = new Order
			 {
				 Email = user.Email,
				 UserName = user.UserName,



				 Phone = user.Phone,
				 ShoppingCart = shoppingCart,

				 UserId = userId,






			 };*/


			return View("Check");
		}
	}
}
