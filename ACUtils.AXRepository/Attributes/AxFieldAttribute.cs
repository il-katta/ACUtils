namespace ACUtils.AXRepository.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
    public class AxFieldAttribute : DbFieldAttribute, IAxFieldAttribute
    {
        readonly string ax_field;
        readonly string description;
        readonly int? _key;
        public string Description => description;
        public string AXField => ax_field;
        public int? Key => _key;
        public bool IsPrimaryKey => Key.GetValueOrDefault() > 0;

        public AxFieldAttribute(string ax_field = null, string description = null, int key = 0): base()
        {
            this.ax_field = ax_field;
            this.description = description;

            // non è possibile definire un attributo con parametri nullabili quindi il default è 0
            if (key == 0)
            {
                this._key = null;
            }
            else
            {
                this._key = key;
            }
        }

    }
}
