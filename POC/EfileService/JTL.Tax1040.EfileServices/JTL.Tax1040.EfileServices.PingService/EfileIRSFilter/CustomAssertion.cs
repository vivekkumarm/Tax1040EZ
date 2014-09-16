using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Services3.Design;
using Microsoft.Web.Services3;
using System.Xml;
using Microsoft.Web.Services3.Security.Utility;
using Microsoft.Web.Services3.Security;
using System.Xml.XPath;

namespace JTL.Tax1040.EfileServices.PingService
{
    public class RemoveAddressingHeadersAssertion : PolicyAssertion
    {

        private string username;
        private string password;

        public RemoveAddressingHeadersAssertion(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override SoapFilter CreateClientInputFilter(FilterCreationContext context)
        {

            return new IRSInputFilter();

        }

        public override SoapFilter CreateClientOutputFilter(FilterCreationContext context)
        {

            return new IRSOutputFilter(username, password);

        }

        public override SoapFilter CreateServiceInputFilter(FilterCreationContext context)
        {

            return new ServiceInputFilterNew();

        }

        public override SoapFilter CreateServiceOutputFilter(FilterCreationContext context)
        {

            return new ServiceOutputFilterNew();

        }

        public override System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Type>> GetExtensions()
        {

            return new KeyValuePair<string, Type>[] { new KeyValuePair<string, Type>("RemoveAddressingHeadersAssertion", this.GetType()) };

        }

        public override void ReadXml(XmlReader reader, IDictionary<string, Type> extensions)
        {

            reader.ReadStartElement("RemoveAddressingHeadersAssertion");

        }

    }



    public class ServiceInputFilterNew : SoapFilter
    {

        public override SoapFilterResult ProcessMessage(SoapEnvelope envelope)
        {

            return SoapFilterResult.Continue;

        }

    }

    public class ServiceOutputFilterNew : SoapFilter
    {

        public override SoapFilterResult ProcessMessage(SoapEnvelope envelope)
        {

            return SoapFilterResult.Continue;

        }

    }


}