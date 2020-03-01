using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using SmartMirror.WebAPI_Client;
namespace WebApi_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            testGetUser();
            Console.ReadKey();
        }
        public static void testGetUser()
        {
            Client client = new Client("http://raspberrypi:3306/");
            User user = client.getUser(1);
            Console.WriteLine(user.ToString());
        }
        public static void testGetUsers()
        {

        }
    }
}
