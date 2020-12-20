using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsHorarioEntidad
    {
        private int idHorario;
        private String dia;
        private String inicio;
        private String fin;

        public int IdHorario { get => idHorario; set => idHorario = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Inicio { get => inicio; set => inicio = value; }
        public string Fin { get => fin; set => fin = value; }
    }
}
