using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    public class User:BaseModel
    {
        public static readonly string Conn = "Photo";
        public static readonly string TableName = "User";
        public static readonly string IdField = "Id";

        [Required("请输入用户名")]
        [Exist("UserName","用户名已存在")]
        public string UserName { get; set; }
        [Exist("Email","邮箱已存在")]
        [Regex(@"^\d{5,10}$","请输入正确的qq号")]
        public string QQ { get; set; }
    }
}
