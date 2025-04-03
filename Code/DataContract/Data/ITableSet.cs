using System.Collections.Immutable;

namespace DataContract.Data
{
    public interface ITableSet
    {
        string Name { get; }

        IImmutableList<ColumnSchema> Schema { get; }

        IAsyncEnumerable<RowSet> GetRowSetsAsync();
    }
}