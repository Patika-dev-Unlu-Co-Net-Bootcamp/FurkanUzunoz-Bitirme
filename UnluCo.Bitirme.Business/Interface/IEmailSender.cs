using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.Bitirme.Business.Interface
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string HtmlMes);
        Task WelcomeMail(string email);
    }
}
