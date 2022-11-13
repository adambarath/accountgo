using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Security
{
    [Table(TableName)]
    public class SecurityUserRole : BaseEntity
    {
        [NotMapped]
        public const string TableName = "SecurityUserRole";

        public int UserId { get; set; }
        public int SecurityRoleId { get; set; }

        public virtual User User { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
    }
}
