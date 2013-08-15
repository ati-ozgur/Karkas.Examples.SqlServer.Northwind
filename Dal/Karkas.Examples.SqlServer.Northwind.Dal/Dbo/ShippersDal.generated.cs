
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
public partial class ShippersDal : BaseDal<Shippers>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Shippers pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.ShipperId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Shippers";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT ShipperID,CompanyName,Phone FROM dbo.Shippers";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Shippers WHERE ShipperID = @ShipperID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Shippers
			 SET 
			CompanyName = @CompanyName
,Phone = @Phone
			
			WHERE 
			 ShipperID = @ShipperID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Shippers 
			 (CompanyName,Phone) 
			 VALUES 
						(@CompanyName,@Phone);SELECT scope_identity();";
		}
	}
	public Shippers SorgulaShipperIdIle(int p1)
	{
		List<Shippers> liste = new List<Shippers>();
		SorguCalistir(liste,String.Format(" ShipperID = '{0}'", p1));		
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
			return true;
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
			return "ShipperID";
		}
	}
	
	public virtual void Sil(int ShipperId)
	{
		Shippers satir = new Shippers();
		satir.ShipperId = ShipperId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Shippers satir)
	{
		satir.ShipperId = dr.GetInt32(0);
		satir.CompanyName = dr.GetString(1);
		if (!dr.IsDBNull(2))
		{
			satir.Phone = dr.GetString(2);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Shippers satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CompanyName",SqlDbType.NVarChar, satir.CompanyName,40);
		builder.parameterEkle("@Phone",SqlDbType.NVarChar, satir.Phone,24);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Shippers	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ShipperID",SqlDbType.Int, satir.ShipperId);
		builder.parameterEkle("@CompanyName",SqlDbType.NVarChar, satir.CompanyName,40);
		builder.parameterEkle("@Phone",SqlDbType.NVarChar, satir.Phone,24);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Shippers	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ShipperID",SqlDbType.Int, satir.ShipperId);
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
