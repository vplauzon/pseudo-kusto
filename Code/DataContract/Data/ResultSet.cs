namespace DataContract.Data
{
    public class ResultSet
    {
        IAsyncEnumerable<ITableSet> GetTableSetsAsync();
    }
}