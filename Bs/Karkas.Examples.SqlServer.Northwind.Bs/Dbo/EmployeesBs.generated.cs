
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
	public partial class EmployeesBs : BaseBs<Employees, EmployeesDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
		public void Sil(int pEmployeeId)
		{
			dal.Sil( pEmployeeId);
		}
		public Employees SorgulaEmployeeIdIle(int p1)
		{
			return dal.SorgulaEmployeeIdIle(p1);
		}
	}
}
