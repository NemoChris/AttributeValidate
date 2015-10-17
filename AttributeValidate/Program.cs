using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    class Program
    {
        static void Main(string[] args)
        {

            // 对数据进行验证
            var user = new User();
            user.UserName = "hpy";
            user.QQ = "01234";
            var res= user.Validate();
            // 正常情况
            user.UserName = "admin";
            var res2 = user.Validate();
        }
    }
}
