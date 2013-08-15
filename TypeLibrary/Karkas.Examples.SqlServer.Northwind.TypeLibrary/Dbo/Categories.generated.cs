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
	[DebuggerDisplay("CategoryId = {CategoryId}")]
	public partial class 	Categories: BaseTypeLibrary
	{
		private int categoryId;
		private string categoryName;
		private string description;
		private byte[] picture;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int CategoryId
		{
			[DebuggerStepThrough]
			get
			{
				return categoryId;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (categoryId!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				categoryId = value;
			}
		}

		[StringLength(15)]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string CategoryName
		{
			[DebuggerStepThrough]
			get
			{
				return categoryName;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (categoryName!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				categoryName = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Description
		{
			[DebuggerStepThrough]
			get
			{
				return description;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (description!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				description = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public byte[] Picture
		{
			[DebuggerStepThrough]
			get
			{
				return picture;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (picture!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				picture = value;
			}
		}

		public Categories ShallowCopy()
		{
			Categories obj = new Categories();
			obj.categoryId = categoryId;
			obj.categoryName = categoryName;
			obj.description = description;
			obj.picture = picture;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string CategoryId = "CategoryID";
			public const string CategoryName = "CategoryName";
			public const string Description = "Description";
			public const string Picture = "Picture";
		}

	}
}
