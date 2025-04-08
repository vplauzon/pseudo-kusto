using QueryPlan.LogicalPlan;
using QueryPlan.Parsing;
using QueryPlan.Parsing.Query;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryPlan.PhysicalPlan
{
    public static class PhysicalPlanner
    {
        public static PhysicalPlanHead ToPhysicalPlan(LogicalPlanHead logicalPlan)
        {
            if (logicalPlan.QueryPlanHead != null)
            {
                if (logicalPlan.QueryPlanHead.PrintQueryPlan != null)
                {
                    return new PhysicalPlanHead(logicalPlan.QueryPlanHead.PrintQueryPlan);
                }
            }
         
            throw new NotImplementedException();
        }
    }
}