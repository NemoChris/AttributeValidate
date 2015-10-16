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
    }
}
