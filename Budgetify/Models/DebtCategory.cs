using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetify.Models
{
    public class DebtCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Debt Category")]
        public string Name { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
