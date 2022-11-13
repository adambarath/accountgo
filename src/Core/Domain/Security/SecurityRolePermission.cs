using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Security
{
    [Table(TableName)]
    public class SecurityRolePermission : BaseEntity
    {
        [NotMapped]
        public const string TableName = "SecurityRolePermission";

        public int SecurityRoleId { get; set; }
        public int SecurityPermissionId { get; set; }

        public virtual SecurityRole SecurityRole { get; set; }
        public virtual SecurityPermission SecurityPermission { get; set; }
    }
}
