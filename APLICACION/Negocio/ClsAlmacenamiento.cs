using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APLICACION.Entidades;

namespace APLICACION.Negocio
{
    public class ClsAlmacenamiento
    {
       public int conteo (Almacenamiento almacenamiento){
        return almacenamiento.letras.Length;
       }
    }
}