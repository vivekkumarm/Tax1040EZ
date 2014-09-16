
namespace JTL.Tax1040.PaymentLibrary
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class TransactionProcessorClient : System.ServiceModel.ClientBase<ITransactionProcessor>, ITransactionProcessor
    {

        public TransactionProcessorClient()
        {
        }

        public TransactionProcessorClient(string endpointConfigurationName)
            :
                base(endpointConfigurationName)
        {
        }

        public TransactionProcessorClient(string endpointConfigurationName, string remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public TransactionProcessorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public TransactionProcessorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(binding, remoteAddress)
        {
        }

        outputMessageOut ITransactionProcessor.runTransaction(inputMessageIn request)
        {
            return base.Channel.runTransaction(request);
        }

        public ReplyMessage runTransaction(RequestMessage requestMessage)
        {
            inputMessageIn inValue = new inputMessageIn();
            inValue.requestMessage = requestMessage;
            outputMessageOut retVal = ((ITransactionProcessor)(this)).runTransaction(inValue);
            return retVal.replyMessage;
        }
    }

}
