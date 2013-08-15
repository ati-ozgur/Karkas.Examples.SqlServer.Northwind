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
	[DebuggerDisplay("OrderId = {OrderId}ProductId = {ProductId}")]
	public partial class 	OrderDetails: BaseTypeLibrary
	{
		private int orderId;
		private int productId;
		private decimal unitPrice;
		private short quantity;
		private float discount;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int OrderId
		{
			[DebuggerStepThrough]
			get
			{
				return orderId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (orderId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				orderId = value;
			}
		}

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

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public decimal UnitPrice
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
		public short Quantity
		{
			[DebuggerStepThrough]
			get
			{
				return quantity;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (quantity!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				quantity = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public float Discount
		{
			[DebuggerStepThrough]
			get
			{
				return discount;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (discount!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				discount = value;
			}
		}

		public OrderDetails ShallowCopy()
		{
			OrderDetails obj = new OrderDetails();
			obj.orderId = orderId;
			obj.productId = productId;
			obj.unitPrice = unitPrice;
			obj.quantity = quantity;
			obj.discount = discount;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string OrderId = "OrderID";
			public const string ProductId = "ProductID";
			public const string UnitPrice = "UnitPrice";
			public const string Quantity = "Quantity";
			public const string Discount = "Discount";
		}

	}
}
