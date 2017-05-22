using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmailTemplatesCore.Service;
using EmailTemplatesCore.ViewModels;

namespace EmailTemplatesCore.Controllers
{
    public class EmailTemplatesBaseController : Controller
    {
        protected IEmailTemplateService service;


        public EmailTemplatesBaseController()
        {
            this.service = new EmailTemplateService();
        }

        [HttpGet]
        public virtual ActionResult ViewCurrentEmailTemplates()
        {
            var ViewModel = service.GetListOfEmailTemplates();
            return View(ViewModel);
        }

        [HttpGet]
        public virtual ActionResult AddEmailTemplate()
        {
            var ViewModel = new EmailTemplateViewModel();
            return View(ViewModel);
        }

        [HttpPost]
        public virtual ActionResult AddEmailTemplate(EmailTemplateViewModel ViewModel)
        {
            service.AddEmailTemplate(ViewModel);
            return RedirectToAction("ViewCurrentEmailTemplates");
        }

        [HttpGet]
        public virtual ActionResult EditEmailTemplate(int id)
        {
            var ViewModel = service.GetEmailTemplateById(id);
            return View(ViewModel);
        }

        [HttpPost]
        public virtual ActionResult EditEmailTemplate(EmailTemplateViewModel ViewModel)
        {
            service.EditEmailTemplate(ViewModel);
            return RedirectToAction("ViewCurrentEmailTemplates");
        }

        [HttpGet]
        public virtual ActionResult TestEmailTemplate(int id)
        {
            service.TestSendEmail(id);
            return RedirectToAction("ViewCurrentEmailTemplates");
        }
    }
}