using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuzikStoreRazor.UI.Models
{
    public class Muzik
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Aouthor { get; set; }

    }
}
