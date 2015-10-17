using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExistAttibute:ValidateAttibute
    {
        public Func<bool> IsExistDataCallBack { get; set; }
        public ExistAttibute(Func<bool> callBack,string errorMessage) : base(errorMessage)
        {
            this.IsExistDataCallBack = callBack;
            this.ErrorType=ValidateCode.ExistFailed;
        }

        public override bool Validate()
        {
            if (this.IsExistDataCallBack==null)
            {
                throw new NullReferenceException("验证方法不能为空。");
            }
            return this.IsExistDataCallBack();
        }
    }
}
