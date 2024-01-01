namespace thriftShop_API.Models.DAO;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Address> Address { get; set; }
}