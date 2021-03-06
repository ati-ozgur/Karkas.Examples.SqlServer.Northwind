﻿using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using Karkas.Core.Onaylama;
using Karkas.Core.Onaylama.ForPonos;
using System.ComponentModel.DataAnnotations;

namespace Karkas.Examples.SqlServer.Northwind.TypeLibrary.Dbo
{
	[Serializable]
	[DebuggerDisplay("EmployeeId = {EmployeeId}ReportsTo = {ReportsTo}")]
	public partial class 	Employees: BaseTypeLibrary
	{
		private int employeeId;
		private string lastName;
		private string firstName;
		private string title;
		private string titleOfCourtesy;
		private Nullable<DateTime> birthDate;
		private Nullable<DateTime> hireDate;
		private string address;
		private string city;
		private string region;
		private string postalCode;
		private string country;
		private string homePhone;
		private string extension;
		private byte[] photo;
		private string notes;
		private Nullable<int> reportsTo;
		private string photoPath;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int EmployeeId
		{
			[DebuggerStepThrough]
			get
			{
				return employeeId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (employeeId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				employeeId = value;
			}
		}

		[StringLength(20)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string LastName
		{
			[DebuggerStepThrough]
			get
			{
				return lastName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (lastName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				lastName = value;
			}
		}

		[StringLength(10)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string FirstName
		{
			[DebuggerStepThrough]
			get
			{
				return firstName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (firstName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				firstName = value;
			}
		}

		[StringLength(30)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Title
		{
			[DebuggerStepThrough]
			get
			{
				return title;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (title!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				title = value;
			}
		}

		[StringLength(25)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TitleOfCourtesy
		{
			[DebuggerStepThrough]
			get
			{
				return titleOfCourtesy;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (titleOfCourtesy!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				titleOfCourtesy = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> BirthDate
		{
			[DebuggerStepThrough]
			get
			{
				return birthDate;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (birthDate!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				birthDate = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<DateTime> HireDate
		{
			[DebuggerStepThrough]
			get
			{
				return hireDate;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (hireDate!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				hireDate = value;
			}
		}

		[StringLength(60)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Address
		{
			[DebuggerStepThrough]
			get
			{
				return address;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (address!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				address = value;
			}
		}

		[StringLength(15)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string City
		{
			[DebuggerStepThrough]
			get
			{
				return city;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (city!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				city = value;
			}
		}

		[StringLength(15)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Region
		{
			[DebuggerStepThrough]
			get
			{
				return region;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (region!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				region = value;
			}
		}

		[StringLength(10)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string PostalCode
		{
			[DebuggerStepThrough]
			get
			{
				return postalCode;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (postalCode!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				postalCode = value;
			}
		}

		[StringLength(15)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Country
		{
			[DebuggerStepThrough]
			get
			{
				return country;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (country!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				country = value;
			}
		}

		[StringLength(24)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string HomePhone
		{
			[DebuggerStepThrough]
			get
			{
				return homePhone;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (homePhone!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				homePhone = value;
			}
		}

		[StringLength(4)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Extension
		{
			[DebuggerStepThrough]
			get
			{
				return extension;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (extension!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				extension = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] Photo
		{
			[DebuggerStepThrough]
			get
			{
				return photo;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (photo!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				photo = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Notes
		{
			[DebuggerStepThrough]
			get
			{
				return notes;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (notes!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				notes = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<int> ReportsTo
		{
			[DebuggerStepThrough]
			get
			{
				return reportsTo;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (reportsTo!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				reportsTo = value;
			}
		}

		[StringLength(255)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string PhotoPath
		{
			[DebuggerStepThrough]
			get
			{
				return photoPath;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (photoPath!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				photoPath = value;
			}
		}

		public Employees ShallowCopy()
		{
			Employees obj = new Employees();
			obj.employeeId = employeeId;
			obj.lastName = lastName;
			obj.firstName = firstName;
			obj.title = title;
			obj.titleOfCourtesy = titleOfCourtesy;
			obj.birthDate = birthDate;
			obj.hireDate = hireDate;
			obj.address = address;
			obj.city = city;
			obj.region = region;
			obj.postalCode = postalCode;
			obj.country = country;
			obj.homePhone = homePhone;
			obj.extension = extension;
			obj.photo = photo;
			obj.notes = notes;
			obj.reportsTo = reportsTo;
			obj.photoPath = photoPath;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string EmployeeId = "EmployeeID";
			public const string LastName = "LastName";
			public const string FirstName = "FirstName";
			public const string Title = "Title";
			public const string TitleOfCourtesy = "TitleOfCourtesy";
			public const string BirthDate = "BirthDate";
			public const string HireDate = "HireDate";
			public const string Address = "Address";
			public const string City = "City";
			public const string Region = "Region";
			public const string PostalCode = "PostalCode";
			public const string Country = "Country";
			public const string HomePhone = "HomePhone";
			public const string Extension = "Extension";
			public const string Photo = "Photo";
			public const string Notes = "Notes";
			public const string ReportsTo = "ReportsTo";
			public const string PhotoPath = "PhotoPath";
		}

	}
}
