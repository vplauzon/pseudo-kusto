using System.Collections.Immutable;

namespace DataContract.Data
{
    public class RowSet
    {
        public IImmutableList<ColumnSchema> Schema { get; }

        public IImmutableList<T> GetColumn<T>(string columnName)
        {
            throw new NotImplementedException();
        }

        public IImmutableList<T> GetColumn<T>(int columnIndex)
        {
            throw new NotImplementedException();
        }
    }
}