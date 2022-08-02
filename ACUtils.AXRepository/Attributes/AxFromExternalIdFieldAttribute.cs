namespace ACUtils.AXRepository.Attributes
{
    public class AxFromExternalIdFieldAttribute: AxDbFieldAttribute
    {
        public const string AX_KEY = "From_ExternalId";
        public AxFromExternalIdFieldAttribute(string db_field = null, string description = null, int key = 0) : base(ax_field: AX_KEY , db_field: db_field, description: description, key: key)
        {

        }
    }
}
