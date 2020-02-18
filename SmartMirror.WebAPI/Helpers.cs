using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartMirror.WebAPI.Models;

namespace SmartMirror.WebAPI
{
    public class Helpers
    {
        private static Random _rand = new Random();

        private static readonly List<string> bizPrefix = new List<string>()
        {
            "ABC",
            "XYZ",
            "MainSt",
            "Sales",
            "Ready",
            "Magic",
            "Family"
        };
        private static readonly List<string> bizSuffix = new List<string>()
        {
            "Books",
            "Goods",
            "Foods",
            "Co",
            "Logistic",
            "Bakery"
        };

        private static string GetRandom(IList<string> items)
        {
            return items[_rand.Next(items.Count)];
        }

        internal static string MakeUniqueUserName(List<string> names)
        {
            var prefix = GetRandom(bizPrefix);
            var suffix = GetRandom(bizSuffix);

            var bizName = prefix + suffix;

            if (names.Contains(bizName))
            {
                MakeUniqueUserName(names);
            }

            return bizName;
        }
        
        internal static string MakeUserEmail(string userName)
        {
            return $"contact@{userName.ToLower()}.com";
        }
        #region test methods
        public static User GetRandomUser()
        {
            return new User(_rand.Next(), "Testuser:"+_rand.Next().ToString(), "testmail:"+_rand.Next().ToString());
        }
        public static User GetRandomApiToken()
        {
            return GetRandomUser();
        }
        #endregion
    }
}
