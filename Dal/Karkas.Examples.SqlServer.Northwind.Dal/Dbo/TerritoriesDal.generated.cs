
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo;


namespace Karkas.Examples.SqlServer.Northwind.Dal.Dbo
{
public partial class TerritoriesDal : BaseDal<Territories>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Territories pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Territories";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT TerritoryID,TerritoryDescription,RegionID FROM dbo.Territories";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Territories WHERE TerritoryID = @TerritoryID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Territories
			 SET 
			TerritoryDescription = @TerritoryDescription
,RegionID = @RegionID
			
			WHERE 
			 TerritoryID = @TerritoryID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Territories 
			 (TerritoryID,TerritoryDescription,RegionID) 
			 VALUES 
						(@TerritoryID,@TerritoryDescription,@RegionID)";
		}
	}
	public Territories SorgulaTerritoryIdIle(string p1)
	{
		List<Territories> liste = new List<Territories>();
		SorguCalistir(liste,String.Format(" TerritoryID = '{0}'", p1));		
		if (liste.Count > 0)
		{
			return liste[0];
		}
		else
		{
			return null;
		}
	}
	
	protected override bool IdentityVarMi
	{
		get
		{
			return false;
		}
	}
	
	protected override bool PkGuidMi
	{
		get
		{
			return false;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "TerritoryID";
		}
	}
	
	public virtual void Sil(string TerritoryId)
	{
		Territories satir = new Territories();
		satir.TerritoryId = TerritoryId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Territories satir)
	{
		satir.TerritoryId = dr.GetString(0);
		satir.TerritoryDescription = dr.GetString(1);
		satir.RegionId = dr.GetInt32(2);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Territories satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@TerritoryID",SqlDbType.NVarChar, satir.TerritoryId,20);
		builder.parameterEkle("@TerritoryDescription",SqlDbType.NChar, satir.TerritoryDescription,50);
		builder.parameterEkle("@RegionID",SqlDbType.Int, satir.RegionId);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Territories	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@TerritoryID",SqlDbType.NVarChar, satir.TerritoryId,20);
		builder.parameterEkle("@TerritoryDescription",SqlDbType.NChar, satir.TerritoryDescription,50);
		builder.parameterEkle("@RegionID",SqlDbType.Int, satir.RegionId);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Territories	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@TerritoryID",SqlDbType.NVarChar, satir.TerritoryId,20);
	}
	public override string DbProviderName
	{
		get
		{
			return "System.Data.SqlClient";
		}
	}
}
}
