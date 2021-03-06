#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eshopadmin.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="e-Shop")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertAbout(About instance);
    partial void UpdateAbout(About instance);
    partial void DeleteAbout(About instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["e_ShopConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<ProductView> ProductViews
		{
			get
			{
				return this.GetTable<ProductView>();
			}
		}
		
		public System.Data.Linq.Table<About> Abouts
		{
			get
			{
				return this.GetTable<About>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private string _CategoryName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    #endregion
		
		public Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(64)")]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private System.Nullable<float> _ProductPrice;
		
		private System.Nullable<float> _ProductDiscount;
		
		private string _ProductInfo;
		
		private System.Nullable<int> _ProductCategoryID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnProductPriceChanging(System.Nullable<float> value);
    partial void OnProductPriceChanged();
    partial void OnProductDiscountChanging(System.Nullable<float> value);
    partial void OnProductDiscountChanged();
    partial void OnProductInfoChanging(string value);
    partial void OnProductInfoChanged();
    partial void OnProductCategoryIDChanging(System.Nullable<int> value);
    partial void OnProductCategoryIDChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(128)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="Real")]
		public System.Nullable<float> ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this.OnProductPriceChanging(value);
					this.SendPropertyChanging();
					this._ProductPrice = value;
					this.SendPropertyChanged("ProductPrice");
					this.OnProductPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDiscount", DbType="Real")]
		public System.Nullable<float> ProductDiscount
		{
			get
			{
				return this._ProductDiscount;
			}
			set
			{
				if ((this._ProductDiscount != value))
				{
					this.OnProductDiscountChanging(value);
					this.SendPropertyChanging();
					this._ProductDiscount = value;
					this.SendPropertyChanged("ProductDiscount");
					this.OnProductDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductInfo", DbType="NVarChar(MAX)")]
		public string ProductInfo
		{
			get
			{
				return this._ProductInfo;
			}
			set
			{
				if ((this._ProductInfo != value))
				{
					this.OnProductInfoChanging(value);
					this.SendPropertyChanging();
					this._ProductInfo = value;
					this.SendPropertyChanged("ProductInfo");
					this.OnProductInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCategoryID", DbType="Int")]
		public System.Nullable<int> ProductCategoryID
		{
			get
			{
				return this._ProductCategoryID;
			}
			set
			{
				if ((this._ProductCategoryID != value))
				{
					this.OnProductCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._ProductCategoryID = value;
					this.SendPropertyChanged("ProductCategoryID");
					this.OnProductCategoryIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductView")]
	public partial class ProductView
	{
		
		private int _ProductID;
		
		private string _ProductName;
		
		private System.Nullable<float> _ProductPrice;
		
		private System.Nullable<float> _ProductDiscount;
		
		private string _ProductInfo;
		
		private int _CategoryID;
		
		private string _CategoryName;
		
		public ProductView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this._ProductID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(128)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="Real")]
		public System.Nullable<float> ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this._ProductPrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDiscount", DbType="Real")]
		public System.Nullable<float> ProductDiscount
		{
			get
			{
				return this._ProductDiscount;
			}
			set
			{
				if ((this._ProductDiscount != value))
				{
					this._ProductDiscount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductInfo", DbType="NVarChar(MAX)")]
		public string ProductInfo
		{
			get
			{
				return this._ProductInfo;
			}
			set
			{
				if ((this._ProductInfo != value))
				{
					this._ProductInfo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL")]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this._CategoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(64)")]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this._CategoryName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.About")]
	public partial class About : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AboutID;
		
		private string _AboutPhoneNumber;
		
		private string _AboutFacebook;
		
		private string _AboutInstagram;
		
		private string _AboutWhatsapp;
		
		private string _AboutEmail;
		
		private string _AboutInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAboutIDChanging(int value);
    partial void OnAboutIDChanged();
    partial void OnAboutPhoneNumberChanging(string value);
    partial void OnAboutPhoneNumberChanged();
    partial void OnAboutFacebookChanging(string value);
    partial void OnAboutFacebookChanged();
    partial void OnAboutInstagramChanging(string value);
    partial void OnAboutInstagramChanged();
    partial void OnAboutWhatsappChanging(string value);
    partial void OnAboutWhatsappChanged();
    partial void OnAboutEmailChanging(string value);
    partial void OnAboutEmailChanged();
    partial void OnAboutInfoChanging(string value);
    partial void OnAboutInfoChanged();
    #endregion
		
		public About()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AboutID
		{
			get
			{
				return this._AboutID;
			}
			set
			{
				if ((this._AboutID != value))
				{
					this.OnAboutIDChanging(value);
					this.SendPropertyChanging();
					this._AboutID = value;
					this.SendPropertyChanged("AboutID");
					this.OnAboutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutPhoneNumber", DbType="NVarChar(64)")]
		public string AboutPhoneNumber
		{
			get
			{
				return this._AboutPhoneNumber;
			}
			set
			{
				if ((this._AboutPhoneNumber != value))
				{
					this.OnAboutPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._AboutPhoneNumber = value;
					this.SendPropertyChanged("AboutPhoneNumber");
					this.OnAboutPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutFacebook", DbType="NVarChar(64)")]
		public string AboutFacebook
		{
			get
			{
				return this._AboutFacebook;
			}
			set
			{
				if ((this._AboutFacebook != value))
				{
					this.OnAboutFacebookChanging(value);
					this.SendPropertyChanging();
					this._AboutFacebook = value;
					this.SendPropertyChanged("AboutFacebook");
					this.OnAboutFacebookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutInstagram", DbType="NVarChar(64)")]
		public string AboutInstagram
		{
			get
			{
				return this._AboutInstagram;
			}
			set
			{
				if ((this._AboutInstagram != value))
				{
					this.OnAboutInstagramChanging(value);
					this.SendPropertyChanging();
					this._AboutInstagram = value;
					this.SendPropertyChanged("AboutInstagram");
					this.OnAboutInstagramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutWhatsapp", DbType="NVarChar(64)")]
		public string AboutWhatsapp
		{
			get
			{
				return this._AboutWhatsapp;
			}
			set
			{
				if ((this._AboutWhatsapp != value))
				{
					this.OnAboutWhatsappChanging(value);
					this.SendPropertyChanging();
					this._AboutWhatsapp = value;
					this.SendPropertyChanged("AboutWhatsapp");
					this.OnAboutWhatsappChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutEmail", DbType="NVarChar(64)")]
		public string AboutEmail
		{
			get
			{
				return this._AboutEmail;
			}
			set
			{
				if ((this._AboutEmail != value))
				{
					this.OnAboutEmailChanging(value);
					this.SendPropertyChanging();
					this._AboutEmail = value;
					this.SendPropertyChanged("AboutEmail");
					this.OnAboutEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutInfo", DbType="NVarChar(MAX)")]
		public string AboutInfo
		{
			get
			{
				return this._AboutInfo;
			}
			set
			{
				if ((this._AboutInfo != value))
				{
					this.OnAboutInfoChanging(value);
					this.SendPropertyChanging();
					this._AboutInfo = value;
					this.SendPropertyChanged("AboutInfo");
					this.OnAboutInfoChanged();
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
