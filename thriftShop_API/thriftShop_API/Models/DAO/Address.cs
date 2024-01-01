namespace thriftShop_API.Models.DAO;

public class Address
{
    public int Id { get; set; }
    public string AddressIdentifierName { get; set; }
    public string StreetName { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string Code { get; set; }
    public string CityName { get; set; }
    public string CountryName { get; set; }
}