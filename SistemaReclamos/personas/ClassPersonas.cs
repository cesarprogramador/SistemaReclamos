using SistemaReclamos.conexion;
using SistemaReclamos.tiposervicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReclamos.personas
{
    class ClassPersonas
    {
        public string bandera { get; set; }
        public string idpersona { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public string cel { get; set; }
        public string tel { get; set; }
        public string correo { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string piso { get; set; }
        public string dpto { get; set; }
        public string idtipopersona { get; set; }
        public string tipopersona { get; set; }
        public string idtiposervicio { get; set; }
        public string tiposervicio { get; set; }
        public string numreferencia { get; set; }
        public string observacion { get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
        public string fechaingreso { get; set; }
        public string fechaegreso { get; set; }
        
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public string sql { get; set; }

        public DataSet LoginPersona(ClassPersonas _usuario,String _tabla)
        {
            sql = "CALL sp_login('" + _usuario.usuario + "','" + _usuario.pass + "');";

            return this.RealizarAccion(sql, _tabla);
        }
       
        public DataSet BuscarPersonaClientes(ClassPersonas _cliente, string _tabla)
        {
            sql = "CALL sp_buscadorclientes('" + _cliente.idpersona + "','" + _cliente.apellido + "','" + _cliente.nombre + "','" + _cliente.dni + "','" + _cliente.accion + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }
        
        public DataSet ABMPersona(ClassPersonas _persona, string _tabla)
        {

            sql = "CALL sp_abmpersona(" + _persona.idpersona + ",'" + _persona.apellido + "','" + _persona.nombre + "','" + _persona.dni + "','" + _persona.cel + "','" + _persona.tel + "','" + _persona.correo + "','" + _persona.calle + "','" + _persona.numero + "','" + _persona.piso + "','" + _persona.dpto + "'," + _persona.idtiposervicio + ",'" + _persona.numreferencia + "','" + _persona.observacion + "','" + _persona.usuario + "','" + _persona.pass + "'," + _persona.idtipopersona + ",'" + _persona.accion + "','" + _persona.fechaaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }
        
        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataTable BuscarTipoServicios(ClassPersonas _tiposervicio)
        {
            sql = "CALL sp_buscadortiposervicios(" + _tiposervicio.idtiposervicio + ",'" + _tiposervicio.tiposervicio + "',0,100);";

            return this.RealizarAccion(sql);
        }

        public DataTable BuscarTipoPersonas(ClassPersonas _tipopersona)
        {
            sql = "CALL sp_buscadortipopersonas(" + _tipopersona.idtipopersona + ",'" + _tipopersona.tipopersona + "',0,100);";

            return this.RealizarAccion(sql);
        }

        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }

        public DataSet BuscarPersonaEmpleados(ClassPersonas _empleado, string _tabla)
        {
            sql = "CALL sp_buscadorempleados(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.dni + "'," + _empleado.idtipopersona + ",'" + _empleado.accion + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }
       
    }
}
