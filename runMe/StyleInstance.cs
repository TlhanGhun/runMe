using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using libSnarlStyles;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace runMe
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]

    public class StyleInstance : IStyleInstance
    {
        private string snarlTitle = "";
        private string snarlText = "";

        public StyleInstance()
        {
            // this is a workaround for mail server with an invalid (self signed...) certificate

            ServicePointManager.ServerCertificateValidationCallback += delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };


        }

         

        #region IStyleInstance Members

        [ComVisible(true)]
        void IStyleInstance.AdjustPosition(ref int x, ref int y, ref short Alpha, ref bool Done)
        {
            return;
        }

        [ComVisible(true)]
        melon.MImage IStyleInstance.GetContent()
        {
            
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        bool IStyleInstance.Pulse()
        {
            return false;
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        void IStyleInstance.Show(bool Visible)
        {
            return;
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        void IStyleInstance.UpdateContent(ref notification_info NotificationInfo)
        {
            snarlText = NotificationInfo.Text;
            snarlTitle = NotificationInfo.Title;




        }

        private string replacePlaceholder(string toBeWorkedOnText)
        {
            toBeWorkedOnText = toBeWorkedOnText.Replace("%title%", snarlTitle);
            return toBeWorkedOnText.Replace("%text%", snarlText);
        }


        #endregion


    }
}