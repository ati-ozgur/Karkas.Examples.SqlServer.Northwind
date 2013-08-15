
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
public partial class CategoriesDal : BaseDal<Categories>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Northwind";
		}
	}
	protected override void identityKolonDegeriniSetle(Categories pTypeLibrary,long pIdentityKolonValue)
	{
		pTypeLibrary.CategoryId = (int )pIdentityKolonValue;
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM dbo.Categories";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT CategoryID,CategoryName,Description,Picture FROM dbo.Categories";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM dbo.Categories WHERE CategoryID = @CategoryID ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE dbo.Categories
			 SET 
			CategoryName = @CategoryName
,Description = @Description
,Picture = @Picture
			
			WHERE 
			 CategoryID = @CategoryID
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO dbo.Categories 
			 (CategoryName,Description,Picture) 
			 VALUES 
						(@CategoryName,@Description,@Picture);SELECT scope_identity();";
		}
	}
	public Categories SorgulaCategoryIdIle(int p1)
	{
		List<Categories> liste = new List<Categories>();
		SorguCalistir(liste,String.Format(" CategoryID = '{0}'", p1));		
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
			return "CategoryID";
		}
	}
	
	public virtual void Sil(int CategoryId)
	{
		Categories satir = new Categories();
		satir.CategoryId = CategoryId;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Categories satir)
	{
		satir.CategoryId = dr.GetInt32(0);
		satir.CategoryName = dr.GetString(1);
		if (!dr.IsDBNull(2))
		{
			satir.Description = dr.GetString(2);
		}
		if (!dr.IsDBNull(3))
		{
			satir.Picture = (Byte[])dr.GetValue(3);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Categories satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CategoryName",SqlDbType.NVarChar, satir.CategoryName,15);
		builder.parameterEkle("@Description",SqlDbType.NText, satir.Description);
		builder.parameterEkle("@Picture",SqlDbType.Image, satir.Picture);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Categories	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CategoryID",SqlDbType.Int, satir.CategoryId);
		builder.parameterEkle("@CategoryName",SqlDbType.NVarChar, satir.CategoryName,15);
		builder.parameterEkle("@Description",SqlDbType.NText, satir.Description);
		builder.parameterEkle("@Picture",SqlDbType.Image, satir.Picture);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Categories	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@CategoryID",SqlDbType.Int, satir.CategoryId);
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
