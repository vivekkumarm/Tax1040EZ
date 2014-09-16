
namespace JTL.Tax1040.PaymentLibrary
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class inputMessageIn
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29", Order = 0)]
        public RequestMessage requestMessage;

        public inputMessageIn()
        {
        }

        public inputMessageIn(RequestMessage requestMessage)
        {
            this.requestMessage = requestMessage;
        }
    }

}
