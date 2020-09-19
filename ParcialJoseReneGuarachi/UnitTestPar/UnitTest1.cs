using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialJoseReneGuarachi.Controllers;

namespace UnitTestPar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            //Arrange
            CountriesController controlador = new CountriesController();



            //Act
            var lista = controlador.GetCountries();


            //Assert
            Assert.IsNotNull(lista);
        }
    }
}
