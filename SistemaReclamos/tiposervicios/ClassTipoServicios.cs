using SistemaReclamos.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReclamos.tiposervicios
{
    class ClassTipoServicios
    {
        public string bandera { get; set; }
        public string idtiposervicio { get; set; }
        public string servicio { get; set; }
        public string costo { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public string sql { get; set; }

        public DataSet ABMTipoServicio(ClassTipoServicios _tiposervicio, string _tabla)
        {
            sql = "CALL sp_abmtiposervicio(" + _tiposervicio.idtiposervicio + ",'" + _tiposervicio.servicio + "','" + _tiposervicio.costo + "','" + _tiposervicio.accion + "','" + _tiposervicio.fechaaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataTable BuscarTipoServicios(ClassTipoServicios _tiposervicio)
        {
            sql = "CALL sp_buscadortiposervicios(" + _tiposervicio.idtiposervicio + ",'" + _tiposervicio.servicio + "',0,100);";

            return this.RealizarAccion(sql);
        }

        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }
    }
}
