using Xamarin.Forms;
using Phoneword.iOS;
using MessageUI;

[assembly: Dependency(typeof(MailSender))]
namespace Phoneword.iOS
{
    public class MailSender : IMailSender
    {

        MFMailComposeViewController mailController;

        public bool sendMail(string messageBody)
        {
            if(MFMailComposeViewController.CanSendMail)
            {
                mailController = new MFMailComposeViewController();
                mailController.SetToRecipients(new string[] {"king_sam_parker@hotmail.com"});
                mailController.SetSubject("Hello Sam");
                mailController.SetMessageBody(messageBody, false);
            }

            return true;
        }
    }
}
