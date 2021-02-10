using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CriteriaFunction.Module.BusinessObjects
{
    [DefaultClassOptions]
    [RuleCriteria("test", DefaultContexts.Save, "UserName = GetCurrentUserName()")]
    public class DomainObject1 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DomainObject1(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            UserName = SecuritySystem.CurrentUserName;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string _propertyOne;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PropertyOne
        {
            get => _propertyOne;
            set => SetPropertyValue(nameof(PropertyOne), ref _propertyOne, value);
        }

        string _userName;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string UserName
        {
            get => _userName;
            set => SetPropertyValue(nameof(UserName), ref _userName, value);
        }

    }
}