using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACUtils
{
    class CsvBooleanConverter : DefaultTypeConverter
    {
        public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            if (value == null)
            {
                return string.Empty;
            }
            return ((bool)value) ? "1" : "0";
        }
    }
}
