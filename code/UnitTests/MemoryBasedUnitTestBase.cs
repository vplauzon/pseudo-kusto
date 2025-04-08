using DataContract;
using ScriptGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public abstract class MemoryBasedUnitTestBase
    {
        private readonly CentralGatewayKqlClient _centralGatewayKqlClient;

        protected MemoryBasedUnitTestBase()
        {
            _centralGatewayKqlClient = new CentralGatewayKqlClient();
        }

        protected IKqlClient KqlClient => _centralGatewayKqlClient;
    }
}