﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watsonia.AusPostInterface.Tests
{
	[TestClass]
	public class RecipientTests
	{
		[TestMethod]
		public void RecipientToJson()
		{
			var item = new Recipient();
			item.Name = "Jane Smith";
			item.BusinessName = "Smith Pty Ltd";
			item.Line1 = "123 Centre Road";
			item.Suburb = "Sydney";
			item.State = State.NSW;
			item.Postcode = "2000";
			item.Phone = "0412345678";
			item.Email = "jane.smith@smith.com";

			var expected = @"
{
  ""name"": ""Jane Smith"",
  ""business_name"": ""Smith Pty Ltd"",
  ""lines"": [
    ""123 Centre Road""
  ],
  ""suburb"": ""Sydney"",
  ""state"": ""NSW"",
  ""postcode"": ""2000"",
  ""phone"": ""0412345678"",
  ""email"": ""jane.smith@smith.com""
}".Trim();

			Assert.AreEqual(expected, item.ToJson());
		}
	}
}