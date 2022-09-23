using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ACUtils
{
    public static class SqlDbExt
    {
        #region ToCsv
        public static void ToCSV(this SqlDb db, string queryString, string csvFilePath, char Escape = '"', char Quote = '"', string Delimiter = ";", bool BoolToIntConvert = false, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = db.QueryDataTable(queryString, queryParams);
            SqlDbExt.ToCsv(
                dataTable: dt,
                csvFilePath: csvFilePath,
                Escape: Escape,
                Quote: Quote,
                Delimiter: Delimiter,
                BoolToIntConvert: BoolToIntConvert
          );
        }

        public static void ToCSV(SqlConnection connection, string queryString, string csvFilePath, char Escape = '"', char Quote = '"', string Delimiter = ";", bool BoolToIntConvert = false, params KeyValuePair<string, object>[] queryParams)
        {
            DataTable dt = SqlDb_QueryDataTable.QueryDataTable(connection, queryString, queryParams);
            SqlDbExt.ToCsv(
                dataTable: dt,
                csvFilePath: csvFilePath,
                Escape: Escape,
                Quote: Quote,
                Delimiter: Delimiter,
                BoolToIntConvert: BoolToIntConvert
          );
        }

        public static void ToCsv(DataTable dataTable, string csvFilePath, char Escape = '"', char Quote = '"', string Delimiter = ";", bool BoolToIntConvert = false, CultureInfo cultureInfo = null)
        {

            CsvHelper.Configuration.CsvConfiguration csvConf = new CsvHelper.Configuration.CsvConfiguration(cultureInfo ?? CultureInfo.CurrentCulture)
            {
                TrimOptions = CsvHelper.Configuration.TrimOptions.InsideQuotes,
                Escape = Escape,
                Quote = Quote,
                Delimiter = Delimiter,
                TypeConverterCache = null
            };

            if (BoolToIntConvert)
            {
                csvConf.TypeConverterCache = new CsvHelper.TypeConversion.TypeConverterCache();
                csvConf.TypeConverterCache.AddConverter<bool>(new CsvBooleanConverter());
            }

            using (System.IO.StreamWriter textWriter = System.IO.File.CreateText(csvFilePath))
            {
                using (CsvHelper.CsvWriter csv = new CsvHelper.CsvWriter(textWriter, csvConf))
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        csv.WriteField(column.ColumnName);
                    }
                    csv.NextRecord();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            csv.WriteField(row[i]);
                        }
                        csv.NextRecord();
                    }
                    csv.Flush();
                }
                textWriter.Close();
            }
        }
        #endregion
    }
}
