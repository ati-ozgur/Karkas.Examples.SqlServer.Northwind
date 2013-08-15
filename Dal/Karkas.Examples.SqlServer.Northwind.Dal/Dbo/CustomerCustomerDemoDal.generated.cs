
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
public partial class CustomerCustomerDemoDal : BaseDal<CustomerCustomerDemo>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(CustomerCustomerDemo pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.CustomerCustomerDemo";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT CustomerID,CustomerTypeID FROM dbo.CustomerCustomerDemo";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.CustomerCustomerDemo WHERE CustomerID = @CustomerID AND CustomerTypeID = @CustomerTypeID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.CustomerCustomerDemo
			 SET 
						
			WHERE 
			 CustomerID = @CustomerID
 AND CustomerTypeID = @CustomerTypeID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.CustomerCustomerDemo 
			 (CustomerID,CustomerTypeID) 
			 VALUES 
						(@CustomerID,@CustomerTypeID)";
		}
	}
	public CustomerCustomerDemo SorgulaCustomerTypeIdIle(string p1)
	{
		List<CustomerCustomerDemo> liste = new List<CustomerCustomerDemo>();
		SorguCalistir(liste,String.Format(" CustomerTypeID = '{0}'", p1));		
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
			return "CustomerTypeID";
		}
	}
	
	protected override void ProcessRow(IDataReader dr, CustomerCustomerDemo satir)
	{
		satir.CustomerId = dr.GetString(0);
		satir.CustomerTypeId = dr.GetString(1);
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, CustomerCustomerDemo satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CustomerID",SqlDbType.NChar, satir.CustomerId,5);
		builder.parameterEkle("@CustomerTypeID",SqlDbType.NChar, satir.CustomerTypeId,10);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	CustomerCustomerDemo	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CustomerID",SqlDbType.NChar, satir.CustomerId,5);
		builder.parameterEkle("@CustomerTypeID",SqlDbType.NChar, satir.CustomerTypeId,10);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	CustomerCustomerDemo	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CustomerID",SqlDbType.NChar, satir.CustomerId,5);
		builder.parameterEkle("@CustomerTypeID",SqlDbType.NChar, satir.CustomerTypeId,10);
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
