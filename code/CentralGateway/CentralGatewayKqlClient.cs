using DataContract;
using DataContract.Data;
using QueryPlan.LogicalPlan;
using QueryPlan.Parsing;

namespace ScriptGateway
{
    public class CentralGatewayKqlClient : IKqlClient
    {
        Task<ResultSet> IKqlClient.ExecuteScriptAsync(string kqlScript)
        {
            var script = ScriptParser.ParseScript(kqlScript);
            var logicalPlan = LogicalPlanner.FromScript(script);

            throw new NotImplementedException();
        }
    }
}