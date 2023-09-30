using System;

namespace CorePackage.Utilities.MailHelper
{
    public interface IMailSender
    {
        bool SendMail(string mailAddress, string message, bool bodyHtml);
    }
}

