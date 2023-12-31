﻿using Azure.Core;
using FoodRecipe.Models.Interface;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace FoodRecipe.Models.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }/// <summary>
        /// to implement sending email
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="HtmlMessage"></param>
        /// <returns></returns>
        public async Task SendEmailAsync(string email, string subject, string HtmlMessage)
        {
            string apiKey = _configuration["SendGrid:Key"];
            var client = new SendGridClient(apiKey);
            SendGridMessage msg = new SendGridMessage();

            string fromEmailAddress = _configuration["SendGrid:DefaultFromEmailAddress"];
            string fromName = _configuration["SendGrid:DefaultFromName"];
            msg.SetFrom(fromEmailAddress, fromName);

            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, HtmlMessage);

        var res=    await client.SendEmailAsync(msg);

        }
    }
}
