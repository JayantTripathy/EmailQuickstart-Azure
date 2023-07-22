using EmailQuickstart_Azure.Models;
using EmailQuickstart_Azure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailQuickstart_Azure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IMailService _mailService;
        public EmailsController(IMailService mailService)
        {
            this._mailService = mailService;
        }
        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequest request)
        {
            await _mailService.SendEmailAsync(request);
            return Ok("Email Sent Successfully !");
        }
    }
}
