﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myChatServer.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyChat")]
	public partial class myChatDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdb_message(db_message instance);
    partial void Updatedb_message(db_message instance);
    partial void Deletedb_message(db_message instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public myChatDatabaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyChatConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public myChatDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public myChatDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public myChatDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public myChatDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<db_message> db_messages
		{
			get
			{
				return this.GetTable<db_message>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.db_messages")]
	public partial class db_message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _message_id;
		
		private int _sender;
		
		private int _receiver;
		
		private string _message;
		
		private System.DateTime _date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onmessage_idChanging(int value);
    partial void Onmessage_idChanged();
    partial void OnsenderChanging(int value);
    partial void OnsenderChanged();
    partial void OnreceiverChanging(int value);
    partial void OnreceiverChanged();
    partial void OnmessageChanging(string value);
    partial void OnmessageChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    #endregion
		
		public db_message()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int message_id
		{
			get
			{
				return this._message_id;
			}
			set
			{
				if ((this._message_id != value))
				{
					this.Onmessage_idChanging(value);
					this.SendPropertyChanging();
					this._message_id = value;
					this.SendPropertyChanged("message_id");
					this.Onmessage_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sender", DbType="Int NOT NULL")]
		public int sender
		{
			get
			{
				return this._sender;
			}
			set
			{
				if ((this._sender != value))
				{
					this.OnsenderChanging(value);
					this.SendPropertyChanging();
					this._sender = value;
					this.SendPropertyChanged("sender");
					this.OnsenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_receiver", DbType="Int NOT NULL")]
		public int receiver
		{
			get
			{
				return this._receiver;
			}
			set
			{
				if ((this._receiver != value))
				{
					this.OnreceiverChanging(value);
					this.SendPropertyChanging();
					this._receiver = value;
					this.SendPropertyChanged("receiver");
					this.OnreceiverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this.OnmessageChanging(value);
					this.SendPropertyChanging();
					this._message = value;
					this.SendPropertyChanged("message");
					this.OnmessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_id;
		
		private string _username;
		
		private string _password;
		
		private System.DateTime _usercreated;
		
		private System.DateTime _userlastlogintime;
		
		private bool _deleted;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnusercreatedChanging(System.DateTime value);
    partial void OnusercreatedChanged();
    partial void OnuserlastlogintimeChanging(System.DateTime value);
    partial void OnuserlastlogintimeChanged();
    partial void OndeletedChanging(bool value);
    partial void OndeletedChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usercreated", DbType="DateTime NOT NULL")]
		public System.DateTime usercreated
		{
			get
			{
				return this._usercreated;
			}
			set
			{
				if ((this._usercreated != value))
				{
					this.OnusercreatedChanging(value);
					this.SendPropertyChanging();
					this._usercreated = value;
					this.SendPropertyChanged("usercreated");
					this.OnusercreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userlastlogintime", DbType="DateTime NOT NULL")]
		public System.DateTime userlastlogintime
		{
			get
			{
				return this._userlastlogintime;
			}
			set
			{
				if ((this._userlastlogintime != value))
				{
					this.OnuserlastlogintimeChanging(value);
					this.SendPropertyChanging();
					this._userlastlogintime = value;
					this.SendPropertyChanged("userlastlogintime");
					this.OnuserlastlogintimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deleted", DbType="Bit NOT NULL")]
		public bool deleted
		{
			get
			{
				return this._deleted;
			}
			set
			{
				if ((this._deleted != value))
				{
					this.OndeletedChanging(value);
					this.SendPropertyChanging();
					this._deleted = value;
					this.SendPropertyChanged("deleted");
					this.OndeletedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591