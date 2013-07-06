
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
	public partial class OrderDetailsBs : BaseBs<OrderDetails, OrderDetailsDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
	}
}
