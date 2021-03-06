﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Sample.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DB_JoshuaEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DB_JoshuaEntities object using the connection string found in the 'DB_JoshuaEntities' section of the application configuration file.
        /// </summary>
        public DB_JoshuaEntities() : base("name=DB_JoshuaEntities", "DB_JoshuaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DB_JoshuaEntities object.
        /// </summary>
        public DB_JoshuaEntities(string connectionString) : base(connectionString, "DB_JoshuaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DB_JoshuaEntities object.
        /// </summary>
        public DB_JoshuaEntities(EntityConnection connection) : base(connection, "DB_JoshuaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<userinfo> userinfoes
        {
            get
            {
                if ((_userinfoes == null))
                {
                    _userinfoes = base.CreateObjectSet<userinfo>("userinfoes");
                }
                return _userinfoes;
            }
        }
        private ObjectSet<userinfo> _userinfoes;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the userinfoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTouserinfoes(userinfo userinfo)
        {
            base.AddObject("userinfoes", userinfo);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB_JoshuaModel", Name="userinfo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class userinfo : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new userinfo object.
        /// </summary>
        /// <param name="user_id">Initial value of the user_id property.</param>
        public static userinfo Createuserinfo(global::System.Int32 user_id)
        {
            userinfo userinfo = new userinfo();
            userinfo.user_id = user_id;
            return userinfo;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                if (_user_id != value)
                {
                    Onuser_idChanging(value);
                    ReportPropertyChanging("user_id");
                    _user_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("user_id");
                    Onuser_idChanged();
                }
            }
        }
        private global::System.Int32 _user_id;
        partial void Onuser_idChanging(global::System.Int32 value);
        partial void Onuser_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String emailid
        {
            get
            {
                return _emailid;
            }
            set
            {
                OnemailidChanging(value);
                ReportPropertyChanging("emailid");
                _emailid = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("emailid");
                OnemailidChanged();
            }
        }
        private global::System.String _emailid;
        partial void OnemailidChanging(global::System.String value);
        partial void OnemailidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String phoneno
        {
            get
            {
                return _phoneno;
            }
            set
            {
                OnphonenoChanging(value);
                ReportPropertyChanging("phoneno");
                _phoneno = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("phoneno");
                OnphonenoChanged();
            }
        }
        private global::System.String _phoneno;
        partial void OnphonenoChanging(global::System.String value);
        partial void OnphonenoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String username
        {
            get
            {
                return _username;
            }
            set
            {
                OnusernameChanging(value);
                ReportPropertyChanging("username");
                _username = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("username");
                OnusernameChanged();
            }
        }
        private global::System.String _username;
        partial void OnusernameChanging(global::System.String value);
        partial void OnusernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String password
        {
            get
            {
                return _password;
            }
            set
            {
                OnpasswordChanging(value);
                ReportPropertyChanging("password");
                _password = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("password");
                OnpasswordChanged();
            }
        }
        private global::System.String _password;
        partial void OnpasswordChanging(global::System.String value);
        partial void OnpasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> status
        {
            get
            {
                return _status;
            }
            set
            {
                OnstatusChanging(value);
                ReportPropertyChanging("status");
                _status = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("status");
                OnstatusChanged();
            }
        }
        private Nullable<global::System.Int16> _status;
        partial void OnstatusChanging(Nullable<global::System.Int16> value);
        partial void OnstatusChanged();

        #endregion
    
    }

    #endregion
    
}
