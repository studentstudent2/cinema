using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Demo.Models
{
    public class HallSector
    {
        public int Id { get; set; }
        public int SectorId { get; set; }
        public int HallId { get; set; }
        public int StartRow { get; set; }
        public int EndRow { get; set; }
    }
}
