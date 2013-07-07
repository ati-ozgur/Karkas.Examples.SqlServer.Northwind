
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
    public partial class EmployeesDal
    {
        public List<Employees> SorgulaFirstNameIle(string FirstName)
        {
            string filtre = "FirstName LIKE 'A%'";

            List<Employees> list = new List<Employees>();
            SorguCalistir(list, filtre);
            return list;



        }
    }
}
