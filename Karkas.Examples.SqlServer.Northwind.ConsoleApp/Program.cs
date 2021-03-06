﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karkas.Examples.SqlServer.Northwind.Bs.Dbo;
using Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo;

namespace Karkas.Examples.SqlServer.Northwind.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Categories c = new Categories();
            c.CategoryName = "Deneme From Karkas";
            c.Description = "Desc";

            CategoriesBs bs = new CategoriesBs();
            bs.Ekle(c);

            Console.WriteLine(c.CategoryId);


            

        }

        private static void SorgulaJoinOrnek()
        {
            CustomersBs bs = new CustomersBs();
            string customerId = "BERGS";
            DataTable dt = bs.SorgulaCustomerOrdersEmpBilgileriniGetir(customerId);

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["CustomerID"].ToString() + " " + item["EmployeeID"].ToString() + " " + item["EmpLastName"].ToString());
            }
        }

        private static void customerListesiniEkranaYaz(List<Customers> list)
        {
            foreach (Customers customer in list)
            {
                Console.WriteLine(customer.CustomerId + " " + customer.CompanyName);
            }
        }

        private static void SorgulaDetayTabloGetir_HataliCalisiyor()
        {
            CustomersBs bs = new CustomersBs();

            var list = bs.SorgulaDetayTabloGetir<Orders>("ALFKI");

            Console.WriteLine(list.GetType());
        }

        private static void silOrnek()
        {
            CustomersBs bs = new CustomersBs();

            bs.Sil("DENE6");
        }

        private static void guncelleOrnek(CustomersBs bs)
        {
            for (int i = 1; i < 10; i++)
            {
                string pk = "DENE" + i;
                Customers c = bs.SorgulaCustomerIdIle(pk);
                c.City = "Deneme Sehir" + i;
                bs.Guncelle(c);
                Console.WriteLine("Customer " + pk + " - Guncellendi.");

            }
        }

        private static Customers CustomersPkSorgula(CustomersBs bs)
        {
            Customers veritabanindan = bs.SorgulaCustomerIdIle("DENE1");
            Console.WriteLine(veritabanindan.CompanyName);
            Console.WriteLine(veritabanindan.CustomerId);
            return veritabanindan;
        }

        private static void CustomerSorgulaHepsiniGetir()
        {
            CustomersBs bs = new CustomersBs();
            List<Customers> customersListesi = bs.SorgulaHepsiniGetir();
            foreach (Customers customer in customersListesi)
            {
                Console.WriteLine(customer.CustomerId + " " + customer.CompanyName);
            }
        }

        private static void CustomersEkleOrnek1(CustomersBs bs)
        {
            Customers yeni = new Customers();
            yeni.CustomerId = "DENE1";
            yeni.CompanyName = "Atilla Şirket 1";
            bs.Ekle(yeni);
        }

        private static void selectOrnekRegion()
        {
            RegionBs bs = new RegionBs();

            var list = bs.SorgulaHepsiniGetir();
            foreach (Region item in list)
            {
                Console.WriteLine(item.RegionId + " " + item.RegionDescription);
            }

        }
    }
}
