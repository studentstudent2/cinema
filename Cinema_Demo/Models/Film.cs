using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Demo.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public int LanguageId { get; set; }
        public int AgeLimit { get; set; }
        public double Rating { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
