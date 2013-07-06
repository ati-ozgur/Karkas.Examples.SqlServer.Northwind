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
	[DebuggerDisplay("CustomerId = {CustomerId}CustomerTypeId = {CustomerTypeId}")]
	public partial class 	CustomerCustomerDemo: BaseTypeLibrary
	{
		private string customerId;
		private string customerTypeId;

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

		[Key]
		[StringLength(10)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CustomerTypeId
		{
			[DebuggerStepThrough]
			get
			{
				return customerTypeId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (customerTypeId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				customerTypeId = value;
			}
		}

		public CustomerCustomerDemo ShallowCopy()
		{
			CustomerCustomerDemo obj = new CustomerCustomerDemo();
			obj.customerId = customerId;
			obj.customerTypeId = customerTypeId;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string CustomerId = "CustomerID";
			public const string CustomerTypeId = "CustomerTypeID";
		}

	}
}
