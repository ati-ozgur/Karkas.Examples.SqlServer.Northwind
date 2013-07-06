
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
        public List<Customers> SorgulaCountryVeCityIle(string country, string city)
        {
            return dal.SorgulaCountryVeCityIle(country, city);
        }

        public DataTable SorgulaCustomerOrdersEmpBilgileriniGetir(string customerId)
        {
            return dal.SorgulaCustomerOrdersEmpBilgileriniGetir(customerId);
        }
    }
}
