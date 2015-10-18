using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeValidate
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExistAttribute:ValidateAttibute
    {
        /*public Func<object,bool> IsExistDataCallBack { get; set; }
        public ExistAttribute(Func<object,bool> callBack,string errorMessage) : base(errorMessage)
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
            return this.IsExistDataCallBack(this.InputValue);
        }*/

        private string _FiledName=null;
        private string Conn { get; set; }
        private string TableName { get; set; }
        public ExistAttribute(string conn,string tableName,string filedName,string errorMessage) : base(errorMessage)
        {
            this._FiledName = filedName;
        }

        public override bool Validate()
        {
            return new BLL.CommonBll().IsExixt(this.Conn,this.TableName,this._FiledName, this.InputValue.ToString());
        }
    }
}
