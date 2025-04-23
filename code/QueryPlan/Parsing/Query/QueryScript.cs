using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryPlan.Parsing.Query
{
    public record QueryScript(PrintScript? Print)
    {
        public QueryScript ToLogicalPlan()
        {
            return new QueryScript(Print?.ToLogicalPlan());
        }
    }
}
