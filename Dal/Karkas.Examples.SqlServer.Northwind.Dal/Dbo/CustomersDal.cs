
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo;


namespace Karkas.Examples.SqlServer.Northwind.Dal.Dbo
{
    public partial class CustomersDal
    {
        public List<Customers> SorgulaCountryVeCityIle(string country, string city)
        {
            List<Customers> liste = new List<Customers>();
            string filtre = @"Country LIKE @Country + '%'
                    AND
                    City LIKE @City + '%'";
            ParameterBuilder builder = this.getParameterBuilder();
            builder.parameterEkle("@Country", SqlDbType.VarChar, country);
            builder.parameterEkle("@City", SqlDbType.VarChar, city);
            SorguCalistir(liste, filtre,builder.GetParameterArray());
            return liste;


        }

        private const string SQL_SorgulaCustomerOrdersEmpBilgileriniGetir = @"
SELECT     C.CustomerID, C.CompanyName, C.ContactName, C.Country, C.City, O.OrderID, O.OrderDate, O.RequiredDate, O.ShipCity, E.EmployeeID, 
                      E.LastName AS EmpLastName, E.FirstName AS EmpFirstName
FROM         Customers AS C INNER JOIN
                      Orders AS O ON C.CustomerID = O.CustomerID INNER JOIN
                      Employees AS E ON O.EmployeeID = E.EmployeeID
WHERE
C.CustomerID = @CustomerID
";

        public DataTable SorgulaCustomerOrdersEmpBilgileriniGetir(string customerId)
        {
            AdoTemplate template = this.getNewAdoTemplate();
            ParameterBuilder builder = this.getParameterBuilder();
            builder.parameterEkle("@CustomerID", SqlDbType.NChar, customerId, 5);

            return template.DataTableOlustur(SQL_SorgulaCustomerOrdersEmpBilgileriniGetir, builder.GetParameterArray());

        }
    }
}
