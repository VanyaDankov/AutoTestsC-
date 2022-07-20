using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverProekt.service
{
    public class UserCreator
    {
        public static string USER_NAME = "yanusya.tori";
        public static string USER_PASSWORD = "yroRu^pT4LS2";
        public static model.User getFullUser() => new model.User(USER_NAME, USER_PASSWORD);

        public static model.User withEmptyUserName() => new model.User("", USER_PASSWORD);

        public static model.User withEmptyUserPassword() => new model.User(USER_NAME, "");

    }
}
