
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
public partial class ProductsDal : BaseDal<Products>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Products pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.ProductId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Products";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued FROM dbo.Products";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Products WHERE ProductID = @ProductID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Products
			 SET 
			ProductName = @ProductName
,SupplierID = @SupplierID
,CategoryID = @CategoryID
,QuantityPerUnit = @QuantityPerUnit
,UnitPrice = @UnitPrice
,UnitsInStock = @UnitsInStock
,UnitsOnOrder = @UnitsOnOrder
,ReorderLevel = @ReorderLevel
,Discontinued = @Discontinued
			
			WHERE 
			 ProductID = @ProductID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Products 
			 (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) 
			 VALUES 
						(@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued);SELECT scope_identity();";
		}
	}
	public Products SorgulaProductIdIle(int p1)
	{
		List<Products> liste = new List<Products>();
		SorguCalistir(liste,String.Format(" ProductID = '{0}'", p1));		
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
			return "ProductID";
		}
	}
	
	public virtual void Sil(int ProductId)
	{
		Products satir = new Products();
		satir.ProductId = ProductId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Products satir)
	{
		satir.ProductId = dr.GetInt32(0);
		satir.ProductName = dr.GetString(1);
		if (!dr.IsDBNull(2))
		{
			satir.SupplierId = dr.GetInt32(2);
		}
		if (!dr.IsDBNull(3))
		{
			satir.CategoryId = dr.GetInt32(3);
		}
		if (!dr.IsDBNull(4))
		{
			satir.QuantityPerUnit = dr.GetString(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.UnitPrice = dr.GetDecimal(5);
		}
		if (!dr.IsDBNull(6))
		{
			satir.UnitsInStock = dr.GetInt16(6);
		}
		if (!dr.IsDBNull(7))
		{
			satir.UnitsOnOrder = dr.GetInt16(7);
		}
		if (!dr.IsDBNull(8))
		{
			satir.ReorderLevel = dr.GetInt16(8);
		}
		satir.Discontinued = dr.GetBoolean(9);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Products satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ProductName",SqlDbType.NVarChar, satir.ProductName,40);
		builder.parameterEkle("@SupplierID",SqlDbType.Int, satir.SupplierId);
		builder.parameterEkle("@CategoryID",SqlDbType.Int, satir.CategoryId);
		builder.parameterEkle("@QuantityPerUnit",SqlDbType.NVarChar, satir.QuantityPerUnit,20);
		builder.parameterEkle("@UnitPrice",SqlDbType.Money, satir.UnitPrice);
		builder.parameterEkle("@UnitsInStock",SqlDbType.SmallInt, satir.UnitsInStock);
		builder.parameterEkle("@UnitsOnOrder",SqlDbType.SmallInt, satir.UnitsOnOrder);
		builder.parameterEkle("@ReorderLevel",SqlDbType.SmallInt, satir.ReorderLevel);
		builder.parameterEkle("@Discontinued",SqlDbType.Bit, satir.Discontinued);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Products	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ProductID",SqlDbType.Int, satir.ProductId);
		builder.parameterEkle("@ProductName",SqlDbType.NVarChar, satir.ProductName,40);
		builder.parameterEkle("@SupplierID",SqlDbType.Int, satir.SupplierId);
		builder.parameterEkle("@CategoryID",SqlDbType.Int, satir.CategoryId);
		builder.parameterEkle("@QuantityPerUnit",SqlDbType.NVarChar, satir.QuantityPerUnit,20);
		builder.parameterEkle("@UnitPrice",SqlDbType.Money, satir.UnitPrice);
		builder.parameterEkle("@UnitsInStock",SqlDbType.SmallInt, satir.UnitsInStock);
		builder.parameterEkle("@UnitsOnOrder",SqlDbType.SmallInt, satir.UnitsOnOrder);
		builder.parameterEkle("@ReorderLevel",SqlDbType.SmallInt, satir.ReorderLevel);
		builder.parameterEkle("@Discontinued",SqlDbType.Bit, satir.Discontinued);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Products	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@ProductID",SqlDbType.Int, satir.ProductId);
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
