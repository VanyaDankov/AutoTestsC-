using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.service
{
    public class UserCreator
    {
        public static string USER_NAME = "yanusya.tori";
        public static string USER_PASSWORD = "yroRu^pT4LS2";
        public static model.User getFullUser() => new(USER_NAME, USER_PASSWORD);

        public static model.User withEmptyUserName() => new("", USER_PASSWORD);

        public static model.User withEmptyUserPassword() => new(USER_NAME, "");

    }
}
