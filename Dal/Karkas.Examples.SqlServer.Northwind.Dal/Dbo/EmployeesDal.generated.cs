
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
public partial class EmployeesDal : BaseDal<Employees>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Employees pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.EmployeeId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Employees";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath FROM dbo.Employees";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Employees WHERE EmployeeID = @EmployeeID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Employees
			 SET 
			LastName = @LastName
,FirstName = @FirstName
,Title = @Title
,TitleOfCourtesy = @TitleOfCourtesy
,BirthDate = @BirthDate
,HireDate = @HireDate
,Address = @Address
,City = @City
,Region = @Region
,PostalCode = @PostalCode
,Country = @Country
,HomePhone = @HomePhone
,Extension = @Extension
,Photo = @Photo
,Notes = @Notes
,ReportsTo = @ReportsTo
,PhotoPath = @PhotoPath
			
			WHERE 
			 EmployeeID = @EmployeeID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Employees 
			 (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath) 
			 VALUES 
						(@LastName,@FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,@City,@Region,@PostalCode,@Country,@HomePhone,@Extension,@Photo,@Notes,@ReportsTo,@PhotoPath);SELECT scope_identity();";
		}
	}
	public Employees SorgulaEmployeeIdIle(int p1)
	{
		List<Employees> liste = new List<Employees>();
		SorguCalistir(liste,String.Format(" EmployeeID = '{0}'", p1));		
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
			return "EmployeeID";
		}
	}
	
	public virtual void Sil(int EmployeeId)
	{
		Employees satir = new Employees();
		satir.EmployeeId = EmployeeId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Employees satir)
	{
		satir.EmployeeId = dr.GetInt32(0);
		satir.LastName = dr.GetString(1);
		satir.FirstName = dr.GetString(2);
		if (!dr.IsDBNull(3))
		{
			satir.Title = dr.GetString(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.TitleOfCourtesy = dr.GetString(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.BirthDate = dr.GetDateTime(5);
		}
		if (!dr.IsDBNull(6))
		{
			satir.HireDate = dr.GetDateTime(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.Address = dr.GetString(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.City = dr.GetString(8);
		}
		if (!dr.IsDBNull(9))
		{
			satir.Region = dr.GetString(9);
		}
		if (!dr.IsDBNull(10))
		{
			satir.PostalCode = dr.GetString(10);
		}
		if (!dr.IsDBNull(11))
		{
			satir.Country = dr.GetString(11);
		}
		if (!dr.IsDBNull(12))
		{
			satir.HomePhone = dr.GetString(12);
		}
		if (!dr.IsDBNull(13))
		{
			satir.Extension = dr.GetString(13);
		}
		if (!dr.IsDBNull(14))
		{
			satir.Photo = (Byte[])dr.GetValue(14);
		}
		if (!dr.IsDBNull(15))
		{
			satir.Notes = dr.GetString(15);
		}
		if (!dr.IsDBNull(16))
		{
			satir.ReportsTo = dr.GetInt32(16);
		}
		if (!dr.IsDBNull(17))
		{
			satir.PhotoPath = dr.GetString(17);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Employees satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@LastName",SqlDbType.NVarChar, satir.LastName,20);
		builder.parameterEkle("@FirstName",SqlDbType.NVarChar, satir.FirstName,10);
		builder.parameterEkle("@Title",SqlDbType.NVarChar, satir.Title,30);
		builder.parameterEkle("@TitleOfCourtesy",SqlDbType.NVarChar, satir.TitleOfCourtesy,25);
		builder.parameterEkle("@BirthDate",SqlDbType.DateTime, satir.BirthDate);
		builder.parameterEkle("@HireDate",SqlDbType.DateTime, satir.HireDate);
		builder.parameterEkle("@Address",SqlDbType.NVarChar, satir.Address,60);
		builder.parameterEkle("@City",SqlDbType.NVarChar, satir.City,15);
		builder.parameterEkle("@Region",SqlDbType.NVarChar, satir.Region,15);
		builder.parameterEkle("@PostalCode",SqlDbType.NVarChar, satir.PostalCode,10);
		builder.parameterEkle("@Country",SqlDbType.NVarChar, satir.Country,15);
		builder.parameterEkle("@HomePhone",SqlDbType.NVarChar, satir.HomePhone,24);
		builder.parameterEkle("@Extension",SqlDbType.NVarChar, satir.Extension,4);
		builder.parameterEkle("@Photo",SqlDbType.Image, satir.Photo);
		builder.parameterEkle("@Notes",SqlDbType.NText, satir.Notes);
		builder.parameterEkle("@ReportsTo",SqlDbType.Int, satir.ReportsTo);
		builder.parameterEkle("@PhotoPath",SqlDbType.NVarChar, satir.PhotoPath,255);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Employees	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
		builder.parameterEkle("@LastName",SqlDbType.NVarChar, satir.LastName,20);
		builder.parameterEkle("@FirstName",SqlDbType.NVarChar, satir.FirstName,10);
		builder.parameterEkle("@Title",SqlDbType.NVarChar, satir.Title,30);
		builder.parameterEkle("@TitleOfCourtesy",SqlDbType.NVarChar, satir.TitleOfCourtesy,25);
		builder.parameterEkle("@BirthDate",SqlDbType.DateTime, satir.BirthDate);
		builder.parameterEkle("@HireDate",SqlDbType.DateTime, satir.HireDate);
		builder.parameterEkle("@Address",SqlDbType.NVarChar, satir.Address,60);
		builder.parameterEkle("@City",SqlDbType.NVarChar, satir.City,15);
		builder.parameterEkle("@Region",SqlDbType.NVarChar, satir.Region,15);
		builder.parameterEkle("@PostalCode",SqlDbType.NVarChar, satir.PostalCode,10);
		builder.parameterEkle("@Country",SqlDbType.NVarChar, satir.Country,15);
		builder.parameterEkle("@HomePhone",SqlDbType.NVarChar, satir.HomePhone,24);
		builder.parameterEkle("@Extension",SqlDbType.NVarChar, satir.Extension,4);
		builder.parameterEkle("@Photo",SqlDbType.Image, satir.Photo);
		builder.parameterEkle("@Notes",SqlDbType.NText, satir.Notes);
		builder.parameterEkle("@ReportsTo",SqlDbType.Int, satir.ReportsTo);
		builder.parameterEkle("@PhotoPath",SqlDbType.NVarChar, satir.PhotoPath,255);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Employees	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
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
