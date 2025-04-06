using System.Collections.Immutable;

namespace DataContract.Data
{
    public interface IRowSet
    {
        IImmutableList<ColumnSchema> Schema { get; }

        IImmutableList<T> GetColumn<T>(string columnName);

        IImmutableList<T> GetColumn<T>(int columnIndex);
    }
}