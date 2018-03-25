using JSONBasedWebService.Core.Models;
using JSONBasedWebService.Core.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace JSONBasedWebService.Core.UnitTest
{
    [TestClass]
    public class JSONBasedWebServiceCore
    {
        [TestMethod]
        public void Verify_NULLResponse_ForJSON()
        {
            var jsonParser = new JSONParser();

            Response res = jsonParser.FilterData(string.Empty);

            Assert.IsNull(res);
        }

        [TestMethod]
        public void Verify_With_ValidPayload_ForJSON()
        {
            var jsonParser = new JSONParser();

            string jsonData = File.ReadAllText("TestData\\ValidPayload.json");

            Response res = jsonParser.FilterData(jsonData);

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void Verify_With_InValidPayload_ForJSON()
        {
            var jsonParser = new JSONParser();

            string jsonData = File.ReadAllText("TestData\\InValidPayload.json");

            Assert.ThrowsException<ArgumentNullException>(() => jsonParser.FilterData(jsonData));
        }
    }
}