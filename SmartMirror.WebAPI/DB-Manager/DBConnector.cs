
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Xml;
using System.Diagnostics;

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
        private string serverName = "127.0.0.1";
        //Datenbank Name
        private string dbName = "SmartMirror";
        //Verbindungsdaten
        private string connectionstring;
        public DBConnector() : this("127.0.0.1", "SmartMirror", "client", "password") { 

        }
        public DBConnector(string serverName_,string dbName_,string DBuser_,string DBauth_)
        {
            this.serverName = serverName_;
            this.dbName = dbName_;
            this.DBuser = DBuser_;
            this.DBauth = DBauth_;
            connectionstring = "Data Source=" + serverName + ";Initial Catalog=" + dbName + ";User=" + DBuser + ";Password=" + DBauth;
        }
        /// <summary>
        /// Fügt einen neues User hinzu.
        /// </summary>
        /// <param name="username">Benutzername des neuen Benutzers</param>
        /// <param name="Email">E-Mail des neuen Benutzers</param>
        /// <returns>ob der neue Benutzer zur Datenbank hinzugefügt werden konnte</returns>
        public bool addUser(string username,string Email="")
        {
            //noch nicht getestet
            int affectedRows=0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmdtext = "INSERT INTO Users (Username,Email) values(" + username + "," + Email + ");";
                SqlCommand command = new SqlCommand(cmdtext,connection);
                command.Connection.Open();
                
                try
                {
                    command.Connection.Open();
                    affectedRows=command.ExecuteNonQuery();
                }catch(Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
            return affectedRows==1?true:false;
        }
        /// <summary>
        /// Fragt den Token einer bestimmten API eines bestimmten Benutzers ab
        /// </summary>
        /// <param name="username">Benutzername</param>
        /// <param name="API_Name">API-Name</param>
        /// <returns>token für die Übergebene Kombination</returns>
        public string getToken(string username,string API_Name)
        {
            int userid = getUserId(username);
            int API_ID = getAPIId(API_Name);
            //noch nicht getestet
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmdtext = "SELECT token FROM Token WHERE UserID=" + userid + " AND API_ID=" + API_ID + ";";
                SqlCommand command = new SqlCommand(cmdtext, connection);
                command.Connection.Open();

                try
                {
                    command.Connection.Open();
                    XmlReader reader = command.ExecuteXmlReader();
                    //hier fehlt noch der Umgang mit der Antwort
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    throw e;
                }
            }
            throw new NotImplementedException();
        }
        /// <summary>
        /// Fragt die Id einer gesuchten API in der Datenbank ab
        /// </summary>
        /// <param name="API_Name">Name der Api</param>
        /// <returns>ID der Api aus der Datenbank</returns>
        public int getAPIId(string API_Name)
        {
            //noch nicht getestet
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmdtext = "SELECT ID FROM APIs WHERE Name=" + API_Name + ";";
                SqlCommand command = new SqlCommand(cmdtext, connection);
                command.Connection.Open();

                try
                {
                    command.Connection.Open();
                    XmlReader reader = command.ExecuteXmlReader();
                    //hier fehlt noch der Umgang mit der Antwort
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    throw e;
                }
            }
            throw new NotImplementedException();
        }
        /// <summary>
        /// Fragt die Id eines gesuchten Nutzerkontos in der Datenbank ab
        /// </summary>
        /// <param name="username">Benutzernsme</param>
        /// <returns>ID vom Benutzer</returns>
        public int getUserId(string username)
        {
            //noch nicht getestet
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string cmdtext = "SELECT UserID FROM Users WHERE Username=" + username + ";";
                SqlCommand command = new SqlCommand(cmdtext, connection);
                command.Connection.Open();

                try
                {
                    command.Connection.Open();
                    XmlReader reader = command.ExecuteXmlReader();
                    //hier fehlt noch der Umgang mit der Antwort
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    throw e;
                }
            }
            throw new NotImplementedException();
            return 123;
        }  
    }
}
