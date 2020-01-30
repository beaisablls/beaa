using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class consulta
    {
        public int ID { get; set; }
        public string motivo { get; set; }
        public DateTime Dt_consulta { get; set; }
        public string receita { get; set; }
        public string diagnostico { get; set; }
        public DateTime dt_retorno { get; set; }
        public string motivoretorno{ get; set; }
        public int id_dentista { get; set; }
        public int id_paciente { get; set; }
    }
}
