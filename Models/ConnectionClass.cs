using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConstructionCoreApp.Models
{
   
    public class ConnectionClass
    {
        private readonly IConfiguration configurationn;

        public ConnectionClass(IConfiguration config)
        {
            configurationn = config;
        }
        
        public SqlConnection Connt()
        {
            string coc = configurationn.GetConnectionString("DefaultConnection");
            SqlConnection Conn = new SqlConnection(coc);
            if (Conn.State == ConnectionState.Closed) Conn.Open();
            return Conn;
        }

        public SqlCommand SqlCommandnonquery(string query)
        {
            SqlCommand Cmdd = new SqlCommand(query, Connt()) { CommandType = CommandType.Text };
            Cmdd.ExecuteNonQuery();
           // Cmdd.Dispose();
            return Cmdd;
        }
        public SqlCommand SqlCommanddOnly(string query)
        {
            SqlCommand Cmdd = new SqlCommand(query, Connt());
            return Cmdd;
        }
    }



    //form mail
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }

        public string UserName { get; set; }
    }
    public class WelcomeRequest
    {
        public string ToEmail { get; set; }
        public string UserName { get; set; }
    }
}
