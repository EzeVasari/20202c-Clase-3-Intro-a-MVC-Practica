using AlimentosCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentosCRUD.Services
{
    public class AlimentoService
    {
        public static List<Alimento> listaAlimentos = new List<Alimento>();

        public List<Alimento> ObtenerAlimentos()
        {
            return listaAlimentos;
        }
    }
}