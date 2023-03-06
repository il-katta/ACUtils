using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ACUtils
{
    public static class SqlDb_BulkInsert
    {
        public static void BulkInsert<T>(this SqlDb self, string tablename, IEnumerable<T> records)
        {
            using (var connection = self._getConnection())
            {
                using (var bc = new SqlBulkCopy(connection.Connection))
                {
                    bc.WriteToServer(self.BulkInsertPrepare(bc, tablename, records));
                }
            }
        }

        public static async System.Threading.Tasks.Task BulkInsertAsync<T>(this SqlDb self, string tablename, IEnumerable<T> records)
        {
            using (var connection = await self._getConnectionAsync())
            {
                using (var bc = new SqlBulkCopy(connection.Connection))
                {
                    await bc.WriteToServerAsync(self.BulkInsertPrepare(bc, tablename, records));
                }
            }
        }

        internal static DataTable BulkInsertPrepare<T>(this SqlDb self, SqlBulkCopy bc, string tablename, IEnumerable<T> records)
        {
            bc.DestinationTableName = tablename;
            var properties = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).Where(p => p.CanRead && !p.DeclaringType.IsConstructedGenericType);
            foreach (var property in properties)
            {
                var attr = DBModel.GetDbAttribute<T>(propertyName: property.Name);
                bc.ColumnMappings.Add(property.Name, attr?.DbField ?? property.Name);
            }
            return SqlDb.ToDataTable(records);
        }
    }
}
