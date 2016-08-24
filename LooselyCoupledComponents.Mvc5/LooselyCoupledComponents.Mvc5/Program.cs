using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupledComponents.Mvc5
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailSender sender = new MyEmailSender();

            PasswordResetHelper helper = new PasswordResetHelper(sender);

            helper.ResetPassword();
        }
    }
}
