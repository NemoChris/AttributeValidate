using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    public class User
    {
        [Required("请输入用户名")]
        public string UserName { get; set; }

        public string Validate()
        {
            // 反射取当前对象的所有属性
            System.Reflection.PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var pInfo in properties)
            {
                // 取属性中的特性
                if (pInfo.IsDefined(typeof(RequiredAttribute),false))
                {
                    var customAttributes =
                        pInfo.GetCustomAttributes(typeof (RequiredAttribute), false) as RequiredAttribute[];
                    // 根据特性进行参数验证
                    foreach (var attribute in customAttributes)
                    {
                        // 初始化特性，并进行验证。
                        var validateVal = pInfo.GetValue(this, null);
                        attribute.InputValue = validateVal;
                        if (!attribute.Validate())
                        {
                            return "验证失败！消息：" + attribute.ErrorMessage;
                        }
                    }
                }   
            }
            // 验证成功
            return "验证成功!";
        }
    }
}
