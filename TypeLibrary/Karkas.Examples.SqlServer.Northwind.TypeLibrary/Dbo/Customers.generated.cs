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
	[DebuggerDisplay("CustomerId = {CustomerId}")]
	public partial class 	Customers: BaseTypeLibrary
	{
		private string customerId;
		private string companyName;
		private string contactName;
		private string contactTitle;
		private string address;
		private string city;
		private string region;
		private string postalCode;
		private string country;
		private string phone;
		private string fax;

		[Key]
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

		[StringLength(30)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ContactName
		{
			[DebuggerStepThrough]
			get
			{
				return contactName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (contactName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				contactName = value;
			}
		}

		[StringLength(30)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ContactTitle
		{
			[DebuggerStepThrough]
			get
			{
				return contactTitle;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (contactTitle!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				contactTitle = value;
			}
		}

		[StringLength(60)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Address
		{
			[DebuggerStepThrough]
			get
			{
				return address;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (address!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				address = value;
			}
		}

		[StringLength(15)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string City
		{
			[DebuggerStepThrough]
			get
			{
				return city;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (city!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				city = value;
			}
		}

		[StringLength(15)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Region
		{
			[DebuggerStepThrough]
			get
			{
				return region;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (region!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				region = value;
			}
		}

		[StringLength(10)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string PostalCode
		{
			[DebuggerStepThrough]
			get
			{
				return postalCode;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (postalCode!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				postalCode = value;
			}
		}

		[StringLength(15)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Country
		{
			[DebuggerStepThrough]
			get
			{
				return country;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (country!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				country = value;
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

		[StringLength(24)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Fax
		{
			[DebuggerStepThrough]
			get
			{
				return fax;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (fax!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				fax = value;
			}
		}

		public Customers ShallowCopy()
		{
			Customers obj = new Customers();
			obj.customerId = customerId;
			obj.companyName = companyName;
			obj.contactName = contactName;
			obj.contactTitle = contactTitle;
			obj.address = address;
			obj.city = city;
			obj.region = region;
			obj.postalCode = postalCode;
			obj.country = country;
			obj.phone = phone;
			obj.fax = fax;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "CompanyName"));		}
		public class PropertyIsimleri
		{
			public const string CustomerId = "CustomerID";
			public const string CompanyName = "CompanyName";
			public const string ContactName = "ContactName";
			public const string ContactTitle = "ContactTitle";
			public const string Address = "Address";
			public const string City = "City";
			public const string Region = "Region";
			public const string PostalCode = "PostalCode";
			public const string Country = "Country";
			public const string Phone = "Phone";
			public const string Fax = "Fax";
		}

	}
}
