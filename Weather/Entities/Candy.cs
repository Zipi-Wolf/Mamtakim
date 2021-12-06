using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Weather.Entities;

namespace MamtakNetApp.Entities
{
    public class Candy : BaseEntity
    {
        [Key]
        public string Key { get; set; }
        public string CandyName { get; set; }
        public float Price { get; set; }
    }
}
