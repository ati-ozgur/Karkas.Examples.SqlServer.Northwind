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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string OrderIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return orderId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				OrderId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"OrderId",string.Format(CEVIRI_YAZISI,"OrderId","int")));
				}
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
		public string UnitPriceAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return unitPrice.ToString(); 
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
		public string QuantityAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return quantity.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					short _a = Convert.ToInt16(value);
				Quantity = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Quantity",string.Format(CEVIRI_YAZISI,"Quantity","short")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string DiscountAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return discount.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					float _a = Convert.ToSingle(value);
				Discount = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Discount",string.Format(CEVIRI_YAZISI,"Discount","float")));
				}
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
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "UnitPrice"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Quantity"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Discount"));		}
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
