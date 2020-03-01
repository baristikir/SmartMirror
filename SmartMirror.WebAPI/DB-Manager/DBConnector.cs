
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Xml;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using SmartMirror.WebAPI.Models;
namespace SmartMirror.WebAPI.DB_Manager
{
    /// <summary>
    /// stelllt Funktionen zur Erstellung von Datenbank Connections und verschiedenen Abfragen bereit
    /// </summary>
    public class DBConnector
    {
        //Benutzername für die Verbindung zur Datenbank
        private string DBuser = "client";
        //Passwort für die Verbindung zur Datenbank
        private string DBauth = "password";
        //Addresse zum Server
        private string serverName = "192.168.178.75:3306";
        //Datenbank Name
        private string dbName = "SmartMirror";
        //Verbindungsdaten
        private string connectionstring;
        public DBConnector() : this("192.168.178.75", "SmartMirror", "client", "password") { 

        }
        public DBConnector(string serverName_,string dbName_,string DBuser_,string DBauth_)
        {
            this.serverName = serverName_;
            this.dbName = dbName_;
            this.DBuser = DBuser_;
            this.DBauth = DBauth_;
            connectionstring = "server=" + serverName + ";user=" + DBuser + ";database=" + dbName + ";port=3306;password=" + DBauth;
        }
        /// <summary>
        /// Fügt einen neues User hinzu.
        /// </summary>
        /// <param name="username">Benutzername des neuen Benutzers</param>
        /// <param name="Email">E-Mail des neuen Benutzers</param>
        /// <returns>ob der neue Benutzer zur Datenbank hinzugefügt werden konnte</returns>
        public string getToken(string username,string API_Name)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Fragt die Id einer gesuchten API in der Datenbank ab
        /// </summary>
        /// <param name="API_Name">Name der Api</param>
        /// <returns>ID der Api aus der Datenbank</returns>
        public int getAPIId(string API_Name)
        {
            throw new NotImplementedException();
        }

        #region users
        /// <summary>
         /// Fügt einen neues User hinzu.
         /// </summary>
         /// <param name="username">Benutzername des neuen Benutzers</param>
         /// <param name="Email">E-Mail des neuen Benutzers</param>
         /// <returns>ob der neue Benutzer zur Datenbank hinzugefügt werden konnte</returns>
        public bool addUser(string username, string Email = "")
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Fragt den Token einer bestimmten API eines bestimmten Benutzers ab
        /// </summary>
        /// <param name="username">Benutzername</param>
        /// <param name="API_Name">API-Name</param>
        /// <returns>token für die Übergebene Kombination</returns>
        /// <summary>
        /// Fragt die Id eines gesuchten Nutzerkontos in der Datenbank ab
        /// </summary>
        /// <param name="username">Benutzernsme</param>
        /// <returns>ID vom Benutzer</returns>
        public IEnumerable<User> getUser(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string sql = "SELECT * FROM Users WHERE Username="+username+";";
                MySqlDataAdapter adapt = new MySqlDataAdapter(sql, connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapt);
                DataSet ds = new DataSet();

                adapt.Fill(ds, "Users");
                List<User> users = new List<User>(); ;
                foreach (DataRow row in ds.Tables["Users"].Rows)
                {
                    users.Add(new User((int)row["UserID"], row["Username"].ToString(), row["Email"].ToString()));
                }
                return users;

            }
            throw new NotImplementedException();
        }
        public IEnumerable<User> getAllUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string sql = "SELECT * FROM Users";
                MySqlDataAdapter adapt = new MySqlDataAdapter(sql, connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapt);
                DataSet ds = new DataSet();

                adapt.Fill(ds, "Users");
                List<User> users = new List<User>(); ;
                foreach (DataRow row in ds.Tables["Users"].Rows)
                {
                    users.Add(new User((int)row["UserID"], row["Username"].ToString(), row["Email"].ToString()));
                }
                return users;

            }
            throw new Exception();
        }
        public User getUser(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string sql = "SELECT * FROM Users WHERE UserID="+id.ToString() + ";";
                MySqlDataAdapter adapt = new MySqlDataAdapter(sql, connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapt);
                DataSet ds = new DataSet();

                adapt.Fill(ds, "Users");
                List<User> users = new List<User>(); ;
                foreach (DataRow row in ds.Tables["Users"].Rows)
                {
                    users.Add(new User((int)row["UserID"], row["Username"].ToString(), row["Email"].ToString()));
                }
                return users[0];

            }
        }
        #endregion

    }
}
