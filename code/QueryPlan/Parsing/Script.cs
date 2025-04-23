using QueryPlan.Parsing.Query;

namespace QueryPlan.Parsing
{
    public record Script(QueryScript? Query)
    {
        public Script ToLogicalPlan()
        {
            return new Script(Query?.ToLogicalPlan());
        }

        public Script ToPhysicalPlan()
        {
            throw new NotImplementedException();
        }
    }
}