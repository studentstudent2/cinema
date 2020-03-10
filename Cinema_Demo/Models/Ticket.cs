using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Demo.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int PlaceId { get; set; }
        public DateTime DateOfSale { get; set; }
        public decimal Price { get; set; }
    }
}
