﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NGEServiceWithLinq
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
	
	
	public partial class NGEsysDB : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertArticle(Article instance);
    partial void UpdateArticle(Article instance);
    partial void DeleteArticle(Article instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertLayout(Layout instance);
    partial void UpdateLayout(Layout instance);
    partial void DeleteLayout(Layout instance);
    partial void InsertPosition(Position instance);
    partial void UpdatePosition(Position instance);
    partial void DeletePosition(Position instance);
    partial void InsertStaff(Staff instance);
    partial void UpdateStaff(Staff instance);
    partial void DeleteStaff(Staff instance);
    #endregion
		
		public NGEsysDB(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NGEsysDB(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NGEsysDB(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NGEsysDB(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Article> Article
		{
			get
			{
				return this.GetTable<Article>();
			}
		}
		
		public System.Data.Linq.Table<Department> Department
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Layout> Layout
		{
			get
			{
				return this.GetTable<Layout>();
			}
		}
		
		public System.Data.Linq.Table<Position> Position
		{
			get
			{
				return this.GetTable<Position>();
			}
		}
		
		public System.Data.Linq.Table<Staff> Staff
		{
			get
			{
				return this.GetTable<Staff>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Article")]
	public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ArticleID;
		
		private System.DateTime _APubDate;
		
		private string _Author;
		
		private string _Department;
		
		private int _AStatus;
		
		private string _APath;
		
		private string _OnLayout;
		
		private EntityRef<Layout> _Layout;
		
		private EntityRef<Staff> _Staff;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnArticleIDChanging(string value);
    partial void OnArticleIDChanged();
    partial void OnAPubDateChanging(System.DateTime value);
    partial void OnAPubDateChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnAStatusChanging(int value);
    partial void OnAStatusChanged();
    partial void OnAPathChanging(string value);
    partial void OnAPathChanged();
    partial void OnOnLayoutChanging(string value);
    partial void OnOnLayoutChanged();
    #endregion
		
		public Article()
		{
			this._Layout = default(EntityRef<Layout>);
			this._Staff = default(EntityRef<Staff>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="articleID", Storage="_ArticleID", DbType="Char(12) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ArticleID
		{
			get
			{
				return this._ArticleID;
			}
			set
			{
				if ((this._ArticleID != value))
				{
					this.OnArticleIDChanging(value);
					this.SendPropertyChanging();
					this._ArticleID = value;
					this.SendPropertyChanged("ArticleID");
					this.OnArticleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="aPubDate", Storage="_APubDate", DbType="Date NOT NULL")]
		public System.DateTime APubDate
		{
			get
			{
				return this._APubDate;
			}
			set
			{
				if ((this._APubDate != value))
				{
					this.OnAPubDateChanging(value);
					this.SendPropertyChanging();
					this._APubDate = value;
					this.SendPropertyChanged("APubDate");
					this.OnAPubDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="author", Storage="_Author", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="department", Storage="_Department", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="aStatus", Storage="_AStatus", DbType="Int NOT NULL")]
		public int AStatus
		{
			get
			{
				return this._AStatus;
			}
			set
			{
				if ((this._AStatus != value))
				{
					this.OnAStatusChanging(value);
					this.SendPropertyChanging();
					this._AStatus = value;
					this.SendPropertyChanged("AStatus");
					this.OnAStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="aPath", Storage="_APath", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string APath
		{
			get
			{
				return this._APath;
			}
			set
			{
				if ((this._APath != value))
				{
					this.OnAPathChanging(value);
					this.SendPropertyChanging();
					this._APath = value;
					this.SendPropertyChanged("APath");
					this.OnAPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="onLayout", Storage="_OnLayout", DbType="Char(12) NOT NULL", CanBeNull=false)]
		public string OnLayout
		{
			get
			{
				return this._OnLayout;
			}
			set
			{
				if ((this._OnLayout != value))
				{
					this.OnOnLayoutChanging(value);
					this.SendPropertyChanging();
					this._OnLayout = value;
					this.SendPropertyChanged("OnLayout");
					this.OnOnLayoutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Article_Layout", Storage="_Layout", ThisKey="OnLayout", OtherKey="LayoutID", IsForeignKey=true)]
		public Layout Layout
		{
			get
			{
				return this._Layout.Entity;
			}
			set
			{
				Layout previousValue = this._Layout.Entity;
				if (((previousValue != value) 
							|| (this._Layout.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Layout.Entity = null;
						previousValue.Article.Remove(this);
					}
					this._Layout.Entity = value;
					if ((value != null))
					{
						value.Article.Add(this);
						this._OnLayout = value.LayoutID;
					}
					else
					{
						this._OnLayout = default(string);
					}
					this.SendPropertyChanged("Layout");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Article_Staff", Storage="_Staff", ThisKey="Author", OtherKey="StaffID", IsForeignKey=true)]
		public Staff Staff
		{
			get
			{
				return this._Staff.Entity;
			}
			set
			{
				Staff previousValue = this._Staff.Entity;
				if (((previousValue != value) 
							|| (this._Staff.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Staff.Entity = null;
						previousValue.Article.Remove(this);
					}
					this._Staff.Entity = value;
					if ((value != null))
					{
						value.Article.Add(this);
						this._Author = value.StaffID;
					}
					else
					{
						this._Author = default(string);
					}
					this.SendPropertyChanged("Staff");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Dcode;
		
		private string _DptName;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDcodeChanging(string value);
    partial void OnDcodeChanged();
    partial void OnDptNameChanging(string value);
    partial void OnDptNameChanged();
    #endregion
		
		public Department()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="dcode", Storage="_Dcode", DbType="Char(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Dcode
		{
			get
			{
				return this._Dcode;
			}
			set
			{
				if ((this._Dcode != value))
				{
					this.OnDcodeChanging(value);
					this.SendPropertyChanging();
					this._Dcode = value;
					this.SendPropertyChanged("Dcode");
					this.OnDcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="dptName", Storage="_DptName", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string DptName
		{
			get
			{
				return this._DptName;
			}
			set
			{
				if ((this._DptName != value))
				{
					this.OnDptNameChanging(value);
					this.SendPropertyChanging();
					this._DptName = value;
					this.SendPropertyChanged("DptName");
					this.OnDptNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Layout")]
	public partial class Layout : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LayoutID;
		
		private System.DateTime _LPubDate;
		
		private string _Editor;
		
		private string _Department;
		
		private int _LStatus;
		
		private string _LPath;
		
		private EntitySet<Article> _Article;
		
		private EntityRef<Staff> _Staff;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLayoutIDChanging(string value);
    partial void OnLayoutIDChanged();
    partial void OnLPubDateChanging(System.DateTime value);
    partial void OnLPubDateChanged();
    partial void OnEditorChanging(string value);
    partial void OnEditorChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnLStatusChanging(int value);
    partial void OnLStatusChanged();
    partial void OnLPathChanging(string value);
    partial void OnLPathChanged();
    #endregion
		
		public Layout()
		{
			this._Article = new EntitySet<Article>(new Action<Article>(this.attach_Article), new Action<Article>(this.detach_Article));
			this._Staff = default(EntityRef<Staff>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="layoutID", Storage="_LayoutID", DbType="Char(12) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LayoutID
		{
			get
			{
				return this._LayoutID;
			}
			set
			{
				if ((this._LayoutID != value))
				{
					this.OnLayoutIDChanging(value);
					this.SendPropertyChanging();
					this._LayoutID = value;
					this.SendPropertyChanged("LayoutID");
					this.OnLayoutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="lPubDate", Storage="_LPubDate", DbType="Date NOT NULL")]
		public System.DateTime LPubDate
		{
			get
			{
				return this._LPubDate;
			}
			set
			{
				if ((this._LPubDate != value))
				{
					this.OnLPubDateChanging(value);
					this.SendPropertyChanging();
					this._LPubDate = value;
					this.SendPropertyChanged("LPubDate");
					this.OnLPubDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="editor", Storage="_Editor", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string Editor
		{
			get
			{
				return this._Editor;
			}
			set
			{
				if ((this._Editor != value))
				{
					this.OnEditorChanging(value);
					this.SendPropertyChanging();
					this._Editor = value;
					this.SendPropertyChanged("Editor");
					this.OnEditorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="department", Storage="_Department", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="lStatus", Storage="_LStatus", DbType="Int NOT NULL")]
		public int LStatus
		{
			get
			{
				return this._LStatus;
			}
			set
			{
				if ((this._LStatus != value))
				{
					this.OnLStatusChanging(value);
					this.SendPropertyChanging();
					this._LStatus = value;
					this.SendPropertyChanged("LStatus");
					this.OnLStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="lPath", Storage="_LPath", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string LPath
		{
			get
			{
				return this._LPath;
			}
			set
			{
				if ((this._LPath != value))
				{
					this.OnLPathChanging(value);
					this.SendPropertyChanging();
					this._LPath = value;
					this.SendPropertyChanged("LPath");
					this.OnLPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Article_Layout", Storage="_Article", ThisKey="LayoutID", OtherKey="OnLayout", DeleteRule="NO ACTION")]
		public EntitySet<Article> Article
		{
			get
			{
				return this._Article;
			}
			set
			{
				this._Article.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Layout_Staff", Storage="_Staff", ThisKey="Editor", OtherKey="StaffID", IsForeignKey=true)]
		public Staff Staff
		{
			get
			{
				return this._Staff.Entity;
			}
			set
			{
				Staff previousValue = this._Staff.Entity;
				if (((previousValue != value) 
							|| (this._Staff.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Staff.Entity = null;
						previousValue.Layout.Remove(this);
					}
					this._Staff.Entity = value;
					if ((value != null))
					{
						value.Layout.Add(this);
						this._Editor = value.StaffID;
					}
					else
					{
						this._Editor = default(string);
					}
					this.SendPropertyChanged("Staff");
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
		
		private void attach_Article(Article entity)
		{
			this.SendPropertyChanging();
			entity.Layout = this;
		}
		
		private void detach_Article(Article entity)
		{
			this.SendPropertyChanging();
			entity.Layout = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Position")]
	public partial class Position : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Pcode;
		
		private string _PstnName;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPcodeChanging(string value);
    partial void OnPcodeChanged();
    partial void OnPstnNameChanging(string value);
    partial void OnPstnNameChanged();
    #endregion
		
		public Position()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="pcode", Storage="_Pcode", DbType="Char(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Pcode
		{
			get
			{
				return this._Pcode;
			}
			set
			{
				if ((this._Pcode != value))
				{
					this.OnPcodeChanging(value);
					this.SendPropertyChanging();
					this._Pcode = value;
					this.SendPropertyChanged("Pcode");
					this.OnPcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="pstnName", Storage="_PstnName", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string PstnName
		{
			get
			{
				return this._PstnName;
			}
			set
			{
				if ((this._PstnName != value))
				{
					this.OnPstnNameChanging(value);
					this.SendPropertyChanging();
					this._PstnName = value;
					this.SendPropertyChanged("PstnName");
					this.OnPstnNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Staff")]
	public partial class Staff : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StaffID;
		
		private string _StfName;
		
		private int _StfYearIn;
		
		private string _StfPstn;
		
		private string _StfDpt;
		
		private string _StfDgr;
		
		private string _StfGrdtdFrm;
		
		private string _Password;
		
		private EntitySet<Article> _Article;
		
		private EntitySet<Layout> _Layout;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStaffIDChanging(string value);
    partial void OnStaffIDChanged();
    partial void OnStfNameChanging(string value);
    partial void OnStfNameChanged();
    partial void OnStfYearInChanging(int value);
    partial void OnStfYearInChanged();
    partial void OnStfPstnChanging(string value);
    partial void OnStfPstnChanged();
    partial void OnStfDptChanging(string value);
    partial void OnStfDptChanged();
    partial void OnStfDgrChanging(string value);
    partial void OnStfDgrChanged();
    partial void OnStfGrdtdFrmChanging(string value);
    partial void OnStfGrdtdFrmChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Staff()
		{
			this._Article = new EntitySet<Article>(new Action<Article>(this.attach_Article), new Action<Article>(this.detach_Article));
			this._Layout = new EntitySet<Layout>(new Action<Layout>(this.attach_Layout), new Action<Layout>(this.detach_Layout));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="staffID", Storage="_StaffID", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StaffID
		{
			get
			{
				return this._StaffID;
			}
			set
			{
				if ((this._StaffID != value))
				{
					this.OnStaffIDChanging(value);
					this.SendPropertyChanging();
					this._StaffID = value;
					this.SendPropertyChanged("StaffID");
					this.OnStaffIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stfName", Storage="_StfName", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string StfName
		{
			get
			{
				return this._StfName;
			}
			set
			{
				if ((this._StfName != value))
				{
					this.OnStfNameChanging(value);
					this.SendPropertyChanging();
					this._StfName = value;
					this.SendPropertyChanged("StfName");
					this.OnStfNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stfYearIn", Storage="_StfYearIn", DbType="Int NOT NULL")]
		public int StfYearIn
		{
			get
			{
				return this._StfYearIn;
			}
			set
			{
				if ((this._StfYearIn != value))
				{
					this.OnStfYearInChanging(value);
					this.SendPropertyChanging();
					this._StfYearIn = value;
					this.SendPropertyChanged("StfYearIn");
					this.OnStfYearInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stfPstn", Storage="_StfPstn", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string StfPstn
		{
			get
			{
				return this._StfPstn;
			}
			set
			{
				if ((this._StfPstn != value))
				{
					this.OnStfPstnChanging(value);
					this.SendPropertyChanging();
					this._StfPstn = value;
					this.SendPropertyChanged("StfPstn");
					this.OnStfPstnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stfDpt", Storage="_StfDpt", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string StfDpt
		{
			get
			{
				return this._StfDpt;
			}
			set
			{
				if ((this._StfDpt != value))
				{
					this.OnStfDptChanging(value);
					this.SendPropertyChanging();
					this._StfDpt = value;
					this.SendPropertyChanged("StfDpt");
					this.OnStfDptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stfDgr", Storage="_StfDgr", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string StfDgr
		{
			get
			{
				return this._StfDgr;
			}
			set
			{
				if ((this._StfDgr != value))
				{
					this.OnStfDgrChanging(value);
					this.SendPropertyChanging();
					this._StfDgr = value;
					this.SendPropertyChanged("StfDgr");
					this.OnStfDgrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stfGrdtdFrm", Storage="_StfGrdtdFrm", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string StfGrdtdFrm
		{
			get
			{
				return this._StfGrdtdFrm;
			}
			set
			{
				if ((this._StfGrdtdFrm != value))
				{
					this.OnStfGrdtdFrmChanging(value);
					this.SendPropertyChanging();
					this._StfGrdtdFrm = value;
					this.SendPropertyChanged("StfGrdtdFrm");
					this.OnStfGrdtdFrmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="password", Storage="_Password", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Article_Staff", Storage="_Article", ThisKey="StaffID", OtherKey="Author", DeleteRule="NO ACTION")]
		public EntitySet<Article> Article
		{
			get
			{
				return this._Article;
			}
			set
			{
				this._Article.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Layout_Staff", Storage="_Layout", ThisKey="StaffID", OtherKey="Editor", DeleteRule="NO ACTION")]
		public EntitySet<Layout> Layout
		{
			get
			{
				return this._Layout;
			}
			set
			{
				this._Layout.Assign(value);
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
		
		private void attach_Article(Article entity)
		{
			this.SendPropertyChanging();
			entity.Staff = this;
		}
		
		private void detach_Article(Article entity)
		{
			this.SendPropertyChanging();
			entity.Staff = null;
		}
		
		private void attach_Layout(Layout entity)
		{
			this.SendPropertyChanging();
			entity.Staff = this;
		}
		
		private void detach_Layout(Layout entity)
		{
			this.SendPropertyChanging();
			entity.Staff = null;
		}
	}
}
#pragma warning restore 1591
