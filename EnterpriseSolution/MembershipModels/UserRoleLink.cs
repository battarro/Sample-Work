using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembershipModels
{
    [Table("MembershipUserRoleLink")]
    public class UserRoleLink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get; set;
        }

        [ForeignKey("User")]
        public int UserId
        {
            get; set;
        }

        [ForeignKey("Role")]
        public int RoleId
        {
            get; set;
        }

        public virtual Role Role
        {
            get; set;
        }

        public virtual User User
        {
            get; set;
        }
    }
}
