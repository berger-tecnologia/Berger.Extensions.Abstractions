namespace Berger.Extensions.Abstractions
{
    public interface IAddress
    {
        #region Properties
        Guid CountryId { get; set; }
        string GooglePlaceId { get; set; }
        string Label { get; set; }
        string Street { get; set; }
        string Number { get; set; }
        string Complement { get; set; }
        string Landmark { get; set; }
        string Neighborhood { get; set; }
        string Postcode { get; set; }
        string Reference { get; set; }
        decimal? Latitude { get; set; }
        decimal? Longitude { get; set; }
        bool Default { get; set; }
        #endregion
    }
}