using DataContract.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    public interface IKqlClient
    {
        Task<ResultSet> ExecuteScriptAsync(string kqlScript);
    }
}