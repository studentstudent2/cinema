using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Demo.Models
{
    public class Place
    {
        public int Id { get; set; }
        public int HallSectorId { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
    }
}
