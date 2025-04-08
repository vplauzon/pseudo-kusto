using System.Collections.Immutable;

namespace QueryPlan.LogicalPlan
{
    public record LogicalPrint(IImmutableList<LogicalQueryColumn> Columns);
}