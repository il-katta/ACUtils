namespace ACUtils.AXRepository.Attributes
{
    public class AxDbFieldAttribute: AxFieldAttribute
    {
        public AxDbFieldAttribute(string ax_field = null, string db_field = null, string description = null, int key = 0): base(ax_field: ax_field, description: description, key: key)
        {
            this.DbField = db_field;
        }
    }
}
