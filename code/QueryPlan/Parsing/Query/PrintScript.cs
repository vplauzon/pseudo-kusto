using System.Collections.Immutable;

namespace QueryPlan.Parsing.Query
{
    public record PrintScript(ColumnScript[] Columns)
    {
        public PrintScript ToLogicalPlan()
        {
            return EnsureColumnNames();
        }

        private PrintScript EnsureColumnNames()
        {
            var newColumns = Columns
                .Zip(Enumerable.Range(0, Columns.Length), (c, i) => new
                {
                    Column = c,
                    Index = i
                })
                .Select(p=>new ColumnScript(
                    p.Column.ColumnName ?? $"print_{p.Index}",
                    p.Column.Literal))
                .ToArray();

            return new PrintScript(newColumns);
        }
    }
}