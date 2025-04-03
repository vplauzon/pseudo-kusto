using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract.Data
{
    internal static class ResultSetHelper
    {
        public static async Task<DataSet> ToDataSetAsync(this ResultSet resultSet)
        {
            var dataSet = new DataSet();

            await foreach (var tableSet in resultSet.GetTableSetsAsync())
            {
                var table = new DataTable(tableSet.Name);

                //table.Columns.AddRange();

                dataSet.Tables.Add(table);
            }

            return dataSet;
        }

        public static async Task<DataTable> ToDataTableAsync(this ResultSet resultSet)
        {
            var dataSet = await resultSet.ToDataSetAsync();

            if(dataSet.Tables.Count == 0)
            {
                throw new InvalidDataException("DataSet has no table");
            }

            return dataSet.Tables[0];
        }
    }
}