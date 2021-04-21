using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.Odbc;

namespace CapaControlador
{
    public class clsControlador
    {
        clsSentencias sn = new clsSentencias();
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = sn.funcLlenarCmb(Tabla, Campo);
            return Items;
        }

        public void translado(string nombre, string fechainicio, string fechadev, int tarjeta)
        {
            sn.procInsertar(nombre, fechainicio, fechadev, tarjeta);
        }

        public void translado2(int codigo, int registro, int cantidad)
        {
            sn.procInsertar2(codigo,registro,cantidad);
        }

        
    }
}
