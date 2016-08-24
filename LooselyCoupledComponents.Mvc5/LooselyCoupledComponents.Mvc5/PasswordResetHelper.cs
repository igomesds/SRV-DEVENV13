using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupledComponents.Mvc5
{
    public class PasswordResetHelper
    {
        private IEmailSender emailSender;

        public PasswordResetHelper(IEmailSender emailSenderParam)
        {
            emailSender = emailSenderParam;
        }

        public void ResetPassword()
        {
            // IEmailSender mySender = new MyEmailSender();

            //...call interface methods to configure e-mail details...

            // mySender.SendEmail();

            emailSender.SendEmail();
        }
    }
}
