using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    public abstract class BaseModel
    {
        public virtual ValidateResult Validate()
        {
            var result = new ValidateResult(){Code = ValidateCode.OK, IsSuc = true, ResultMessage = "验证成功"};

            // 反射取当前对象的所有属性
            System.Reflection.PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var pInfo in properties)
            {
                // 取属性中的特性
                if (pInfo.IsDefined(typeof(ValidateAttibute),true))
                {
                    var customAttributes =
                        pInfo.GetCustomAttributes(typeof(ValidateAttibute), true) as ValidateAttibute[];
                    // 根据特性进行参数验证
                    foreach (var attribute in customAttributes)
                    {
                        // 初始化特性，并进行验证。
                        var validateVal = pInfo.GetValue(this, null);
                        attribute.InputValue = validateVal;
                        if (!attribute.Validate())
                        {
                            result.ResultMessage="验证失败！消息：" + attribute.ErrorMessage;
                            result.IsSuc = false;
                            result.Code = attribute.ErrorType;
                            return result;
                        }
                    }
                }
            }
            // 验证成功
            return result;
        }
    }
}
