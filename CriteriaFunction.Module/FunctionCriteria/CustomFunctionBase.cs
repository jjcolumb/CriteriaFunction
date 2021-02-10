using System;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;

namespace FunctionCriteria.Module.CriteriaFunction
{
    public class CustomFunctionBase : ICustomFunctionOperator
    {
        public virtual string Name { get { throw new NotImplementedException(); } }

        public virtual object Evaluate(params object[] operands)
        {
            throw new NotImplementedException();
        }

        public virtual Type ResultType(params Type[] operands)
        {
            throw new NotImplementedException();
        }
    }


    public class GetCurrentUserNameFunction : CustomFunctionBase
    {
        public override string Name { get { return "GetCurrentUserName"; } }

        public override object Evaluate(params object[] operands)
        {
            var user = SecuritySystem.CurrentUser as PermissionPolicyUser;
            if (user != null)
            {
                return user.UserName;
            }
            else
            {
                return null;
            }


        }

        public override Type ResultType(params Type[] operands)
        {
            return typeof(string);
        }
    }
}
