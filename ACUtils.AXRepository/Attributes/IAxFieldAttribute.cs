namespace ACUtils.AXRepository.Attributes
{
    public interface IAxFieldAttribute
    {
        public string Description { get;  }
        public string AXField { get; }
        public int? Key { get; }
        public bool IsPrimaryKey { get; }
    }
}
