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
		[Required]
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string ShipperIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return shipperId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				ShipperId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"ShipperId",string.Format(CEVIRI_YAZISI,"ShipperId","int")));
				}
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
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "CompanyName"));		}
		public class PropertyIsimleri
		{
			public const string ShipperId = "ShipperID";
			public const string CompanyName = "CompanyName";
			public const string Phone = "Phone";
		}

	}
}
