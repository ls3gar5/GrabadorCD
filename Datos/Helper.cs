using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                try
                {
                    repo.GetUsuario();

                    _modulos = repo.moduloDto;
                    _usuarios = repo.usuarioDto;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            }
        }

        public static UsuarioDTO SearchUsuario(int nroContrato)
        {
            using (var repo = new GrabadorRepository())
            {
                return repo.SearchUsuario(nroContrato);
            }
        }

        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "El directorio no existe: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public static void DirectoryDelete(string sourceDirName)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                return;
            }

            Directory.Delete(sourceDirName, true);
        }

        private static string GetXMLPath()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "config.xml");
            if (!File.Exists(path))
            {
                throw new Exception(ResourcesDatos.ConfigXMLNoExiste);
            }
            return path;
        }

        private static string Getvalue(string param)
        {
            var pathXml = GetXMLPath();

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXml);

            var lista = xmlDoc.DocumentElement.GetElementsByTagName(param);

            if (lista.Count <= 0)
            {
                return "";
            }

            return lista.Item(0).InnerText;
        }

        public static string GetStringBD
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamStringConexion);
            }
        }

        public static string GetNameSP
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamSP);
            }
        }

        public static string GetNameSPSearch
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamSearch);
            }
        }

        public static string GetPATHEST
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamPATHEST);
            }
        }

        public static string GetPATHAGRO
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamPATHAGRO);
            }
        }

        public static string GetPATHGEST
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamPATHGEST);
            }
        }

        public static string GetPATHESTLOCAL
        {
            get
            {
                return Getvalue(ResourcesDatos.XMLParamPATHESTLOCAL);
            }
        }

        #region SQLCommand
        //public static DataTable dtModulos { get; set; }
        //public static DataTable dtUsuarios { get; set; }

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
