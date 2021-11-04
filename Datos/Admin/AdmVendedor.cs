using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.Models;
using Datos.Server;

namespace Datos.Admin
{
    public static class AdmVendedor
    {
        public static List<Vendedor> Listar()
        {
            string ConsultaSql = "Select Id,Nombre,Apellido,Dni,Comision From dbo.Vendedor";
            SqlCommand command = new SqlCommand(ConsultaSql, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Vendedor> listaVendedor = new List<Vendedor>();
            while (reader.Read())
            {
                listaVendedor.Add(
                    new Vendedor()
                    {
                        Comision = (decimal)reader["Comision"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        DNI=reader["Dni"].ToString(),
                        Id=(int)reader["Id"]
                    }
                    ) ;
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return listaVendedor;
        }
        public static DataTable TraerPorId(int id)
        {
            string ConsultaSql = "Select Id,Nombre,Apellido,Dni,Comision From dbo.Vendedor Where Id=@Id";
            SqlDataAdapter adapter = new SqlDataAdapter(ConsultaSql, AdminDB.ConectarBase());
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Id");
            return ds.Tables["Id"];
        }
        public static int Insertar(Vendedor vendedor)
        {
            string ConsultaSql = "Insert dbo.Vendedor(Nombre,Apellido,Dni,Comision) Values (@Nombre,@Apellido,@Dni,@Comision)";
            SqlCommand command = new SqlCommand(ConsultaSql, AdminDB.ConectarBase());
            //command.Parameters.Add("@Id", SqlDbType.Int).Value = vendedor.Id;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            command.Parameters.Add("@Dni", SqlDbType.Char, 11).Value = vendedor.DNI;
            command.Parameters.Add("@Comision", SqlDbType.Decimal).Value = vendedor.Comision;
            int filasafectadas = command.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasafectadas;
        }
        public static int Eliminar (int id)
        {
            string ConsultaSql= "Delete From dbo.Vendedor Where Id=@Id";
            SqlCommand command = new SqlCommand(ConsultaSql, AdminDB.ConectarBase());
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            int filasafectadas = command.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasafectadas;
        }
        public static int Modificar(Vendedor vendedor)
        {
            string ConsultaSql = "update dbo.Vendedor Set Nombre=@Nombre,Apellido=@Apellido,DNI=@DNI,Comision=@Comision Where Id=@Id";
            SqlCommand command = new SqlCommand(ConsultaSql, AdminDB.ConectarBase());         
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            command.Parameters.Add("@Dni", SqlDbType.Char, 11).Value = vendedor.DNI;
            command.Parameters.Add("@Comision", SqlDbType.Decimal).Value = vendedor.Comision;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = vendedor.Id;
            int filasafectadas = command.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasafectadas;
        }
        public static List<Vendedor> TraerPorComision(decimal comision)
        {
            string ConsultaSql = "Select Id,Nombre,Apellido,Dni,Comision From dbo.Vendedor Where Comision=@Comision";
            SqlCommand command = new SqlCommand(ConsultaSql, AdminDB.ConectarBase());
            command.Parameters.Add("@Comision", SqlDbType.Decimal).Value = comision;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Vendedor> traerporcomision = new List<Vendedor>();
            while (reader.Read())
            {
                traerporcomision.Add(
                    new Vendedor
                    {
                        Comision = (decimal)reader["Comision"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        DNI = reader["Dni"].ToString(),
                        Id = (int)reader["Id"]
                    }
                    );
            }
            AdminDB.ConectarBase().Close();
            reader.Close();
            return traerporcomision;
        }
            
    }
}
