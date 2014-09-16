
namespace JTL.Tax1040.PaymentLibrary
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class outputMessageOut
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:schemas-cybersource-com:transaction-data-1.29", Order = 0)]
        public ReplyMessage replyMessage;

        public outputMessageOut()
        {
        }

        public outputMessageOut(ReplyMessage replyMessage)
        {
            this.replyMessage = replyMessage;
        }
    }

}
