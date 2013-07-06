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

		[Required]
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

		[Required]
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string CategoryIdAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return categoryId.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					int _a = Convert.ToInt32(value);
				CategoryId = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"CategoryId",string.Format(CEVIRI_YAZISI,"CategoryId","int")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string PictureAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return picture != null ? picture.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("String'ten byte[] array'e cevirim desteklenmemektedir");
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
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "CategoryName"));		}
		public class PropertyIsimleri
		{
			public const string CategoryId = "CategoryID";
			public const string CategoryName = "CategoryName";
			public const string Description = "Description";
			public const string Picture = "Picture";
		}

	}
}
