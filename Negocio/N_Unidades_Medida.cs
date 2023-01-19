using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Unidades_Medida
    {
        public static DataTable Listar_um(string cTexto)
        {
            D_Unidades_Medida Datos = new D_Unidades_Medida();
            return Datos.Listar_um(cTexto);
        }

        public static string Guardar_um(int Opcion, E_Unidad_Medida oUm)
        {
            D_Unidades_Medida Datos = new D_Unidades_Medida();
            return Datos.Guardar_um(Opcion, oUm);
        }
        public static string Eliminar_um(int Codigo)
        {
            D_Unidades_Medida Datos = new D_Unidades_Medida();
            return Datos.Eliminar_um(Codigo);
        }

    }
}
