
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
	public partial class CustomerDemographicsBs : BaseBs<CustomerDemographics, CustomerDemographicsDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Northwind";
			}
		}
		public void Sil(string pCustomerTypeId)
		{
			dal.Sil( pCustomerTypeId);
		}
		public CustomerDemographics SorgulaCustomerTypeIdIle(string p1)
		{
			return dal.SorgulaCustomerTypeIdIle(p1);
		}
	}
}
