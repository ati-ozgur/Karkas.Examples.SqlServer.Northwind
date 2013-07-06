
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
	public partial class CustomersBs : BaseBs<Customers, CustomersDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
		public void Sil(string pCustomerId)
		{
			dal.Sil( pCustomerId);
		}
		public Customers SorgulaCustomerIdIle(string p1)
		{
			return dal.SorgulaCustomerIdIle(p1);
		}
	}
}
