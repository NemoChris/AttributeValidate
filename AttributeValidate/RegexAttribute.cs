using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AttributeValidate
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RegexAttribute:ValidateAttibute
    {
        public string RegexStr { get; set; }
        public RegexAttribute(string regexStr,string errorMessage) : base(errorMessage)
        {
            this.ErrorType=ValidateCode.RegexFailed;
            this.RegexStr = regexStr;
        }

        public override bool Validate()
        {
            return Regex.IsMatch(this.InputValue.ToString(), this.RegexStr);
        }
    }
}
