using System.Collections.Generic;
using FarmatodoWeb.Utils;

namespace FarmatodoWeb.Models{
    public class Modelos{
        public Paginador<Producto> Modelo_Paginador_Producto{get; set;}
        public IEnumerable<Persona> Modelo_IEnumerable_Persona{get; set;}
        public Producto Modelo_Producto{get; set;}
        public Persona Modelo_Persona{get; set;}
        //public PersonaBase Modelo_IEnumerable_Persona{get; set;}
    }
}