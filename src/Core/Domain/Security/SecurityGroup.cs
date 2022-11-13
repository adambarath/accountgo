using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Security
{
    [Table(TableName)]
    public class SecurityGroup : BaseEntity
    {
        [NotMapped]
        public const string TableName = "SecurityGroups";

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public virtual ICollection<SecurityPermission> Permissions { get; set; }

        public SecurityGroup()
        {
            Permissions = new HashSet<SecurityPermission>();
        }

        public SecurityGroup(int id, string name, string display) : this()
        {
            Id = id;
            Name = name;
            DisplayName = display;
        }
    }
}
