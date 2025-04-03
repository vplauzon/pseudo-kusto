using DataContract.Data;

namespace UnitTests
{
    public class UnitTest1 : MemoryBasedUnitTestBase
    {
        [Fact]
        public async Task Test1()
        {
            var result = await KqlClient.ExecuteScriptAsync("print 42");
            var table = await result.ToDataTableAsync();

            Assert.Single(table.Rows);
            Assert.Single(table.Columns);
            Assert.Equal(typeof(long), table.Columns[0].DataType);
            Assert.Equal(42, (long)table.Rows[0][0]);
        }
    }
}
