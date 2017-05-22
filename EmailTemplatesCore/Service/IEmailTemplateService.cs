using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmailTemplatesCore.ViewModels;

namespace EmailTemplatesCore.Service
{
    public interface IEmailTemplateService
    {
        List<EmailTemplateViewModel> GetListOfEmailTemplates();
        EmailTemplateViewModel GetEmailTemplateById(int id);
        void AddEmailTemplate(EmailTemplateViewModel ViewModel);
        void EditEmailTemplate(EmailTemplateViewModel ViewModel);
        void TestSendEmail(int emailTemplateId, string Data = null);
    }
}