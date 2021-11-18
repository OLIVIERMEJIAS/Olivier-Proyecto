using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EHorario
    {
        private ushort horarioId { get; set; }
        private string seccion { get; set; }
        ArrayList detalles;
        
        
        public EHorario()
        {
            horarioId = 0;
            seccion = "";
            detalles = new ArrayList();
        }

        public EHorario(ushort horarId,string sec)
        {
            horarioId = horarId;
            seccion = sec;
            detalles = new ArrayList();
        }
    }

   
}
