using Newtonsoft.Json;

namespace projektOOP.Data
{
    internal static class StaticDb
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static User CurrentUser { get; set; } = new User();

        public static void Load()
        {
            if (File.Exists("users.json"))
            {
                var data = File.ReadAllText("users.json");
                Users = JsonConvert.DeserializeObject<List<User>>(data)!;
            }
        }

        public static void Save()
        {
            var data = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText("users.json", data);
        }

        public static void UpdateCart()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].UserName == CurrentUser.UserName)
                    Users[i] = CurrentUser;
            }
            Save();
        }
        public static void AddToCart(string description, int price)
        {
            Order order = new Order
            {
                Description = description,
                Price = price
            };

            CurrentUser.Cart.Add(order);
            UpdateCart();
            MessageBox.Show("Order added", "Order", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
