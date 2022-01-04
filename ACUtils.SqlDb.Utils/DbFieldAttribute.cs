namespace ACUtils
{
    public class DbFieldAttribute : System.Attribute, IDbFieldAttribute
    {
        public string DbField { get; }

        public DbFieldAttribute(string db_field = null)
        {
            this.DbField = db_field;
        }
    }
}
