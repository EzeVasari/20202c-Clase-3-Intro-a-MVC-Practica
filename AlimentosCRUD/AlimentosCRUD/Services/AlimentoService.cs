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

        public void CrearAlimento(Alimento a)
        {
            int maxId = 0;

            if(listaAlimentos.Count > 0)
            {
                maxId = listaAlimentos.Max(o => o.Id);
            }

            a.Id = maxId + 1;

            listaAlimentos.Add(a);
        }
    }
}