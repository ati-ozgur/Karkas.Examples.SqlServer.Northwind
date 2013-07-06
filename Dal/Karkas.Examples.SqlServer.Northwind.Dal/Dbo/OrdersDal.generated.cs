
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
public partial class OrdersDal : BaseDal<Orders>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Orders pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.OrderId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Orders";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT OrderID,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry FROM dbo.Orders";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Orders WHERE OrderID = @OrderID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Orders
			 SET 
			CustomerID = @CustomerID
,EmployeeID = @EmployeeID
,OrderDate = @OrderDate
,RequiredDate = @RequiredDate
,ShippedDate = @ShippedDate
,ShipVia = @ShipVia
,Freight = @Freight
,ShipName = @ShipName
,ShipAddress = @ShipAddress
,ShipCity = @ShipCity
,ShipRegion = @ShipRegion
,ShipPostalCode = @ShipPostalCode
,ShipCountry = @ShipCountry
			
			WHERE 
			 OrderID = @OrderID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Orders 
			 (CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) 
			 VALUES 
						(@CustomerID,@EmployeeID,@OrderDate,@RequiredDate,@ShippedDate,@ShipVia,@Freight,@ShipName,@ShipAddress,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipCountry);SELECT scope_identity();";
		}
	}
	public Orders SorgulaOrderIdIle(int p1)
	{
		List<Orders> liste = new List<Orders>();
		SorguCalistir(liste,String.Format(" OrderID = '{0}'", p1));		
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
			return "OrderID";
		}
	}
	
	public virtual void Sil(int OrderId)
	{
		Orders satir = new Orders();
		satir.OrderId = OrderId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Orders satir)
	{
		satir.OrderId = dr.GetInt32(0);
		if (!dr.IsDBNull(1))
		{
			satir.CustomerId = dr.GetString(1);
		}
		if (!dr.IsDBNull(2))
		{
			satir.EmployeeId = dr.GetInt32(2);
		}
		if (!dr.IsDBNull(3))
		{
			satir.OrderDate = dr.GetDateTime(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.RequiredDate = dr.GetDateTime(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.ShippedDate = dr.GetDateTime(5);
		}
		if (!dr.IsDBNull(6))
		{
			satir.ShipVia = dr.GetInt32(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.Freight = dr.GetDecimal(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.ShipName = dr.GetString(8);
		}
		if (!dr.IsDBNull(9))
		{
			satir.ShipAddress = dr.GetString(9);
		}
		if (!dr.IsDBNull(10))
		{
			satir.ShipCity = dr.GetString(10);
		}
		if (!dr.IsDBNull(11))
		{
			satir.ShipRegion = dr.GetString(11);
		}
		if (!dr.IsDBNull(12))
		{
			satir.ShipPostalCode = dr.GetString(12);
		}
		if (!dr.IsDBNull(13))
		{
			satir.ShipCountry = dr.GetString(13);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Orders satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CustomerID",SqlDbType.NChar, satir.CustomerId,5);
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
		builder.parameterEkle("@OrderDate",SqlDbType.DateTime, satir.OrderDate);
		builder.parameterEkle("@RequiredDate",SqlDbType.DateTime, satir.RequiredDate);
		builder.parameterEkle("@ShippedDate",SqlDbType.DateTime, satir.ShippedDate);
		builder.parameterEkle("@ShipVia",SqlDbType.Int, satir.ShipVia);
		builder.parameterEkle("@Freight",SqlDbType.Money, satir.Freight);
		builder.parameterEkle("@ShipName",SqlDbType.NVarChar, satir.ShipName,40);
		builder.parameterEkle("@ShipAddress",SqlDbType.NVarChar, satir.ShipAddress,60);
		builder.parameterEkle("@ShipCity",SqlDbType.NVarChar, satir.ShipCity,15);
		builder.parameterEkle("@ShipRegion",SqlDbType.NVarChar, satir.ShipRegion,15);
		builder.parameterEkle("@ShipPostalCode",SqlDbType.NVarChar, satir.ShipPostalCode,10);
		builder.parameterEkle("@ShipCountry",SqlDbType.NVarChar, satir.ShipCountry,15);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Orders	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrderID",SqlDbType.Int, satir.OrderId);
		builder.parameterEkle("@CustomerID",SqlDbType.NChar, satir.CustomerId,5);
		builder.parameterEkle("@EmployeeID",SqlDbType.Int, satir.EmployeeId);
		builder.parameterEkle("@OrderDate",SqlDbType.DateTime, satir.OrderDate);
		builder.parameterEkle("@RequiredDate",SqlDbType.DateTime, satir.RequiredDate);
		builder.parameterEkle("@ShippedDate",SqlDbType.DateTime, satir.ShippedDate);
		builder.parameterEkle("@ShipVia",SqlDbType.Int, satir.ShipVia);
		builder.parameterEkle("@Freight",SqlDbType.Money, satir.Freight);
		builder.parameterEkle("@ShipName",SqlDbType.NVarChar, satir.ShipName,40);
		builder.parameterEkle("@ShipAddress",SqlDbType.NVarChar, satir.ShipAddress,60);
		builder.parameterEkle("@ShipCity",SqlDbType.NVarChar, satir.ShipCity,15);
		builder.parameterEkle("@ShipRegion",SqlDbType.NVarChar, satir.ShipRegion,15);
		builder.parameterEkle("@ShipPostalCode",SqlDbType.NVarChar, satir.ShipPostalCode,10);
		builder.parameterEkle("@ShipCountry",SqlDbType.NVarChar, satir.ShipCountry,15);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Orders	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrderID",SqlDbType.Int, satir.OrderId);
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
