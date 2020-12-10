/*
 * Duy Tan Vu
 * Book Store project for Lab 5, Comm Activity 5 & Lab 06
 * Date Created: December 9, 2020
 */

using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OshawaBookStore.APIKeys;

namespace OshawaBookStore.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // getting the api key from an ignored folder which isn't uploaded to GitHub. 
            var sendGridKey = apiSendGrid.key;
            return Execute(sendGridKey, subject, htmlMessage, email);
        }

        public Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                // Sender email address and Subject
                From = new EmailAddress("duytanvu@icloud.com", "NETD3202 - Duy Tan Vu"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
}