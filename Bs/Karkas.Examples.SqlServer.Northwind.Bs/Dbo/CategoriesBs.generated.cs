﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo;
using Karkas.Examples.SqlServer.Northwind.Dal.Dbo;


namespace Karkas.Examples.SqlServer.Northwind.Bs.Dbo
{
	public partial class CategoriesBs : BaseBs<Categories, CategoriesDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
		public void Sil(int pCategoryId)
		{
			dal.Sil( pCategoryId);
		}
		public Categories SorgulaCategoryIdIle(int p1)
		{
			return dal.SorgulaCategoryIdIle(p1);
		}
	}
}
