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
        private readonly ScriptGatewayService _scriptGatewayService;

        protected MemoryBasedUnitTestBase()
        {
            _scriptGatewayService = new ScriptGatewayService();
        }

        protected IKqlClient KqlClient => _scriptGatewayService.KqlClient;
    }
}