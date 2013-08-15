
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo;
using Karkas.Examples.SqlServer.Northwind.Dal.Dbo;


namespace Karkas.Examples.SqlServer.Northwind.Bs.Dbo
{
	public partial class ProductsBs : BaseBs<Products, ProductsDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
		public void Sil(int pProductId)
		{
			dal.Sil( pProductId);
		}
		public Products SorgulaProductIdIle(int p1)
		{
			return dal.SorgulaProductIdIle(p1);
		}
	}
}
