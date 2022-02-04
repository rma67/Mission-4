using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class AddResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "A Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A Year is Required")]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "A Director is Required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "A Rating is Required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

        [Required(ErrorMessage = "A Category is Required")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
