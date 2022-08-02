namespace ACUtils.AXRepository.Attributes
{
    public class AxCcExternalIdFieldAttribute : AxDbFieldAttribute
    {
        public const string AX_KEY = "Cc_ExternalId";
        public AxCcExternalIdFieldAttribute(string db_field = null, string description = null, int key = 0) : base(ax_field: AX_KEY, db_field: db_field, description: description, key: key)
        {

        }
    }
}
