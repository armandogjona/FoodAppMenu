namespace projektOOP.Data;

internal class User
{
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";
    public List<Order> Cart { get; set; } = new List<Order>();
}
