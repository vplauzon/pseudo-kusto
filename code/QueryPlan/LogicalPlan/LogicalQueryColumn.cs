
namespace QueryPlan.LogicalPlan
{
    public record LogicalQueryColumn(string? ColumnName, LogicalScalar Scalar);
}