
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
public partial class SuppliersDal : BaseDal<Suppliers>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Suppliers pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.SupplierId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Suppliers";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT SupplierID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage FROM dbo.Suppliers";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Suppliers WHERE SupplierID = @SupplierID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Suppliers
			 SET 
			CompanyName = @CompanyName
,ContactName = @ContactName
,ContactTitle = @ContactTitle
,Address = @Address
,City = @City
,Region = @Region
,PostalCode = @PostalCode
,Country = @Country
,Phone = @Phone
,Fax = @Fax
,HomePage = @HomePage
			
			WHERE 
			 SupplierID = @SupplierID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Suppliers 
			 (CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage) 
			 VALUES 
						(@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax,@HomePage);SELECT scope_identity();";
		}
	}
	public Suppliers SorgulaSupplierIdIle(int p1)
	{
		List<Suppliers> liste = new List<Suppliers>();
		SorguCalistir(liste,String.Format(" SupplierID = '{0}'", p1));		
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
			return "SupplierID";
		}
	}
	
	public virtual void Sil(int SupplierId)
	{
		Suppliers satir = new Suppliers();
		satir.SupplierId = SupplierId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Suppliers satir)
	{
		satir.SupplierId = dr.GetInt32(0);
		satir.CompanyName = dr.GetString(1);
		if (!dr.IsDBNull(2))
		{
			satir.ContactName = dr.GetString(2);
		}
		if (!dr.IsDBNull(3))
		{
			satir.ContactTitle = dr.GetString(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.Address = dr.GetString(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.City = dr.GetString(5);
		}
		if (!dr.IsDBNull(6))
		{
			satir.Region = dr.GetString(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.PostalCode = dr.GetString(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.Country = dr.GetString(8);
		}
		if (!dr.IsDBNull(9))
		{
			satir.Phone = dr.GetString(9);
		}
		if (!dr.IsDBNull(10))
		{
			satir.Fax = dr.GetString(10);
		}
		if (!dr.IsDBNull(11))
		{
			satir.HomePage = dr.GetString(11);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Suppliers satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CompanyName",SqlDbType.NVarChar, satir.CompanyName,40);
		builder.parameterEkle("@ContactName",SqlDbType.NVarChar, satir.ContactName,30);
		builder.parameterEkle("@ContactTitle",SqlDbType.NVarChar, satir.ContactTitle,30);
		builder.parameterEkle("@Address",SqlDbType.NVarChar, satir.Address,60);
		builder.parameterEkle("@City",SqlDbType.NVarChar, satir.City,15);
		builder.parameterEkle("@Region",SqlDbType.NVarChar, satir.Region,15);
		builder.parameterEkle("@PostalCode",SqlDbType.NVarChar, satir.PostalCode,10);
		builder.parameterEkle("@Country",SqlDbType.NVarChar, satir.Country,15);
		builder.parameterEkle("@Phone",SqlDbType.NVarChar, satir.Phone,24);
		builder.parameterEkle("@Fax",SqlDbType.NVarChar, satir.Fax,24);
		builder.parameterEkle("@HomePage",SqlDbType.NText, satir.HomePage);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Suppliers	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@SupplierID",SqlDbType.Int, satir.SupplierId);
		builder.parameterEkle("@CompanyName",SqlDbType.NVarChar, satir.CompanyName,40);
		builder.parameterEkle("@ContactName",SqlDbType.NVarChar, satir.ContactName,30);
		builder.parameterEkle("@ContactTitle",SqlDbType.NVarChar, satir.ContactTitle,30);
		builder.parameterEkle("@Address",SqlDbType.NVarChar, satir.Address,60);
		builder.parameterEkle("@City",SqlDbType.NVarChar, satir.City,15);
		builder.parameterEkle("@Region",SqlDbType.NVarChar, satir.Region,15);
		builder.parameterEkle("@PostalCode",SqlDbType.NVarChar, satir.PostalCode,10);
		builder.parameterEkle("@Country",SqlDbType.NVarChar, satir.Country,15);
		builder.parameterEkle("@Phone",SqlDbType.NVarChar, satir.Phone,24);
		builder.parameterEkle("@Fax",SqlDbType.NVarChar, satir.Fax,24);
		builder.parameterEkle("@HomePage",SqlDbType.NText, satir.HomePage);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Suppliers	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@SupplierID",SqlDbType.Int, satir.SupplierId);
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
