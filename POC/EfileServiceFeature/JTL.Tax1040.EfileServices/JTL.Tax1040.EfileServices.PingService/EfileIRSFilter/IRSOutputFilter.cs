using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using System.Collections;
using System.Xml;
using System.Configuration;

using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security;
using Microsoft.Web.Services3.Security.Utility;

namespace JTL.Tax1040.EfileServices.PingService
{
    public class IRSOutputFilter : SoapFilter
    {
        private string username;
        private string password;

        public static string RequestXML = null;
        private static XPathExpression SecurityExpression;


        public IRSOutputFilter(string username, string password)

            : base()
        {
            this.username = username;
            this.password = password;

        }

        public override SoapFilterResult ProcessMessage(SoapEnvelope envelope)
        {


            //creating the <wsse:Security> element in the outgoing message
            XmlNode securityNode = envelope.CreateNode(XmlNodeType.Element, "wsse:Security", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            XmlAttribute securityAttr = envelope.CreateAttribute("soap:mustUnderstand");
            securityAttr.Value = "1";
            securityNode.Attributes.Append(securityAttr);

            //creating the <wsse:usernameToken> element
            XmlNode usernameTokenNode = envelope.CreateNode(XmlNodeType.Element, "wsse:UsernameToken", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            XmlElement userElement = usernameTokenNode as XmlElement;
            userElement.SetAttribute("xmlns:wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");

            //creating the <wsse:Username> element
            XmlNode userNameNode = envelope.CreateNode(XmlNodeType.Element, "wsse:Username", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            userNameNode.InnerXml = username;

            //creating the <wsse:password> element
            XmlNode pwdNode = envelope.CreateNode(XmlNodeType.Element, "wsse:Password", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            XmlElement pwdElement = pwdNode as XmlElement;
            pwdElement.SetAttribute("Type", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText");
            pwdNode.InnerXml = password;

            usernameTokenNode.AppendChild(userNameNode);
            usernameTokenNode.AppendChild(pwdNode);
            securityNode.AppendChild(usernameTokenNode);
            envelope.ImportNode(securityNode, true);
            XmlNode node = envelope.Header;
            node.AppendChild(securityNode);

            //removing Addressing headers from the outgoing request
            XmlNode actionNode = envelope.Header["wsa:Action"];
            envelope.Header.RemoveChild(actionNode);
            XmlNode messageNode = envelope.Header["wsa:MessageID"];
            envelope.Header.RemoveChild(messageNode);
            XmlNode replyToNode = envelope.Header["wsa:ReplyTo"];
            envelope.Header.RemoveChild(replyToNode);
            XmlNode toNode = envelope.Header["wsa:To"];
            envelope.Header.RemoveChild(toNode);


            Soap ObjSop = envelope.CurrentSoap;
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


            XPathNodeIterator security = envelope.CreateNavigator().Select(SecurityExpression);
            if (security.MoveNext())
            {

                XmlNode secnode = ((IHasXmlNode)security.Current).GetNode();
                XmlNode secnodeold = secnode;
                //if must understand attribute is in the security node-- Ravi
                if (((XmlElement)secnode).HasAttribute("soap:mustUnderstand"))
                {
                    ((XmlElement)secnode).RemoveAttribute("soap:mustUnderstand");
                }

                //If the token is already present, 
                XPathNodeIterator sectoken = secnode.CreateNavigator().Select("//wsse:Nonce", mgr);
                if (sectoken.MoveNext())
                {
                    XmlNode xn = ((IHasXmlNode)sectoken.Current).GetNode();
                    if (xn.LocalName == "Nonce")
                    {
                        secnode["wsse:UsernameToken"].RemoveChild(xn);
                    }
                    string test22 = sectoken.Current.OuterXml;
                }

                //below code will remove the Timestamp from security
                XPathNodeIterator timestamptoken = secnode.CreateNavigator().Select("//wsu:Timestamp", mgr);
                if (timestamptoken.MoveNext())
                {
                    XmlNode xn = ((IHasXmlNode)timestamptoken.Current).GetNode();
                    if (xn.LocalName == "Timestamp")
                    {
                        secnode.RemoveChild(xn);
                    }
                }

                //below code will remove the Created element in User name token
                XPathNodeIterator createdtoken = secnode.CreateNavigator().Select("//wsu:Created", mgr);
                if (createdtoken.MoveNext())
                {
                    XmlNode xn = ((IHasXmlNode)createdtoken.Current).GetNode();
                    if (xn.LocalName == "Created")
                    {
                        //if (secnode["wsu:Created"] != null)
                        secnode["wsse:UsernameToken"].RemoveChild(xn);
                    }
                }

                if (IRSInputFilter.SAMLDocument != null)
                {
                    string SAMLxml = IRSInputFilter.SAMLDocument.InnerXml;

                    XmlDocument samlDoc = new XmlDocument();
                    samlDoc.LoadXml(SAMLxml);

                    XmlDocument secDoc = new XmlDocument();
                    secDoc.LoadXml(secnode.OuterXml);
                    XmlNode secNewNode = (XmlNode)secDoc.DocumentElement;

                    //secnode.AppendChild (new xmlnode)
                    XPathNodeIterator samlToken = samlDoc.CreateNavigator().Select("//saml:Assertion", mgr);
                    if (samlToken.MoveNext())
                    {
                        XmlNode xn = ((IHasXmlNode)samlToken.Current).GetNode();
                        if (xn.LocalName == "Assertion")
                        {
                            secNewNode.PrependChild(secDoc.ImportNode(xn, true));
                        }
                    }
                    secnode = secNewNode;
                }

                RequestXML = envelope.InnerXml;

                XmlDocument envDoc = new XmlDocument();
                envelope.CreateHeader().RemoveChild(secnodeold);
                envDoc.LoadXml(envelope.OuterXml);

                XmlNode newEnvelope = (XmlNode)envDoc.DocumentElement;
                newEnvelope["soap:Header"].AppendChild(envDoc.ImportNode(secnode, true));
                envelope.DocumentElement.InnerXml = newEnvelope.InnerXml;
                RequestXML = envelope.InnerXml;
            }

            return SoapFilterResult.Continue;

        }

    }
}
