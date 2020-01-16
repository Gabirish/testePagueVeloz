using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Email;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace TestePagueVeloz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Curriculo()
        {
            IFileProvider provider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Curriculo"));
            IFileInfo fileInfo = provider.GetFileInfo("CV Raul.pdf");
            var readStream = fileInfo.CreateReadStream();
            var mimeType = "application/pdf";
            return File(readStream, mimeType, "CV Raul.pdf");
        }

        [HttpPost]
        public bool EnviarEmail(DadosEmail dados)
        {
            string result = Email.Email.EnviarEmail("PagueVelos@dummy.com", "FeedBack", dados.Nome, dados.Menssagem);
            if (string.IsNullOrEmpty(result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    public class DadosEmail
    {
        public string Nome { get; set; }
        public string Menssagem { get; set; }
    }
}