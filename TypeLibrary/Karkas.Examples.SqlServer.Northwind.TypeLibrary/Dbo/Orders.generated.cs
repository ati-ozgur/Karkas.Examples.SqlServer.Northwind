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
	[DebuggerDisplay("OrderId = {OrderId}CustomerId = {CustomerId}EmployeeId = {EmployeeId}ShipVia = {ShipVia}")]
	public partial class 	Orders: BaseTypeLibrary
	{
		private int orderId;
		private string customerId;
		private Nullable<int> employeeId;
		private Nullable<DateTime> orderDate;
		private Nullable<DateTime> requiredDate;
		private Nullable<DateTime> shippedDate;
		private Nullable<int> shipVia;
		private Nullable<decimal> freight;
		private string shipName;
		private string shipAddress;
		private string shipCity;
		private string shipRegion;
		private string shipPostalCode;
		private string shipCountry;

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

		[StringLength(5)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CustomerId
		{
			[DebuggerStepThrough]
			get
			{
				return customerId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (customerId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				customerId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> EmployeeId
		{
			[DebuggerStepThrough]
			get
			{
				return employeeId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (employeeId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				employeeId = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> OrderDate
		{
			[DebuggerStepThrough]
			get
			{
				return orderDate;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (orderDate!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				orderDate = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> RequiredDate
		{
			[DebuggerStepThrough]
			get
			{
				return requiredDate;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (requiredDate!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				requiredDate = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> ShippedDate
		{
			[DebuggerStepThrough]
			get
			{
				return shippedDate;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shippedDate!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shippedDate = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> ShipVia
		{
			[DebuggerStepThrough]
			get
			{
				return shipVia;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipVia!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipVia = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<decimal> Freight
		{
			[DebuggerStepThrough]
			get
			{
				return freight;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (freight!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				freight = value;
			}
		}

		[StringLength(40)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ShipName
		{
			[DebuggerStepThrough]
			get
			{
				return shipName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipName = value;
			}
		}

		[StringLength(60)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ShipAddress
		{
			[DebuggerStepThrough]
			get
			{
				return shipAddress;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipAddress!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipAddress = value;
			}
		}

		[StringLength(15)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ShipCity
		{
			[DebuggerStepThrough]
			get
			{
				return shipCity;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipCity!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipCity = value;
			}
		}

		[StringLength(15)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ShipRegion
		{
			[DebuggerStepThrough]
			get
			{
				return shipRegion;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipRegion!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipRegion = value;
			}
		}

		[StringLength(10)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ShipPostalCode
		{
			[DebuggerStepThrough]
			get
			{
				return shipPostalCode;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipPostalCode!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipPostalCode = value;
			}
		}

		[StringLength(15)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ShipCountry
		{
			[DebuggerStepThrough]
			get
			{
				return shipCountry;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipCountry!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipCountry = value;
			}
		}

		public Orders ShallowCopy()
		{
			Orders obj = new Orders();
			obj.orderId = orderId;
			obj.customerId = customerId;
			obj.employeeId = employeeId;
			obj.orderDate = orderDate;
			obj.requiredDate = requiredDate;
			obj.shippedDate = shippedDate;
			obj.shipVia = shipVia;
			obj.freight = freight;
			obj.shipName = shipName;
			obj.shipAddress = shipAddress;
			obj.shipCity = shipCity;
			obj.shipRegion = shipRegion;
			obj.shipPostalCode = shipPostalCode;
			obj.shipCountry = shipCountry;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string OrderId = "OrderID";
			public const string CustomerId = "CustomerID";
			public const string EmployeeId = "EmployeeID";
			public const string OrderDate = "OrderDate";
			public const string RequiredDate = "RequiredDate";
			public const string ShippedDate = "ShippedDate";
			public const string ShipVia = "ShipVia";
			public const string Freight = "Freight";
			public const string ShipName = "ShipName";
			public const string ShipAddress = "ShipAddress";
			public const string ShipCity = "ShipCity";
			public const string ShipRegion = "ShipRegion";
			public const string ShipPostalCode = "ShipPostalCode";
			public const string ShipCountry = "ShipCountry";
		}

	}
}
