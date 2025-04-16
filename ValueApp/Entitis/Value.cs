using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueApp.Entitis
{
    public class Value
    {
        [Key]
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(8)]
        public string Name { get; set; }


    }
}
