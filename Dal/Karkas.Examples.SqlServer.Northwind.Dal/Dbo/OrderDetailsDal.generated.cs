
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
public partial class OrderDetailsDal : BaseDal<OrderDetails>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(OrderDetails pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Order Details";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT OrderID,ProductID,UnitPrice,Quantity,Discount FROM dbo.Order Details";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Order Details WHERE OrderID = @OrderID AND ProductID = @ProductID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Order Details
			 SET 
			UnitPrice = @UnitPrice
,Quantity = @Quantity
,Discount = @Discount
			
			WHERE 
			 OrderID = @OrderID
 AND ProductID = @ProductID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Order Details 
			 (OrderID,ProductID,UnitPrice,Quantity,Discount) 
			 VALUES 
						(@OrderID,@ProductID,@UnitPrice,@Quantity,@Discount)";
		}
	}
	public OrderDetails SorgulaProductIdIle(int p1)
	{
		List<OrderDetails> liste = new List<OrderDetails>();
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
			return "ProductID";
		}
	}
	
	protected override void ProcessRow(IDataReader dr, OrderDetails satir)
	{
		satir.OrderId = dr.GetInt32(0);
		satir.ProductId = dr.GetInt32(1);
		satir.UnitPrice = dr.GetDecimal(2);
		satir.Quantity = dr.GetInt16(3);
		satir.Discount = dr.GetFloat(4);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, OrderDetails satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrderID",SqlDbType.Int, satir.OrderId);
		builder.parameterEkle("@ProductID",SqlDbType.Int, satir.ProductId);
		builder.parameterEkle("@UnitPrice",SqlDbType.Money, satir.UnitPrice);
		builder.parameterEkle("@Quantity",SqlDbType.SmallInt, satir.Quantity);
		builder.parameterEkle("@Discount",SqlDbType.Real, satir.Discount);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	OrderDetails	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrderID",SqlDbType.Int, satir.OrderId);
		builder.parameterEkle("@ProductID",SqlDbType.Int, satir.ProductId);
		builder.parameterEkle("@UnitPrice",SqlDbType.Money, satir.UnitPrice);
		builder.parameterEkle("@Quantity",SqlDbType.SmallInt, satir.Quantity);
		builder.parameterEkle("@Discount",SqlDbType.Real, satir.Discount);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	OrderDetails	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@OrderID",SqlDbType.Int, satir.OrderId);
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
