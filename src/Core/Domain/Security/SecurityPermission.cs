using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Security
{
    [Table(TableName)]
    public class SecurityPermission : BaseEntity
    {
        [NotMapped]
        public const string TableName = "SecurityPermission";

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int SecurityGroupId { get; set; }

        public virtual SecurityGroup Group { get; set; }
        public virtual ICollection<SecurityRolePermission> RolePermissions { get; set; }

        public SecurityPermission()
        {
            RolePermissions = new HashSet<SecurityRolePermission>();
        }
    }
}
