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
    }
}
