using QueryPlan.Parsing;
using QueryPlan.Parsing.Query;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryPlan.LogicalPlan
{
    public static class LogicalPlanner
    {
        public static LogicalPlanHead ToLogicalPlan(Script script)
        {
            if (script.Query != null)
            {
                return new LogicalPlanHead(ToLogicalQueryPlan(script.Query));
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        private static LogicalQueryPlanHead ToLogicalQueryPlan(QueryScript query)
        {
            if (query.Print != null)
            {
                return new LogicalQueryPlanHead(ToLogicalPrint(query.Print));
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        private static LogicalPrint ToLogicalPrint(PrintScript print)
        {
            var columns = print.Columns
                .Select(c => ToLogicalQueryColumn(c))
                .ToImmutableArray();

            return new LogicalPrint(columns);
        }

        private static LogicalQueryColumn ToLogicalQueryColumn(ColumnScript columnScript)
        {
            return new LogicalQueryColumn(
                columnScript.ColumnName,
                ToLogicalScalar(columnScript.Literal));
        }

        private static LogicalScalar ToLogicalScalar(LiteralScript scalar)
        {
            if (scalar.Integer != null)
            {
                return new LogicalScalar(scalar.Integer);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}