using System;
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
	[DebuggerDisplay("EmployeeId = {EmployeeId}TerritoryId = {TerritoryId}")]
	public partial class 	EmployeeTerritories: BaseTypeLibrary
	{
		private int employeeId;
		private string territoryId;

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

		[Key]
		[StringLength(20)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string TerritoryId
		{
			[DebuggerStepThrough]
			get
			{
				return territoryId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (territoryId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				territoryId = value;
			}
		}

		public EmployeeTerritories ShallowCopy()
		{
			EmployeeTerritories obj = new EmployeeTerritories();
			obj.employeeId = employeeId;
			obj.territoryId = territoryId;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string EmployeeId = "EmployeeID";
			public const string TerritoryId = "TerritoryID";
		}

	}
}
