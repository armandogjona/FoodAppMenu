﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace projektOOP.Data
{
    // Klasa StaticDb esht klas statike qe mban te dhenat e userave dhe metodat per menaxhimin e tyre
    internal static class StaticDb
    {
        // Lista statike Users mban tgjith perdoruesit e regjistruar
        public static List<User> Users { get; set; } = new List<User>();
        public static User CurrentUser { get; set; } = new User(); // per userin aktual

        public static void Load() //ngarkon te dhenat e userave neqoftese users.json ekziston
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
        } //ruan te dhenat e perdorueseve ne data tek users.json

        public static void UpdateCart()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].UserName == CurrentUser.UserName)
                    Users[i] = CurrentUser;
            }
            Save();
        }
        // perditeson karrocen e perdoruesit aktual ne listen e perdoruesve
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
