using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Security
{
    [Table(TableName)]
    public class SecurityRole : BaseEntity
    {
        [NotMapped]
        public const string TableName = "SecurityRole";

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool SysAdmin { get; set; }
        public bool System { get; set; }
        public virtual ICollection<SecurityUserRole> Users { get; set; }
        public virtual ICollection<SecurityRolePermission> Permissions { get; set; }
        public SecurityRole()
        {
            Users = new HashSet<SecurityUserRole>();
            Permissions = new HashSet<SecurityRolePermission>();
        }
    }
}
