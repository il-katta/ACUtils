namespace ACUtils.AXRepository.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
    public class AxClassAttribute : System.Attribute, IAxClassAttribute
    {
        readonly string _doc_type;
        readonly string _description;
        readonly bool _barcode;
        readonly bool _skip_key_check;
        readonly string _stato;
        public string DocumentType => _doc_type;
        public string Description => _description;
        public bool Barcode => _barcode;
        public bool SkipKeyCheck => _skip_key_check;
        public string Stato => _stato;
        public AxClassAttribute(string document_type, string description, bool barcode = false, bool skip_key_check = false, string stato = null)
        {
            this._doc_type = document_type;
            this._description = description;
            this._barcode = barcode;
            this._skip_key_check = skip_key_check;
            this._stato = stato;
        }
    }
}
