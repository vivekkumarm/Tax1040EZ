using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using JTL.Tax1040.EfileServices.ZipandSendService.MeFTransmitterServicesMTOM;

namespace JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel
{
    public class mSendSubmissions : SendSubmissions
    {
        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetSubmissionStatus : GetSubmissionStatus
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetSubmissionsStatus : GetSubmissionsStatus
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetNewSubmissionsStatus : GetNewSubmissionsStatus
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetNewAcks : GetNewAcks
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetAcksByMsgID : GetAcksByMsgID
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetAcks : GetAcks
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }

    public class mGetAck : GetAck
    {
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            // if the response is non-MTOM like a SOAP fault, tell the proxy
            //   we don't really need MTOM
            if (response != null && response.Headers[HttpResponseHeader.ContentType].ToLower().StartsWith("text/xml"))
            {
                this.RequireMtom = false;
            } return response;
        }
    }
}
