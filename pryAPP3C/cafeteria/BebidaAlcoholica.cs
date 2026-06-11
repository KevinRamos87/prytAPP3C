using BebidasCalientesOfrias.Cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryAPP3C.cafeteria
{
    internal class BebidaAlcoholica:Bebida
    {
        protected float gradosAlcohol;
        protected bool tienegluten;
        public float GradosAlcohol
        {
            get { return gradosAlcohol; }
            set { gradosAlcohol = value; }
        }

        public bool Tienegluten
        {
            get { return tienegluten; }
            set { Tienegluten = value; }
        }

        public BebidaAlcoholica(string _nombre, string _tamaño, float _precio, float _gradosAlcohol, bool _gluten) : base(_nombre, _tamaño, _precio)
        {
            gradosAlcohol = _gradosAlcohol;
            tienegluten = _gluten;
        }

        public override string Preparar()
        {
            // Esta instrucción la aprendí haciendo la actividad
            // El operador ternario evalúa una condición:
            // si tienegluten es verdadero devuelve "Sí" si es falso devuelve "No"
            string gluten = tienegluten ? "Sí" : "No";
            return "Preparando: " + Nombre + "\nDe tamaño : " + Tamaño + "\nCon grados de alcohol: " + gradosAlcohol + "\nTiene gluten? " + gluten;
        }

        public override string Listar()
        {
            return "Preparando un/a bebida: " + nombre;

        }
    }
}
