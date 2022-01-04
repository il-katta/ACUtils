namespace ACUtils.AXRepository.Attributes
{
    public class AxDbFieldAttribute: AxFieldAttribute
    {
        private readonly string db_field;
        public string DbField => db_field;
        public AxDbFieldAttribute(string ax_field = null, string db_field = null, string description = null, int key = 0): base(ax_field: ax_field, description: description, key: key)
        {
            this.db_field = db_field;
        }
    }
}
