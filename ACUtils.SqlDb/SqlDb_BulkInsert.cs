using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ACUtils
{
    public static class SqlDb_BulkInsert
    {
        public static void BulkInsert<T>(this SqlDb self, string tablename, IEnumerable<T> records)
        {
            using (var bc = new SqlBulkCopy(self.ConnectionString))
            {
                bc.WriteToServer(self.BulkInsertPrepare(bc, tablename, records));
            }
        }
        public static async System.Threading.Tasks.Task BulkInsertAsync<T>(this SqlDb self, string tablename, IEnumerable<T> records)
        {
            using (var bc = new SqlBulkCopy(self.ConnectionString))
            {
                await bc.WriteToServerAsync(self.BulkInsertPrepare(bc, tablename, records));
            }
        }

        internal static DataTable BulkInsertPrepare<T>(this SqlDb self, SqlBulkCopy bc, string tablename, IEnumerable<T> records)
        {
            bc.DestinationTableName = tablename;
            var properties = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var property in properties)
            {
                bc.ColumnMappings.Add(property.Name, property.Name);
            }
            return SqlDb.ToDataTable(records);
        }
    }
}
