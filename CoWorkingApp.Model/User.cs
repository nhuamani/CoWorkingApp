using System;

namespace CoWorkingApp.Model
{
    public class User
    {
        public Guid UseId { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

    }
}
