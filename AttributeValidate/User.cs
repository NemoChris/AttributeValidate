using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    public class User:BaseModel
    {
        public  const  string CONN = "Photo";
        public const string TABLENAME = "User";
        public const string IDFIELD = "Id";

        [Required("请输入用户名")]
        [Exist(CONN,TABLENAME,"UserName","用户名已存在")]
        public string UserName { get; set; }
        [Exist(CONN,TABLENAME,"Email","邮箱已存在")]
        [Regex(@"^\d{5,10}$","请输入正确的qq号")]
        public string QQ { get; set; }
    }
}
