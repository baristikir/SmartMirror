using SmartMirror.WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartMirror.WebAPI
{
    public class DataSeed
    {
        private readonly ApiContext _ctx;

        public DataSeed(ApiContext ctx)
        {
            _ctx = ctx;
        }

        public void SeedData(int nUsers, int nWidgets)
        {
            if (!_ctx.Users.Any())
            {
                SeedUsers(nUsers);
            }
            if (!_ctx.Widgets.Any())
            {
                SeedWidgets(nWidgets);
            }

            _ctx.SaveChanges();
        }

        private void SeedUsers(int n )
        {
            List<User> users = BuildUserList(n);

            foreach (var user in users)
            {
                _ctx.Users.Add(user);
            }
        }

        private void SeedWidgets (int n )
        {
            List<Widget> widgets = BuildWidgetList(n);

            foreach (var widget in widgets)
            {
                _ctx.Widgets.Add(widget);
            }
        }

        private List<User> BuildUserList(int nUsers)
        {
            var users = new List<User>();
            var names = new List<string>();

            for (var i = 0; i < nUsers; i++)
            {
                var name = Helpers.MakeUniqueUserName(names);
                names.Add(name);

                users.Add(new User
                {
                    Id = i,
                    Name = name,
                    Email = Helpers.MakeUserEmail(name)
                });
            }

            return users;
        }

        private List<Widget> BuildWidgetList (int nWidgets)
        {
            var widgets = new List<Widget>();

            for (var i = 0; i < nWidgets; i++)
            {
                var _apiToken = Helpers.GetApiToken(widgetName);

                widgets.Add(new Widget
                {
                    WidgetId = i,
                    User = Helpers.GetRandomUser(),
                    ApiToken = Helpers.GetRandomApiToken(),
                    WidgetName = _apiToken
                });
            }
        }
    }
}
