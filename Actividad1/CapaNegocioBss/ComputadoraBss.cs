using CapaDatosDal;
using CapaModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputadoraBss
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadorasDal();
        }

        public void InsertarComputadoraBss (Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
    }
}
