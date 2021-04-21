using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo
{
    public class clsSentencias
    {
        clsConexion con = new clsConexion();

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        //funcion que retorna los elementos de una tabla para llenar los comboBox
        public string[] funcLlenarCmb(string Tabla, string Campo)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo + " FROM " + Tabla + " WHERE estado = 1 ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -");
            }
            return Campos;
        }




        public void procInsertar(string nombre, string fechainicio, string fechadev, int tarjeta)
        {
            int codigo = 0;
            string sql = "SELECT MAX(idEncabezadoPrestamo) FROM encabezadoprestamo ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    codigo = reader.GetInt16(0);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros "); }

            codigo++;

            try
            {
                string insertarProducto = "INSERT INTO encabezadoprestamo VALUES (" + codigo + ",'" + fechainicio + "','" + fechadev +"',"+ tarjeta + ",'" + nombre + "')";
                OdbcCommand comm3 = new OdbcCommand(insertarProducto, con.conexion());
                comm3.ExecuteNonQuery();
                MessageBox.Show("Datos de encabezado ingresados");
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message.ToString() + "error ingresando datos");
            }

        }


        public void procInsertar2(int codigo, int registro, int cantidad)
        {
          
            try
            {
                string insertarProducto = "INSERT INTO detalleprestamo VALUES (" + codigo + ","+registro+","+cantidad+")";
                OdbcCommand comm3 = new OdbcCommand(insertarProducto, con.conexion());
                comm3.ExecuteNonQuery();
                MessageBox.Show("Datos de detalle ingresados");
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message.ToString() + "error ingresando datos");
            }

        }

    }
}
