﻿namespace FoodRecipe.Models.Interface
{
    public interface IEmailSender
    {
        public Task SendEmailAsync(string email , string subject , string HtmlMessage);
    }
}
