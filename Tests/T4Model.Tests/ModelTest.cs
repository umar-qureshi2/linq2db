﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/igor-tkachev/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

using T4Model.Tests;

namespace T4Model.Tests
{
	public partial class TestClass1
	{
		#region Test Region

		public int    Field1;
		public string Field2;

		#endregion

		#region Test Region 2

		public int    Field12;
		public string Field22;

		#endregion

		[XmlArrayItem(typeof(int), DataType="List")]
		public List<int> Field3; // Field3 comment

		[DisplayName("Prop")]
		public char Property1 { get; set; } // Property1 comment

		public List<int> Field31;

		public double Field5;

		public List<int> Field6;

		public double       Fld7;                           // Fld7
		public List<int>    Field8;
		public DateTime     FieldLongName;                  // field long name
		public List<string> Property2 { get;         set; } // Property2
		public List<int?>   Property3 { get; private set; } // Property3
		public int?         Prop1     { get;         set; } // Prop1

		public List<string> Field4;
	}

	[Serializable, DisplayName("TestClass")]
	public partial class TestClass2 : TestClass1
	{
	}
}
