using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentosCRUD.Models
{
    public class Alimento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}