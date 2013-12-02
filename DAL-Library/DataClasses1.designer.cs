﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_Library
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbCSharp")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertNewsImage(NewsImage instance);
    partial void UpdateNewsImage(NewsImage instance);
    partial void DeleteNewsImage(NewsImage instance);
    partial void InsertRight(Right instance);
    partial void UpdateRight(Right instance);
    partial void DeleteRight(Right instance);
    partial void InsertType(Type instance);
    partial void UpdateType(Type instance);
    partial void DeleteType(Type instance);
    partial void InsertArticle(Article instance);
    partial void UpdateArticle(Article instance);
    partial void DeleteArticle(Article instance);
    partial void InsertNew(New instance);
    partial void UpdateNew(New instance);
    partial void DeleteNew(New instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DAL_Library.Properties.Settings.Default.dbCSharpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<NewsImage> NewsImages
		{
			get
			{
				return this.GetTable<NewsImage>();
			}
		}
		
		public System.Data.Linq.Table<Right> Rights
		{
			get
			{
				return this.GetTable<Right>();
			}
		}
		
		public System.Data.Linq.Table<Type> Types
		{
			get
			{
				return this.GetTable<Type>();
			}
		}
		
		public System.Data.Linq.Table<Article> Articles
		{
			get
			{
				return this.GetTable<Article>();
			}
		}
		
		public System.Data.Linq.Table<New> News
		{
			get
			{
				return this.GetTable<New>();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Images")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Data.Linq.Binary _Image1;
		
		private string _Description;
		
		private string _Name;
		
		private EntitySet<NewsImage> _NewsImages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnImage1Changing(System.Data.Linq.Binary value);
    partial void OnImage1Changed();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Image()
		{
			this._NewsImages = new EntitySet<NewsImage>(new Action<NewsImage>(this.attach_NewsImages), new Action<NewsImage>(this.detach_NewsImages));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Image", Storage="_Image1", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image1
		{
			get
			{
				return this._Image1;
			}
			set
			{
				if ((this._Image1 != value))
				{
					this.OnImage1Changing(value);
					this.SendPropertyChanging();
					this._Image1 = value;
					this.SendPropertyChanged("Image1");
					this.OnImage1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(10)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Image_NewsImage", Storage="_NewsImages", ThisKey="Id", OtherKey="Image")]
		public EntitySet<NewsImage> NewsImages
		{
			get
			{
				return this._NewsImages;
			}
			set
			{
				this._NewsImages.Assign(value);
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
		
		private void attach_NewsImages(NewsImage entity)
		{
			this.SendPropertyChanging();
			entity.Image1 = this;
		}
		
		private void detach_NewsImages(NewsImage entity)
		{
			this.SendPropertyChanging();
			entity.Image1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NewsImages")]
	public partial class NewsImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _News;
		
		private int _Image;
		
		private EntityRef<Image> _Image1;
		
		private EntityRef<New> _New;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNewsChanging(int value);
    partial void OnNewsChanged();
    partial void OnImageChanging(int value);
    partial void OnImageChanged();
    #endregion
		
		public NewsImage()
		{
			this._Image1 = default(EntityRef<Image>);
			this._New = default(EntityRef<New>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_News", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int News
		{
			get
			{
				return this._News;
			}
			set
			{
				if ((this._News != value))
				{
					if (this._New.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNewsChanging(value);
					this.SendPropertyChanging();
					this._News = value;
					this.SendPropertyChanged("News");
					this.OnNewsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					if (this._Image1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Image_NewsImage", Storage="_Image1", ThisKey="Image", OtherKey="Id", IsForeignKey=true)]
		public Image Image1
		{
			get
			{
				return this._Image1.Entity;
			}
			set
			{
				Image previousValue = this._Image1.Entity;
				if (((previousValue != value) 
							|| (this._Image1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Image1.Entity = null;
						previousValue.NewsImages.Remove(this);
					}
					this._Image1.Entity = value;
					if ((value != null))
					{
						value.NewsImages.Add(this);
						this._Image = value.Id;
					}
					else
					{
						this._Image = default(int);
					}
					this.SendPropertyChanged("Image1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="New_NewsImage", Storage="_New", ThisKey="News", OtherKey="Id", IsForeignKey=true)]
		public New New
		{
			get
			{
				return this._New.Entity;
			}
			set
			{
				New previousValue = this._New.Entity;
				if (((previousValue != value) 
							|| (this._New.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._New.Entity = null;
						previousValue.NewsImages.Remove(this);
					}
					this._New.Entity = value;
					if ((value != null))
					{
						value.NewsImages.Add(this);
						this._News = value.Id;
					}
					else
					{
						this._News = default(int);
					}
					this.SendPropertyChanged("New");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rights")]
	public partial class Right : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Right()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Right_User", Storage="_Users", ThisKey="Id", OtherKey="Right")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Right1 = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Right1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Types")]
	public partial class Type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type1;
		
		private EntitySet<Article> _Articles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnType1Changing(string value);
    partial void OnType1Changed();
    #endregion
		
		public Type()
		{
			this._Articles = new EntitySet<Article>(new Action<Article>(this.attach_Articles), new Action<Article>(this.detach_Articles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Type", Storage="_Type1", DbType="VarChar(50)")]
		public string Type1
		{
			get
			{
				return this._Type1;
			}
			set
			{
				if ((this._Type1 != value))
				{
					this.OnType1Changing(value);
					this.SendPropertyChanging();
					this._Type1 = value;
					this.SendPropertyChanged("Type1");
					this.OnType1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Type_Article", Storage="_Articles", ThisKey="Id", OtherKey="RefType")]
		public EntitySet<Article> Articles
		{
			get
			{
				return this._Articles;
			}
			set
			{
				this._Articles.Assign(value);
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
		
		private void attach_Articles(Article entity)
		{
			this.SendPropertyChanging();
			entity.Type = this;
		}
		
		private void detach_Articles(Article entity)
		{
			this.SendPropertyChanging();
			entity.Type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Articles")]
	public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _SubTitle;
		
		private string _Text;
		
		private System.Nullable<System.DateTime> _DepositDate;
		
		private string _Overview;
		
		private System.Nullable<int> _RefType;
		
		private System.Nullable<int> _Author;
		
		private EntityRef<Type> _Type;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSubTitleChanging(string value);
    partial void OnSubTitleChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnDepositDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDepositDateChanged();
    partial void OnOverviewChanging(string value);
    partial void OnOverviewChanged();
    partial void OnRefTypeChanging(System.Nullable<int> value);
    partial void OnRefTypeChanged();
    partial void OnAuthorChanging(System.Nullable<int> value);
    partial void OnAuthorChanged();
    #endregion
		
		public Article()
		{
			this._Type = default(EntityRef<Type>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubTitle", DbType="VarChar(50)")]
		public string SubTitle
		{
			get
			{
				return this._SubTitle;
			}
			set
			{
				if ((this._SubTitle != value))
				{
					this.OnSubTitleChanging(value);
					this.SendPropertyChanging();
					this._SubTitle = value;
					this.SendPropertyChanged("SubTitle");
					this.OnSubTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(MAX)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepositDate", DbType="Date")]
		public System.Nullable<System.DateTime> DepositDate
		{
			get
			{
				return this._DepositDate;
			}
			set
			{
				if ((this._DepositDate != value))
				{
					this.OnDepositDateChanging(value);
					this.SendPropertyChanging();
					this._DepositDate = value;
					this.SendPropertyChanged("DepositDate");
					this.OnDepositDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Overview", DbType="VarChar(MAX)")]
		public string Overview
		{
			get
			{
				return this._Overview;
			}
			set
			{
				if ((this._Overview != value))
				{
					this.OnOverviewChanging(value);
					this.SendPropertyChanging();
					this._Overview = value;
					this.SendPropertyChanged("Overview");
					this.OnOverviewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RefType", DbType="Int")]
		public System.Nullable<int> RefType
		{
			get
			{
				return this._RefType;
			}
			set
			{
				if ((this._RefType != value))
				{
					if (this._Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRefTypeChanging(value);
					this.SendPropertyChanging();
					this._RefType = value;
					this.SendPropertyChanged("RefType");
					this.OnRefTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="Int")]
		public System.Nullable<int> Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Type_Article", Storage="_Type", ThisKey="RefType", OtherKey="Id", IsForeignKey=true)]
		public Type Type
		{
			get
			{
				return this._Type.Entity;
			}
			set
			{
				Type previousValue = this._Type.Entity;
				if (((previousValue != value) 
							|| (this._Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Type.Entity = null;
						previousValue.Articles.Remove(this);
					}
					this._Type.Entity = value;
					if ((value != null))
					{
						value.Articles.Add(this);
						this._RefType = value.Id;
					}
					else
					{
						this._RefType = default(Nullable<int>);
					}
					this.SendPropertyChanged("Type");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Article", Storage="_User", ThisKey="Author", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Articles.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Articles.Add(this);
						this._Author = value.Id;
					}
					else
					{
						this._Author = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.News")]
	public partial class New : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _SubTitle;
		
		private string _Text;
		
		private System.Nullable<int> _RefImage;
		
		private System.Nullable<System.DateTime> _DepositDate;
		
		private System.Nullable<int> _Author;
		
		private EntitySet<NewsImage> _NewsImages;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSubTitleChanging(string value);
    partial void OnSubTitleChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnRefImageChanging(System.Nullable<int> value);
    partial void OnRefImageChanged();
    partial void OnDepositDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDepositDateChanged();
    partial void OnAuthorChanging(System.Nullable<int> value);
    partial void OnAuthorChanged();
    #endregion
		
		public New()
		{
			this._NewsImages = new EntitySet<NewsImage>(new Action<NewsImage>(this.attach_NewsImages), new Action<NewsImage>(this.detach_NewsImages));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubTitle", DbType="VarChar(50)")]
		public string SubTitle
		{
			get
			{
				return this._SubTitle;
			}
			set
			{
				if ((this._SubTitle != value))
				{
					this.OnSubTitleChanging(value);
					this.SendPropertyChanging();
					this._SubTitle = value;
					this.SendPropertyChanged("SubTitle");
					this.OnSubTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(MAX)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RefImage", DbType="Int")]
		public System.Nullable<int> RefImage
		{
			get
			{
				return this._RefImage;
			}
			set
			{
				if ((this._RefImage != value))
				{
					this.OnRefImageChanging(value);
					this.SendPropertyChanging();
					this._RefImage = value;
					this.SendPropertyChanged("RefImage");
					this.OnRefImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepositDate", DbType="Date")]
		public System.Nullable<System.DateTime> DepositDate
		{
			get
			{
				return this._DepositDate;
			}
			set
			{
				if ((this._DepositDate != value))
				{
					this.OnDepositDateChanging(value);
					this.SendPropertyChanging();
					this._DepositDate = value;
					this.SendPropertyChanged("DepositDate");
					this.OnDepositDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="Int")]
		public System.Nullable<int> Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="New_NewsImage", Storage="_NewsImages", ThisKey="Id", OtherKey="News")]
		public EntitySet<NewsImage> NewsImages
		{
			get
			{
				return this._NewsImages;
			}
			set
			{
				this._NewsImages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_New", Storage="_User", ThisKey="Author", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.News.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.News.Add(this);
						this._Author = value.Id;
					}
					else
					{
						this._Author = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_NewsImages(NewsImage entity)
		{
			this.SendPropertyChanging();
			entity.New = this;
		}
		
		private void detach_NewsImages(NewsImage entity)
		{
			this.SendPropertyChanging();
			entity.New = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private string _UserName;
		
		private string _Password;
		
		private string _MailAddress;
		
		private int _Right;
		
		private EntitySet<Article> _Articles;
		
		private EntitySet<New> _News;
		
		private EntityRef<Right> _Right1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDateChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnMailAddressChanging(string value);
    partial void OnMailAddressChanged();
    partial void OnRightChanging(int value);
    partial void OnRightChanged();
    #endregion
		
		public User()
		{
			this._Articles = new EntitySet<Article>(new Action<Article>(this.attach_Articles), new Action<Article>(this.detach_Articles));
			this._News = new EntitySet<New>(new Action<New>(this.attach_News), new Action<New>(this.detach_News));
			this._Right1 = default(EntityRef<Right>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="Date")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailAddress", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string MailAddress
		{
			get
			{
				return this._MailAddress;
			}
			set
			{
				if ((this._MailAddress != value))
				{
					this.OnMailAddressChanging(value);
					this.SendPropertyChanging();
					this._MailAddress = value;
					this.SendPropertyChanged("MailAddress");
					this.OnMailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Right]", Storage="_Right", DbType="Int NOT NULL")]
		public int Right
		{
			get
			{
				return this._Right;
			}
			set
			{
				if ((this._Right != value))
				{
					this.OnRightChanging(value);
					this.SendPropertyChanging();
					this._Right = value;
					this.SendPropertyChanged("Right");
					this.OnRightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Article", Storage="_Articles", ThisKey="Id", OtherKey="Author")]
		public EntitySet<Article> Articles
		{
			get
			{
				return this._Articles;
			}
			set
			{
				this._Articles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_New", Storage="_News", ThisKey="Id", OtherKey="Author")]
		public EntitySet<New> News
		{
			get
			{
				return this._News;
			}
			set
			{
				this._News.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Right_User", Storage="_Right1", ThisKey="Right", OtherKey="Id", IsForeignKey=true)]
		public Right Right1
		{
			get
			{
				return this._Right1.Entity;
			}
			set
			{
				Right previousValue = this._Right1.Entity;
				if (((previousValue != value) 
							|| (this._Right1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Right1.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Right1.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._Right = value.Id;
					}
					else
					{
						this._Right = default(int);
					}
					this.SendPropertyChanged("Right1");
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
		
		private void attach_Articles(Article entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Articles(Article entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_News(New entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_News(New entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
