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
	[DebuggerDisplay("RegionId = {RegionId}")]
	public partial class 	Region: BaseTypeLibrary
	{
		private int regionId;
		private string regionDescription;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int RegionId
		{
			[DebuggerStepThrough]
			get
			{
				return regionId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (regionId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				regionId = value;
			}
		}

		[StringLength(50)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string RegionDescription
		{
			[DebuggerStepThrough]
			get
			{
				return regionDescription;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (regionDescription!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				regionDescription = value;
			}
		}

		public Region ShallowCopy()
		{
			Region obj = new Region();
			obj.regionId = regionId;
			obj.regionDescription = regionDescription;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string RegionId = "RegionID";
			public const string RegionDescription = "RegionDescription";
		}

	}
}
