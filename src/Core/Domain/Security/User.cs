using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Security
{
    [Table(TableName)]
    public class User : BaseEntity
    {
        [NotMapped]
        public const string TableName = "User";

        public User()
        {
            Roles = new HashSet<SecurityUserRole>();
        }

        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual ICollection<SecurityUserRole> Roles { get; set; }

        public bool IsSysAdmin()
        {
            bool isSysAdmin = false;

            if (this.Roles.Count > 0)
            {
                foreach (var role in Roles)
                    if (role.SecurityRole.Name == "Administrator")
                    {
                        isSysAdmin = true;
                        break;
                    }
            }

            return isSysAdmin;
        }
    }
}
