using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using EmailTemplatesCore.Models;
using EmailTemplatesCore.ViewModels;

namespace EmailTemplatesCore.Service
{
    public class EmailTemplateService : IEmailTemplateService
    {
        protected IDbContext db;

        public EmailTemplateService()
        {
            db = new DbContext();
        }


        public List<EmailTemplateViewModel> GetListOfEmailTemplates()
        {
            return db.EmailTemplates.Select(o => new EmailTemplateViewModel()
            {
                Id = o.Id,
                typeId = o.TypeId,
                Template = o.Template,
                From = o.EmailFrom,
                CreatedOn = o.CreatedOn,
                Name = o.EmailTemplateType.Name,
                Key = o.EmailTemplateType.Key,
                Subject = o.Subject
            }).ToList();
        }

        public EmailTemplateViewModel GetEmailTemplateById(int id)
        {
            return db.EmailTemplates.Where(o => o.Id == id).Select(o => new EmailTemplateViewModel()
            {
                Id = o.Id,
                typeId = o.TypeId,
                Template = o.Template,
                From = o.EmailFrom,
                CreatedOn = o.CreatedOn,
                Name = o.EmailTemplateType.Name,
                Key = o.EmailTemplateType.Key,
                Subject = o.Subject
            }).Single();
        }


        /// <summary>
        /// If we add a template we add a type for it other wise we don't edit type at all its a hard coded thing to be used as a call for the email
        /// 
        /// This service adds an email template to the system
        /// </summary>
        /// <param name="ViewModel"></param>
        public void AddEmailTemplate(EmailTemplateViewModel ViewModel)
        {
            EmailTemplateType type = new EmailTemplateType()
            {
                Key = ViewModel.Key,
                Name = ViewModel.Name,
                CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                CreatedOn = DateTime.Now,
                ModifiedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                ModifiedOn = DateTime.Now
            };

            EmailTemplate template = new EmailTemplate()
            {
                EmailFrom = ViewModel.From,
                Template = ViewModel.Template,
                Subject = ViewModel.Subject,
                CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                CreatedOn = DateTime.Now,
                ModifiedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                ModifiedOn = DateTime.Now
            };

            db.EmailTemplateTypes.Add(type);
            db.SaveChanges();
            template.TypeId = type.Id;
            db.EmailTemplates.Add(template);
            db.SaveChanges();
        }


        /// <summary>
        /// Allows for alterations of the template but only just the template
        /// </summary>
        /// <param name="ViewModel"></param>
        public void EditEmailTemplate(EmailTemplateViewModel ViewModel)
        {
            var model = db.EmailTemplates.Single(o => o.Id == ViewModel.Id);
            model.EmailFrom = ViewModel.From;
            model.Template = ViewModel.Template;
            model.ModifiedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            model.ModifiedOn = DateTime.Now;
            db.SaveChanges();
        }

        /// <summary>
        /// A way to test the email being sent
        /// </summary>
        /// <param name="emailTemplateId">Id for the template</param>
        /// <param name="Data">string represents a json object that will be the data tied into the message</param>
        public void TestSendEmail(int emailTemplateId, string Data = null)
        {
            var emailTemplate = db.EmailTemplates.Single(o => o.Id == emailTemplateId);
            var message = new MailMessage();
            message.To.Add(new MailAddress("recipient@gmail.com")); // replace with valid value 
            message.From = new MailAddress(emailTemplate.EmailFrom); // replace with valid value
            message.Subject = emailTemplate.EmailFrom;
            message.Body = emailTemplate.Template;
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                smtp.Send(message);
            }
        }

    }
}