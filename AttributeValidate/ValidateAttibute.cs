using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{    
    public abstract class ValidateAttibute:Attribute
    {
        // 当前验证的错误类型
        public static ValidateCode ValErrorType
        {
            get;
            private set;
        }
        // 静态初始化块
        static ValidateAttibute()
        {
            ValErrorType = ValidateCode.RegexFailed;
        }
        
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
        public ValidateAttibute(string errorMessage)
        {            
            this.ErrorMessage = errorMessage;
        }


        public abstract bool Validate();
    }
}
