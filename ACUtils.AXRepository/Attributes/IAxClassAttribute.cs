namespace ACUtils.AXRepository.Attributes
{
    public interface IAxClassAttribute
    {
        public string DocumentType { get; }
        public string Description { get; }
        public bool Barcode { get; }
        public bool SkipKeyCheck { get; }
        public string Stato { get; }
    }

}
