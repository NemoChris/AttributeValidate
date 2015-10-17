using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    public class User:BaseModel
    {
        [Required("请输入用户名")]
        public string UserName { get; set; }
        [Regex(@"^\d{5,10}$","请输入正确的qq号")]
        public string QQ { get; set; }
    }
}
