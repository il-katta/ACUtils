﻿namespace ACUtils
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class DbFieldAttribute : System.Attribute, IDbFieldAttribute
    {
        public string DbField { get; protected set; }

        public DbFieldAttribute(string db_field = null)
        {
            this.DbField = db_field;
        }
    }
}
