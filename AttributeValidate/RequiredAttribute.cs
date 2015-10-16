using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredAttribute : Attribute
    {
        /// <summary>
        /// 验证失败返回的错误信息
        /// </summary>
        public string ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// 输入值
        /// </summary>
        public object InputValue
        {
            get;
            set;
        }

        /// <summary>
        /// 验证规则
        /// </summary>
        /// <param name="errorMessage">验证失败返回的错误信息</param>
        public RequiredAttribute(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// 接口参数为空或空字符串都返回false
        /// </summary>
        /// <returns></returns>
        public  bool Validate()
        {
            return !string.IsNullOrEmpty(InputValue.ToString());
        }

    }
}
