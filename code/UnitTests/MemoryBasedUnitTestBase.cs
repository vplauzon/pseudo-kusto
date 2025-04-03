using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public abstract class MemoryBasedUnitTestBase
    {
        protected IKqlClient KqlClient => (IKqlClient)null;
    }
}