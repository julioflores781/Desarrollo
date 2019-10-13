using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioPersona.Modelo.Prueba
{
    public class ClassCrea
    {
        public string documento { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
    }

    public class ClassActualiza
    {
        public int codigo_personal { get; set; }
        public string documento { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
    }

    public partial class ListaPersona
    {
        public int codigo_personal { get; set; }
        public string documento { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public Nullable<short> activo_sn { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_creacion { get; set; }
    }

    public class Encabezado
    {
        public List<ListaPersona> Items { get; set; }

    }






}
