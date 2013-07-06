
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo;


namespace Karkas.Examples.SqlServer.Northwind.Dal.Dbo
{
public partial class EmployeeTerritoriesDal : BaseDal<EmployeeTerritories>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(EmployeeTerritories pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.EmployeeTerritories";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT EmployeeID,TerritoryID FROM dbo.EmployeeTerritories";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.EmployeeTerritories WHERE EmployeeID = @EmployeeID AND TerritoryID = @TerritoryID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.EmployeeTerritories
			 SET 
						
			WHERE 
			 EmployeeID = @EmployeeID
 AND TerritoryID = @TerritoryID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.EmployeeTerritories 
			 (EmployeeID,TerritoryID) 
			 VALUES 
						(@EmployeeID,@TerritoryID)";
		}
	}
	public EmployeeTerritories SorgulaTerritoryIdIle(string p1)
	{
		List<EmployeeTerritories> liste = new List<EmployeeTerritories>();
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
	
	protected override void ProcessRow(IDataReader dr, EmployeeTerritories satir)
	{
		satir.EmployeeId = dr.GetInt32(0);
		satir.TerritoryId = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, EmployeeTerritories satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
		builder.parameterEkle("@TerritoryID",SqlDbType.NVarChar, satir.TerritoryId,20);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	EmployeeTerritories	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
		builder.parameterEkle("@TerritoryID",SqlDbType.NVarChar, satir.TerritoryId,20);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	EmployeeTerritories	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
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
