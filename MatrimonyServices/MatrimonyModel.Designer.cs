﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MatrimonyModel", "FK_Token_ToUser", "user", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MatrimonyServices.user), "Token", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MatrimonyServices.Token))]

#endregion

namespace MatrimonyServices
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MatrimonyEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MatrimonyEntities object using the connection string found in the 'MatrimonyEntities' section of the application configuration file.
        /// </summary>
        public MatrimonyEntities() : base("name=MatrimonyEntities", "MatrimonyEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MatrimonyEntities object.
        /// </summary>
        public MatrimonyEntities(string connectionString) : base(connectionString, "MatrimonyEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MatrimonyEntities object.
        /// </summary>
        public MatrimonyEntities(EntityConnection connection) : base(connection, "MatrimonyEntities")
        {
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
        public ObjectSet<user> users
        {
            get
            {
                if ((_users == null))
                {
                    _users = base.CreateObjectSet<user>("users");
                }
                return _users;
            }
        }
        private ObjectSet<user> _users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Token> Tokens
        {
            get
            {
                if ((_Tokens == null))
                {
                    _Tokens = base.CreateObjectSet<Token>("Tokens");
                }
                return _Tokens;
            }
        }
        private ObjectSet<Token> _Tokens;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTousers(user user)
        {
            base.AddObject("users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tokens EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTokens(Token token)
        {
            base.AddObject("Tokens", token);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MatrimonyModel", Name="Token")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Token : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Token object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="tokenn">Initial value of the Tokenn property.</param>
        /// <param name="createDate">Initial value of the CreateDate property.</param>
        public static Token CreateToken(global::System.Int32 id, global::System.String tokenn, global::System.DateTime createDate)
        {
            Token token = new Token();
            token.Id = id;
            token.Tokenn = tokenn;
            token.CreateDate = createDate;
            return token;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Tokenn
        {
            get
            {
                return _Tokenn;
            }
            set
            {
                OnTokennChanging(value);
                ReportPropertyChanging("Tokenn");
                _Tokenn = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Tokenn");
                OnTokennChanged();
            }
        }
        private global::System.String _Tokenn;
        partial void OnTokennChanging(global::System.String value);
        partial void OnTokennChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                OnCreateDateChanging(value);
                ReportPropertyChanging("CreateDate");
                _CreateDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateDate");
                OnCreateDateChanged();
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MatrimonyModel", "FK_Token_ToUser", "user")]
        public user user
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<user>("MatrimonyModel.FK_Token_ToUser", "user").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<user>("MatrimonyModel.FK_Token_ToUser", "user").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<user> userReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<user>("MatrimonyModel.FK_Token_ToUser", "user");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<user>("MatrimonyModel.FK_Token_ToUser", "user", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MatrimonyModel", Name="user")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class user : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new user object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="isactive">Initial value of the isactive property.</param>
        public static user Createuser(global::System.Int64 id, global::System.Boolean isactive)
        {
            user user = new user();
            user.id = id;
            user.isactive = isactive;
            return user;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int64 _id;
        partial void OnidChanging(global::System.Int64 value);
        partial void OnidChanged();
    
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
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean isactive
        {
            get
            {
                return _isactive;
            }
            set
            {
                OnisactiveChanging(value);
                ReportPropertyChanging("isactive");
                _isactive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("isactive");
                OnisactiveChanged();
            }
        }
        private global::System.Boolean _isactive;
        partial void OnisactiveChanging(global::System.Boolean value);
        partial void OnisactiveChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MatrimonyModel", "FK_Token_ToUser", "Token")]
        public EntityCollection<Token> Tokens
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Token>("MatrimonyModel.FK_Token_ToUser", "Token");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Token>("MatrimonyModel.FK_Token_ToUser", "Token", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}