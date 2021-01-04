using System;
using ConstructionCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionCoreApp.Models
{
    public class SendEmail
    {
        private readonly IMailService mailServices;

        public SendEmail(IMailService mailService)
        {
            mailServices = mailService;
        }

        public void SendMail([FromForm] MailRequest request)
        {
            try
            {
                mailServices.SendEmailAsync(request);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void SendWelcomeMail([FromForm] WelcomeRequest request)
        {
            try
            {
               mailServices.SendWelcomeEmailAsync(request);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void SendWelcomeMail(string to,string user)
        {
            try
            {
                mailServices.SendWelcomeEmailas(to,user);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
