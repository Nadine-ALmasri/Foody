using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using FoodRecipe.Models.Interface;
using FoodRecipe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodRecipe.Controllers
{
	public class BookController : Controller
	{
		private readonly IBook _book;
		private readonly IConfiguration _configuration;
		private readonly ICart _cart;

		public BookController(IBook book, IConfiguration configuration, ICart cart)
		{
			_book = book;
			_configuration = configuration;
			_cart = cart;
		}
		//[Authorize(Roles = "Administrator,Editor,User")]
		/// <summary>
		/// this method is to get all the products
		/// </summary>
		/// <returns><List<ProductCategoryDTO></returns>
		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			List<Book> products = await _book.GetAllProducts();
			return View(products);
		}
		//[Authorize(Roles = "Administrator,Editor,User")]
		[AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			Book product = await _book.GetProductById(id);

			return View(product);
		}
		/// <summary>
		/// this method is to creat new product
		/// </summary>
		/// <param name="product"></param>
		/// <returns>ProductCategoryDTO</returns>
		[Authorize(Roles = "Administrator,Editor")]
		[HttpGet]
		public async Task<IActionResult> Create(int id)
		{

			return View();
		}/// <summary>
		 /// this method is to creat new product
		 /// </summary>
		 /// <param name="product"></param>
		 /// <returns>ProductCategoryDTO</returns>

		[HttpPost]
		 [Authorize(Roles = "Administrator,Editor")]
		public async Task<IActionResult> Create(int id, Book book)
		{
			Book newbook = await _book.Create(book);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		[ActionName("Delete")]
		 [Authorize(Roles = "Administrator")]
		public async Task<IActionResult> DeleteGet(int id)
		{
			Book product = await _book.GetProductById(id);
			return View(product);
		}
		/// <summary>
		/// to delete product
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		 [Authorize(Roles = "Administrator")]
		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			Book book = await _book.GetProductById(id);
			if (book == null)
				return RedirectToAction("notFound", "Home");
			await _book.Delete(book.Id);
			return RedirectToAction("Index", "Book");
		}
		/// <summary>
		/// to edite product details
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
        [Authorize(Roles = "Administrator,Editor")]
        public async Task<IActionResult> Edit(int id)
		{

			var Product = await _book.GetProductById(id);
			var booke = new Book
			{
				Id = Product.Id,
				Title = Product.Title,
				Price = Product.Price,
				Description = Product.Description,
				ImageUrl = Product.ImageUrl,
			};
			if (booke != null)
			{
				return View(booke);
			}
			return RedirectToAction("notFound", "Home");
		}



		[HttpPost]
        [Authorize(Roles = "Administrator,Editor")]
        /// <summary>
        /// to edite product details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int id, Book product)
		{
			if (id != product.Id)
			{
				return RedirectToAction("notFound", "Home");
			}
			if (ModelState.IsValid)
			{
				var updated = await _book.Update(id, product);
				var updatedDTO = new Book
				{
					Id = updated.Id,
					Title = updated.Title,
					Price = updated.Price,
					Description = updated.Description,
					ImageUrl = updated.ImageUrl,
				};
				return RedirectToAction(nameof(Details), updatedDTO);
			}

			return View(product);
		}/// <summary>
		 /// to upload img
		 /// </summary>
		 /// <param name="file"></param>
		 /// <param name="productId"></param>
		 /// <returns></returns>

		// [Authorize(Roles = "Editor ,Administrator")]
		[HttpPost]
		public async Task<IActionResult> UploadFile(IFormFile file, int productId)
		{
			// Add some logging to check the value of productName
			var product = await _book.GetProductById(productId);

			if (file != null && file.Length > 0)
			{
				// Upload the file to Azure Blob Storage
				string containerName = "images"; // Replace with your container name
				string blobName = $"{product.Id}/{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}"; // Use a unique file name

				BlobContainerClient blobContainerClient =
							   new BlobContainerClient(_configuration.GetConnectionString("StorageAccount"), containerName);

				BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

				string contentType = GetContentType(Path.GetExtension(file.FileName));

				BlobHttpHeaders blobHttpHeaders = new BlobHttpHeaders
				{
					ContentType = file.ContentType // Set the content type from the uploaded file
				};

				using (var stream = file.OpenReadStream())
				{
					await blobClient.UploadAsync(stream, true);
				}

				// Set the product's image URL



				product.ImageUrl = GetAzureBlobStorageImageUrl(containerName, blobName);
				if (product != null)
				{
					Book newpro = new Book()
					{

						Description = product.Description,
						ImageUrl = product.ImageUrl,
						Title = product.Title,
						Price = product.Price
					,
						Id = product.Id
					};

					await _book.Update(newpro.Id, newpro);
				}


				return RedirectToAction(nameof(Details), new { id = productId });
			}

			return RedirectToAction("notFound", "Home");
		}





		private string GetAzureBlobStorageImageUrl(string containerName, string blobName)
		{
			// Get the Azure Blob Storage account name from configuration
			string storageEndpoint = $"https://imagesforproducts.blob.core.windows.net";
			return $"{storageEndpoint}/{containerName}/{blobName}";

			// Combine the base URL, container name, and blob name to create the image URL

		}
		private string GetContentType(string fileExtension)
		{
			switch (fileExtension.ToLower())
			{
				case ".jpg":
				case ".jpeg":
					return "image/jpeg";
				case ".png":
					return "image/png";
				// Add more cases for other image formats as needed
				default:
					return "application/octet-stream"; // Default to binary data if format is unknown
			}
		}
		/// <summary>
		/// /to add product to cart
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		public async Task<IActionResult> AddProductToCart(int product)
		{

			var cartproducts = await _book.AddToCart(product);


			return RedirectToAction("Index", "Cart");
		}
	}
}
