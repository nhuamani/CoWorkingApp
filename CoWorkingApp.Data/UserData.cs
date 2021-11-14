using System;
using System.Linq;
using CoWorkingApp.Data.Helpers;
using CoWorkingApp.Model;

namespace CoWorkingApp.Data
{
    public class UserData
    {
        // Propiedad
        private JsonManager<User> jsonManager;

        // Constructor
        public UserData()
        {
            jsonManager = new JsonManager<User>();
        }

        public bool CreateAdmin()
        {
            var userCollection = jsonManager.GetCollection();

            if(!userCollection.Any(p => p.Name == "ADMIN" && p.LastName == "ADMIN" && p.Email == "ADMIN"))
            {
                var adminUser = new User()
                {
                    Name = "ADMIN",
                    LastName = "ADMIN",
                    Email = "ADMIN",
                    UserId = Guid.NewGuid(),
                    Password = EncryptData.EncryptText("ADMIN")
                };
            }

            return true;
        }

    }
}