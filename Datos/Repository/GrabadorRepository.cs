using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class GrabadorRepository : DbContext
    {
        //public GrabadorRepository()
        //    : base("Name=HolistorCloudDB")
        //{

        //}
        public GrabadorRepository()
            :base("Name=HERP_DEVEntities")
        {
            Database.CommandTimeout = int.MaxValue;
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        protected DbSet<UsuarioDTO> UsuarioDTO { get; set; }
        protected DbSet<ModuloDTO> ModuloDTO { get; set; }

        public List<UsuarioDTO> usuarioDto { get; set; }
        public List<ModuloDTO> moduloDto { get; set; }
        


        public List<UsuarioDTO> SearchUsuario(int nroContrato)
        {
            var parameterList = new List<SqlParameter>();

            var isConnManuallyOpen = false;

            if (Database.Connection.State == ConnectionState.Closed || Database.Connection.State == ConnectionState.Broken)
            {
                isConnManuallyOpen = true;
                Database.Connection.Open();
            }

            parameterList.Add(new SqlParameter("pNumeroContrato", SqlDbType.Int) { IsNullable = false, Value = (object)nroContrato });

            var spExecute = "[dbo].[sp_Suite2HBMSearch]" + String.Join(",", parameterList.Select(s => String.Format("@{0}", s.ParameterName)));

            var result = this.Database.SqlQuery<UsuarioDTO>(spExecute, parameterList.ToArray()).ToList();

            if (isConnManuallyOpen && Database.Connection.State != ConnectionState.Closed)
            {
                Database.Connection.Close();
            }

            return result;
        }

        public void GetUsuario()
        {
            
            var isConnManuallyOpen = false;

            if (Database.Connection.State == ConnectionState.Closed || Database.Connection.State == ConnectionState.Broken)
            {
                isConnManuallyOpen = true;
                Database.Connection.Open();
            }

            var cmd = this.Database.Connection.CreateCommand();
            cmd.CommandTimeout = int.MaxValue;
            cmd.CommandText = "[dbo].[sp_Suite2HBM]"; 

            var reader = cmd.ExecuteReader();

            moduloDto = ((IObjectContextAdapter)this)
                .ObjectContext
                .Translate<ModuloDTO>(reader).ToList();

            reader.NextResult();

            usuarioDto = ((IObjectContextAdapter)this)
                .ObjectContext
                .Translate<UsuarioDTO>(reader).ToList();

            if (!reader.IsClosed)
            {
                reader.Close();
            }

            if (isConnManuallyOpen && Database.Connection.State != ConnectionState.Closed)
            {
                Database.Connection.Close();
            }

            return;
        }

    }
}
