using System.Collections.Generic;

namespace BaseMvc.Model
{
    public class Role : BaseModel
    {
        public Role(int id, string name, IEnumerable<Permission> permissions)
            : base(id)
        {
            Name = name;
            Permissions = permissions;
        }

        public string Name { get; private set; }

        public IEnumerable<Permission> Permissions { get; private set; }
    }
}