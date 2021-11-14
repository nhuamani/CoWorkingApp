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

    }
}