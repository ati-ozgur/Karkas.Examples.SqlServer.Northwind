
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
public partial class CustomerDemographicsDal : BaseDal<CustomerDemographics>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(CustomerDemographics pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.CustomerDemographics";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT CustomerTypeID,CustomerDesc FROM dbo.CustomerDemographics";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.CustomerDemographics WHERE CustomerTypeID = @CustomerTypeID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.CustomerDemographics
			 SET 
			CustomerDesc = @CustomerDesc
			
			WHERE 
			 CustomerTypeID = @CustomerTypeID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.CustomerDemographics 
			 (CustomerTypeID,CustomerDesc) 
			 VALUES 
						(@CustomerTypeID,@CustomerDesc)";
		}
	}
	public CustomerDemographics SorgulaCustomerTypeIdIle(string p1)
	{
		List<CustomerDemographics> liste = new List<CustomerDemographics>();
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
	
	public virtual void Sil(string CustomerTypeId)
	{
		CustomerDemographics satir = new CustomerDemographics();
		satir.CustomerTypeId = CustomerTypeId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, CustomerDemographics satir)
	{
		satir.CustomerTypeId = dr.GetString(0);
		if (!dr.IsDBNull(1))
		{
			satir.CustomerDesc = dr.GetString(1);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, CustomerDemographics satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CustomerTypeID",SqlDbType.NChar, satir.CustomerTypeId,10);
		builder.parameterEkle("@CustomerDesc",SqlDbType.NText, satir.CustomerDesc);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	CustomerDemographics	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CustomerTypeID",SqlDbType.NChar, satir.CustomerTypeId,10);
		builder.parameterEkle("@CustomerDesc",SqlDbType.NText, satir.CustomerDesc);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	CustomerDemographics	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
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
