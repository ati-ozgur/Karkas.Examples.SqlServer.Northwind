
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
	public partial class SuppliersBs : BaseBs<Suppliers, SuppliersDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
		public void Sil(int pSupplierId)
		{
			dal.Sil( pSupplierId);
		}
		public Suppliers SorgulaSupplierIdIle(int p1)
		{
			return dal.SorgulaSupplierIdIle(p1);
		}
	}
}
