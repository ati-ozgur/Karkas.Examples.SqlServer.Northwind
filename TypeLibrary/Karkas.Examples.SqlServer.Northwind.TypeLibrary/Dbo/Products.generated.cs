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
		[Required]
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
		[Required]
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

		[Required]
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
