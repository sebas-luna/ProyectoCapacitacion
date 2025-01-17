﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
//using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Consultas sn = new Consultas();
        // LLenar una tabla CAPA CONTROLADOR
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        ///Controlador///

        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmb(tabla, campo1, campo2);

            return Items;


        }

        ///Controlador 2///

        public DataTable enviar(string tabla, string campo1, string campo2)
        {



            var dt1 = sn.obtener(tabla, campo1, campo2);

            return dt1;
        }


    }
}
