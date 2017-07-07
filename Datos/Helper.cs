using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datos;

namespace Datos
{
    public class Helper
    {

        private static List<ModuloDTO> _modulos;

        public static List<ModuloDTO> Modulos
        {
            get { return _modulos; }
            
        }

        private static List<UsuarioDTO> _usuarios;

        public static List<UsuarioDTO> Usuarios
        {
            get { return _usuarios; }

        }

        public static void GetUsuario()
        {
            using (var repo = new GrabadorRepository())
            {
                repo.GetUsuario();

                _modulos = repo.moduloDto;
                _usuarios = repo.usuarioDto;
            }
        }

        public static List<UsuarioDTO> SearchUsuario(int nroContrato)
        {
            using (var repo = new GrabadorRepository())
            {
                return repo.SearchUsuario(nroContrato);
            }
        }

        #region SQLCommand
        //public static DataTable dtModulos { get; set; }
        //public static DataTable dtUsuarios { get; set; }

        //private static string GetXMLPath()
        //{
        //    var path = Path.Combine(Environment.CurrentDirectory, "config.xml");
        //    if (!File.Exists(path))
        //    {
        //        throw new Exception(Resources.ConfigXMLNoExiste);
        //    }
        //    return path;
        //}

        //private static string Getvalue(string param)
        //{
        //    var pathXml = GetXMLPath();

        //    var xmlDoc = new XmlDocument();
        //    xmlDoc.Load(pathXml);

        //    var lista = xmlDoc.DocumentElement.GetElementsByTagName(param);

        //    if (lista.Count <= 0)
        //    {
        //        return "";
        //    }

        //    return lista.Item(0).InnerText;
        //}

        //public static string GetStringBD
        //{
        //    get
        //    {
        //        return Getvalue(Resources.XMLParamStringConexion);
        //    }
        //}

        //public static string GetNameSP
        //{
        //    get
        //    {
        //        return Getvalue(Resources.XMLParamSP);
        //    }
        //}

        //public static string GetNameSPSearch
        //{
        //    get
        //    {
        //        return Getvalue(Resources.XMLParamSearch);
        //    }
        //}

        //public static void GetDatos()
        //{
        //    var oConexion = new SqlConnection();

        //    oConexion.ConnectionString = GetStringBD;

        //    var oAdapter = new SqlDataAdapter();

        //    oConexion.Open();
        //    var oComando = new SqlCommand();
        //    oComando.Connection = oConexion;
        //    oComando.CommandType = CommandType.StoredProcedure;
        //    oComando.CommandText = GetNameSP;

        //    oAdapter.SelectCommand = oComando;

        //    DataTable table1 = new DataTable();
        //    DataTable table2 = new DataTable();

        //    DataSet dataSet = new DataSet();
        //    oAdapter.Fill(dataSet);
        //    if (dataSet.Tables.Count > 0)
        //        // Modulos = dataSet.Tables[0];
        //        if (dataSet.Tables.Count > 1)
        //            //Usuarios = dataSet.Tables[1];


        //            oConexion.Close();

        //}
        #endregion



    }
}
