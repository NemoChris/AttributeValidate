using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate.BLL
{
    public class UserBll
    {
        public static bool IsExixtUser(string userName)
        {
            // 模拟数据库数据
            var userNameList=new List<string>(){"admin","hpy"};
            return userNameList.Exists(u => u == userName);     
        }
    }
}
