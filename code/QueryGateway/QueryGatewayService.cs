using DataContract;

namespace QueryGateway
{
    public class QueryGatewayService
    {
        public QueryGatewayService()
        {
        }

        public IKqlClient KqlClient { get; }
    }
}