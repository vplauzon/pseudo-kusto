using DataContract;
using QueryGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public abstract class MemoryBasedUnitTestBase
    {
        private readonly QueryGatewayService _queryGatewayService;

        protected MemoryBasedUnitTestBase()
        {
            _queryGatewayService = new QueryGatewayService();
        }

        protected IKqlClient KqlClient => _queryGatewayService.KqlClient;
    }
}