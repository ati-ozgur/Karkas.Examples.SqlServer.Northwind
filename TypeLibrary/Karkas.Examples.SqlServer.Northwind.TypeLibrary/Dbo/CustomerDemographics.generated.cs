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
	[DebuggerDisplay("CustomerTypeId = {CustomerTypeId}")]
	public partial class 	CustomerDemographics: BaseTypeLibrary
	{
		private string customerTypeId;
		private string customerDesc;

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

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CustomerDesc
		{
			[DebuggerStepThrough]
			get
			{
				return customerDesc;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (customerDesc!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				customerDesc = value;
			}
		}

		public CustomerDemographics ShallowCopy()
		{
			CustomerDemographics obj = new CustomerDemographics();
			obj.customerTypeId = customerTypeId;
			obj.customerDesc = customerDesc;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
		}
		public class PropertyIsimleri
		{
			public const string CustomerTypeId = "CustomerTypeID";
			public const string CustomerDesc = "CustomerDesc";
		}

	}
}
