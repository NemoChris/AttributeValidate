using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    public class ValidateResult
    {
        public bool IsSuc { get; set; }
        public string ResultMessage { get; set; }
        public ValidateCode Code { get; set; }
    }

    public  enum  ValidateCode
    {
        /// <summary>
        /// Require特性验证失败
        /// </summary>
        RequireFailed=101,
        /// <summary>
        /// Regex特性验证失败
        /// </summary>
        RegexFailed=102,
        /// <summary>
        /// Exist特性验证失败
        /// </summary>
        ExistFailed=102,
        /// <summary>
        /// 验证成功
        /// </summary>
        OK=200
    }
}
