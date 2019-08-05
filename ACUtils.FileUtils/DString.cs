using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace ACUtils
{

    public class DString : IDisposable
    {
        public string Value { get; set; }

        public DString(string value)
        {
            Value = value;
        }

        public void Dispose()
        {
            if (FileUtils.IsDirectory(Value))
            {
                FileUtils.RecursiveDelete(Value);
            }
            if (FileUtils.IsFile(Value))
            {
                File.Delete(Value);
            }
        }

        public override string ToString()
        {
            return Value?.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return Value == null;
            }
            return (Value?.Equals(obj)).GetValueOrDefault();
        }

        public override int GetHashCode()
        {
            return (Value?.GetHashCode()).GetValueOrDefault();
        }
    }
}