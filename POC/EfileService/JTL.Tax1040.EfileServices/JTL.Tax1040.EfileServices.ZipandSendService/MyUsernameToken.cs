using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using Microsoft.Web.Services3.Security.Tokens;

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public class MyUsernameToken : UsernameTokenManager
    {
        XmlNodeList test = null;
        public MyUsernameToken()
        { }

        public MyUsernameToken(XmlNodeList configData)
        {
            test = configData;
        }


        protected override string AuthenticateToken(UsernameToken token)
        {
            return "************";
        }

        protected override void DetectReplay(UsernameToken token)
        {
            //base.DetectReplay(token);
        }
    }
}
