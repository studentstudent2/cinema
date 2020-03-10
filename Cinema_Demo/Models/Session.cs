using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Demo.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FilmId { get; set; }
        public int HallId { get; set; }
    }
}
