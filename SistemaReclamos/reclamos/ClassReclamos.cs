﻿using SistemaReclamos.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReclamos.reclamos
{
    class ClassReclamos
    {
        public string bandera { get; set; }
        public string idreclamo { get; set; }
        public string idtiporeclamo { get; set; }
        public string reclamo { get; set; }
        public string numreferencia { get; set; }
        public string idproblematicareclamo { get; set; }
        public string idsigproblematicareclamo { get; set; }
        public string problematicareclamo { get; set; }
        public string idsi { get; set; }
        public string idno { get; set; }
        public string idcliente { get; set; }
        public string idempleado { get; set; }
        public string fechaini { get; set; }
        public string fechafin { get; set; }
        public string respuesta { get; set; }
        public string observacion { get; set; }
      
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public string sql { get; set; }

        public DataTable BuscarTipoReclamos(ClassReclamos _tiporeclamo)
        {
            sql = "CALL listartiposreclamos('" + _tiporeclamo.reclamo + "',0,100);";

            return this.RealizarAccion(sql);
        }

        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }

        public DataSet BuscarSiguienteReclamos(ClassReclamos _preguntareclamo,string _tabla)
        {
            sql = "CALL siguienteconsulta(" + _preguntareclamo.idtiporeclamo + "," + _preguntareclamo.idproblematicareclamo + ",'" + _preguntareclamo.respuesta + "',0,100);";

            return this.RealizarAccion(sql,_tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataSet ABMReclamo(ClassReclamos _reclamo, string _tabla)
        {
            sql = "CALL sp_abmreclamos(" + _reclamo.idreclamo + "," + _reclamo.idproblematicareclamo + ",'" + _reclamo.fechaini + "','" + _reclamo.fechafin + "'," + _reclamo.idcliente + "," + _reclamo.idempleado + "," + _reclamo.idtiporeclamo + ",'" + _reclamo.numreferencia + "','" + _reclamo.respuesta + "','" + _reclamo.observacion + "','" + _reclamo.accion + "','" + _reclamo.fechaaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet BuscarHistorialReclamos(ClassReclamos _reclamo, string _tabla)
        {
            sql = "CALL listarhistorialreclamos('" + _reclamo.numreferencia + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataTable BuscarNumReferenciasDeReclamos(ClassReclamos _listarnumreclamos)
        {
            sql = "CALL listarnumreferenciasdereclamos(" + _listarnumreclamos.idcliente + ",0,100);";

            return this.RealizarAccion(sql);
        }

        public DataSet BuscarReclamosPorEmpleados(ClassReclamos _reclamo, string _tabla)
        {
            sql = "CALL listarreclamosporempleados(" + _reclamo.idempleado + ",0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        public DataSet BuscarReclamosPorReferencia(ClassReclamos _listarnumreclamos,string _tabla)
        {
            sql = "CALL listarreclamosporeferencia('" + _listarnumreclamos.numreferencia + "',0,100);";

            return this.RealizarAccion(sql,_tabla);
        }

        public DataSet CierreReclamo(ClassReclamos _reclamo, string _tabla)
        {
            sql = "CALL sp_cerrarreclamo(" + _reclamo.idreclamo + ",'" + _reclamo.fechafin + "','" + _reclamo.observacion + "','" + _reclamo.accion + "','" + _reclamo.fechaaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }
    }
}
