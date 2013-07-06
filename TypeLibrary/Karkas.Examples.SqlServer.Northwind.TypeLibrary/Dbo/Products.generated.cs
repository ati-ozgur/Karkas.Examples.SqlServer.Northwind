using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using Karkas.Core.Onaylama;
using Karkas.Core.Onaylama.ForPonos;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo
{
	[Serializable]
	[DebuggerDisplay("ProductId = {ProductId}SupplierId = {SupplierId}CategoryId = {CategoryId}")]
	public partial class 	Products: BaseTypeLibrary
	{
		private int productId;
		private string productName;
		private Nullable<int> supplierId;
		private Nullable<int> categoryId;
		private string quantityPerUnit;
		private Nullable<decimal> unitPrice;
		private Nullable<short> unitsInStock;
		private Nullable<short> unitsOnOrder;
		private Nullable<short> reorderLevel;
		private bool discontinued;

		[Key]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int ProductId
		{
			[DebuggerStepThrough]
			get
			{
				return productId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (productId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				productId = value;
			}
		}

		[StringLength(40)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ProductName
		{
			[DebuggerStepThrough]
			get
			{
				return productName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (productName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				productName = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> SupplierId
		{
			[DebuggerStepThrough]
			get
			{
				return supplierId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (supplierId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				supplierId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> CategoryId
		{
			[DebuggerStepThrough]
			get
			{
				return categoryId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (categoryId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				categoryId = value;
			}
		}

		[StringLength(20)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string QuantityPerUnit
		{
			[DebuggerStepThrough]
			get
			{
				return quantityPerUnit;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (quantityPerUnit!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				quantityPerUnit = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> UnitPrice
		{
			[DebuggerStepThrough]
			get
			{
				return unitPrice;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (unitPrice!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				unitPrice = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<short> UnitsInStock
		{
			[DebuggerStepThrough]
			get
			{
				return unitsInStock;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (unitsInStock!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				unitsInStock = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<short> UnitsOnOrder
		{
			[DebuggerStepThrough]
			get
			{
				return unitsOnOrder;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (unitsOnOrder!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				unitsOnOrder = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<short> ReorderLevel
		{
			[DebuggerStepThrough]
			get
			{
				return reorderLevel;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (reorderLevel!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				reorderLevel = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool Discontinued
		{
			[DebuggerStepThrough]
			get
			{
				return discontinued;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (discontinued!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				discontinued = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string ProductIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return productId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				ProductId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"ProductId",string.Format(CEVIRI_YAZISI,"ProductId","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SupplierIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return supplierId != null ? supplierId.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				SupplierId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"SupplierId",string.Format(CEVIRI_YAZISI,"SupplierId","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string CategoryIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return categoryId != null ? categoryId.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				CategoryId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"CategoryId",string.Format(CEVIRI_YAZISI,"CategoryId","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string UnitPriceAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return unitPrice != null ? unitPrice.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					decimal _a = Convert.ToDecimal(value);
				UnitPrice = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"UnitPrice",string.Format(CEVIRI_YAZISI,"UnitPrice","decimal")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string UnitsInStockAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return unitsInStock != null ? unitsInStock.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					short _a = Convert.ToInt16(value);
				UnitsInStock = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"UnitsInStock",string.Format(CEVIRI_YAZISI,"UnitsInStock","short")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string UnitsOnOrderAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return unitsOnOrder != null ? unitsOnOrder.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					short _a = Convert.ToInt16(value);
				UnitsOnOrder = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"UnitsOnOrder",string.Format(CEVIRI_YAZISI,"UnitsOnOrder","short")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string ReorderLevelAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return reorderLevel != null ? reorderLevel.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					short _a = Convert.ToInt16(value);
				ReorderLevel = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"ReorderLevel",string.Format(CEVIRI_YAZISI,"ReorderLevel","short")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DiscontinuedAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return discontinued.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					bool _a = Convert.ToBoolean(value);
				Discontinued = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Discontinued",string.Format(CEVIRI_YAZISI,"Discontinued","bool")));
				}
			}
		}

		public Products ShallowCopy()
		{
			Products obj = new Products();
			obj.productId = productId;
			obj.productName = productName;
			obj.supplierId = supplierId;
			obj.categoryId = categoryId;
			obj.quantityPerUnit = quantityPerUnit;
			obj.unitPrice = unitPrice;
			obj.unitsInStock = unitsInStock;
			obj.unitsOnOrder = unitsOnOrder;
			obj.reorderLevel = reorderLevel;
			obj.discontinued = discontinued;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "ProductName"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Discontinued"));		}
		public class PropertyIsimleri
		{
			public const string ProductId = "ProductID";
			public const string ProductName = "ProductName";
			public const string SupplierId = "SupplierID";
			public const string CategoryId = "CategoryID";
			public const string QuantityPerUnit = "QuantityPerUnit";
			public const string UnitPrice = "UnitPrice";
			public const string UnitsInStock = "UnitsInStock";
			public const string UnitsOnOrder = "UnitsOnOrder";
			public const string ReorderLevel = "ReorderLevel";
			public const string Discontinued = "Discontinued";
		}

	}
}
