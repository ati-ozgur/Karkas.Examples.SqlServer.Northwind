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
	[DebuggerDisplay("TerritoryId = {TerritoryId}RegionId = {RegionId}")]
	public partial class 	Territories: BaseTypeLibrary
	{
		private string territoryId;
		private string territoryDescription;
		private int regionId;

		[Key]
		[StringLength(20)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TerritoryId
		{
			[DebuggerStepThrough]
			get
			{
				return territoryId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (territoryId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				territoryId = value;
			}
		}

		[StringLength(50)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TerritoryDescription
		{
			[DebuggerStepThrough]
			get
			{
				return territoryDescription;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (territoryDescription!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				territoryDescription = value;
			}
		}

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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string RegionIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return regionId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				RegionId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"RegionId",string.Format(CEVIRI_YAZISI,"RegionId","int")));
				}
			}
		}

		public Territories ShallowCopy()
		{
			Territories obj = new Territories();
			obj.territoryId = territoryId;
			obj.territoryDescription = territoryDescription;
			obj.regionId = regionId;
			return obj;
		}
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "TerritoryDescription"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "RegionId"));		}
		public class PropertyIsimleri
		{
			public const string TerritoryId = "TerritoryID";
			public const string TerritoryDescription = "TerritoryDescription";
			public const string RegionId = "RegionID";
		}

	}
}
