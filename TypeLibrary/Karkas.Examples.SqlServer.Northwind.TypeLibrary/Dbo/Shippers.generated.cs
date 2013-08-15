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
	[DebuggerDisplay("ShipperId = {ShipperId}")]
	public partial class 	Shippers: BaseTypeLibrary
	{
		private int shipperId;
		private string companyName;
		private string phone;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int ShipperId
		{
			[DebuggerStepThrough]
			get
			{
				return shipperId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (shipperId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				shipperId = value;
			}
		}

		[StringLength(40)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CompanyName
		{
			[DebuggerStepThrough]
			get
			{
				return companyName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (companyName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				companyName = value;
			}
		}

		[StringLength(24)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Phone
		{
			[DebuggerStepThrough]
			get
			{
				return phone;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (phone!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				phone = value;
			}
		}

		public Shippers ShallowCopy()
		{
			Shippers obj = new Shippers();
			obj.shipperId = shipperId;
			obj.companyName = companyName;
			obj.phone = phone;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string ShipperId = "ShipperID";
			public const string CompanyName = "CompanyName";
			public const string Phone = "Phone";
		}

	}
}
