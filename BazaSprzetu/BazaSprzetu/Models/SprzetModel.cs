using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaSprzetu.Models
{
    public class SprzetModel
    {
        public int ID { get; set; }
        public string Rodzaj { get; set; }
        public string Producent { get; set; }
        public string Model { get; set; }
        public int Cena { get; set; }
    }
}
