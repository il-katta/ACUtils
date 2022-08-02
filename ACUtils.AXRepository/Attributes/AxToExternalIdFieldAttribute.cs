namespace ACUtils.AXRepository.Attributes
{
    public class AxToExternalIdFieldAttribute : AxDbFieldAttribute
    {
        public const string AX_KEY = "To_ExternalId";
        public AxToExternalIdFieldAttribute(string db_field = null, string description = null, int key = 0) : base(ax_field: AX_KEY, db_field: db_field, description: description, key: key)
        {

        }
    }
}
