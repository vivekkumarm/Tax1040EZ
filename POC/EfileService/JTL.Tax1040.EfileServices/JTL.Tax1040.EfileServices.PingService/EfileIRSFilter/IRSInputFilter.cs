using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;

using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security;
using Microsoft.Web.Services3.Security.Utility;

namespace JTL.Tax1040.EfileServices.PingService
{
    public class IRSInputFilter : SoapFilter
    {
        private static XPathExpression SecurityExpression;

        public static XmlDocument SAMLDocument = null;
        public static string ResponseXML = null;

        public override SoapFilterResult ProcessMessage(SoapEnvelope envelope)
        {
            Soap ObjSop = envelope.CurrentSoap;

            if (envelope == null)
                throw new ArgumentNullException("No envelope!");

            XmlDocument doc = new XmlDocument();
            //The namespace manager for all our expressions.
            XmlNamespaceManager mgr = new XmlNamespaceManager(doc.NameTable);
            mgr.AddNamespace(ObjSop.Prefix, ObjSop.NamespaceURI);
            mgr.AddNamespace(WSSecurity.Prefix, WSSecurity.NamespaceURI);
            mgr.AddNamespace(WSUtility.Prefix, WSUtility.NamespaceURI);
            mgr.AddNamespace(SAML.Prefix, SAML.NamespaceURI);

            //Create expression to locate wsse:Security.
            SecurityExpression = doc.CreateNavigator().Compile("/" +
              ObjSop.Prefix + ":" + SoapElementNames.Envelope + "/" +
              ObjSop.Prefix + ":" + SoapElementNames.Header + "/" +
              WSSecurity.Prefix + ":" + WSSecurity.ElementNames.Security);
            SecurityExpression.SetContext(mgr);


            //Locate the WS-Security elements.
            XPathNodeIterator security = envelope.CreateNavigator().Select(SecurityExpression);

            //Is the WS-Security element is found, look for the username token
            if (security.MoveNext())
            {
                XmlNode secnode = ((IHasXmlNode)security.Current).GetNode();
                XmlNode secnodeold = secnode;

                //If the token is already present, 
                XPathNodeIterator samlToken = secnode.CreateNavigator().Select("//saml:Assertion", mgr);
                if (samlToken.MoveNext())
                {
                    XmlNode xn = ((IHasXmlNode)samlToken.Current).GetNode();
                    if (xn.LocalName == "Assertion")
                    {
                        XmlNode samlNode = secnode.SelectSingleNode("//saml:Assertion", mgr);

                        //Gets the saml response from the server
                        SAMLDocument = new XmlDocument();
                        SAMLDocument.LoadXml(samlNode.OuterXml);

                        //to be Removed.
                        string finalFilePath = "C:/Temp/SAML/" + "SamlContent.webinfo";
                        SAMLDocument.Save(finalFilePath);

                        //remove the saml from response
                        secnode.RemoveChild(xn);
                    }
                }

                //If the token is already present, 
                XPathNodeIterator userToken = secnode.CreateNavigator().Select("//wsse:UsernameToken", mgr);
                if (userToken.MoveNext())
                {
                    XmlNode xn = ((IHasXmlNode)userToken.Current).GetNode();
                    if (xn.LocalName == "UsernameToken")
                    {
                        //remove the UsernameToken from response
                        secnode.RemoveChild(xn);
                    }
                }

                envelope.CreateHeader().ReplaceChild(secnode, secnodeold);

                //Assigning ResponseXML Globally.
                IRSInputFilter.ResponseXML = envelope.InnerXml;
            }
            return SoapFilterResult.Continue;

        }
    }
}
