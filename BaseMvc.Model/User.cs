using System.Collections.Generic;

namespace BaseMvc.Model
{
    public class User : BaseModel
    {
        public User(int id, string userName, string firstName, string lastName, bool isActive, IEnumerable<Role> roles)
            : base(id)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            IsActive = isActive;
            Roles = roles;
        }

        public string UserName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public bool IsActive { get; private set; }

        public IEnumerable<Role> Roles { get; private set; }
    }
}
