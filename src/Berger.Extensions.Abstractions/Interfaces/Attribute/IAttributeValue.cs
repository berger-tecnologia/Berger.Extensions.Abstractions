namespace Berger.Extensions.Abstractions
{
    public interface IAttributeValue
    {
        #region Properties
        public Guid? ParentId { get; set; }
        //public Guid AttributeId { get; set; }
        string Name { get; set; }
        string Slug { get; set; }
        #endregion
    }
}