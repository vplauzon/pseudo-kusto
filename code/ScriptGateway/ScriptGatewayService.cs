using DataContract;

namespace ScriptGateway
{
    public class ScriptGatewayService
    {
        public ScriptGatewayService(IKqlClient kqlClient)
        {
            KqlClient = kqlClient;
        }

        public IKqlClient KqlClient { get; }
    }
}