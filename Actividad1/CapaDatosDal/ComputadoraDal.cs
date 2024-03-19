using CapaModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosDal
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadorasDal()
        {
            string consulta = "select * from COMPUTADORA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarComputadoraDal(Computadora computadora)
        {
            string consulta = "insert into computadora values('" + computadora.Nombre + "'," +
                                                             "'" + computadora.Descripcion + "'" +
                                                             "'" + computadora.Precio + "'" +
                                                             "'" + computadora.FechaRegistro + "'";

            conexion.Ejecutar(consulta);
        }
    }
}
