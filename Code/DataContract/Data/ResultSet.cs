namespace DataContract.Data
{
    public class ResultSet
    {
        private readonly IAsyncEnumerable<ITableSet> _tableSets;
        private volatile int _getCount = 0;

        public ResultSet(IAsyncEnumerable<ITableSet> tableSets)
        {
            _tableSets = tableSets;
        }

        public IAsyncEnumerable<ITableSet> GetTableSetsAsync()
        {
            if (Interlocked.CompareExchange(ref _getCount, 1, 0) == 0)
            {
                return _tableSets;
            }
            else
            {
                throw new InvalidOperationException(
                    "Table set has already been accessed and can only be accessed once");
            }
        }
    }
}