using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : ValidateAttibute
    {
        public RequiredAttribute(string errorMessage) : base(errorMessage)
        {

        }

        public override bool Validate()
        {
            return !string.IsNullOrEmpty(this.InputValue.ToString());
        }
    }
}
