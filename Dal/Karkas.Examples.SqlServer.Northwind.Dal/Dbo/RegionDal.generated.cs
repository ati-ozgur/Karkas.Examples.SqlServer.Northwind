
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
public partial class RegionDal : BaseDal<Region>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Region pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Region";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT RegionID,RegionDescription FROM dbo.Region";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Region WHERE RegionID = @RegionID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Region
			 SET 
			RegionDescription = @RegionDescription
			
			WHERE 
			 RegionID = @RegionID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Region 
			 (RegionID,RegionDescription) 
			 VALUES 
						(@RegionID,@RegionDescription)";
		}
	}
	public Region SorgulaRegionIdIle(int p1)
	{
		List<Region> liste = new List<Region>();
		SorguCalistir(liste,String.Format(" RegionID = '{0}'", p1));		
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
			return "RegionID";
		}
	}
	
	public virtual void Sil(int RegionId)
	{
		Region satir = new Region();
		satir.RegionId = RegionId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Region satir)
	{
		satir.RegionId = dr.GetInt32(0);
		satir.RegionDescription = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Region satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@RegionID",SqlDbType.Int, satir.RegionId);
		builder.parameterEkle("@RegionDescription",SqlDbType.NChar, satir.RegionDescription,50);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Region	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@RegionID",SqlDbType.Int, satir.RegionId);
		builder.parameterEkle("@RegionDescription",SqlDbType.NChar, satir.RegionDescription,50);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Region	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@RegionID",SqlDbType.Int, satir.RegionId);
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
