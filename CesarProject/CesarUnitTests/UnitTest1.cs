using NUnit.Framework;
using TestCesar.Classes;

namespace CesarUnitTests
{
    public class CesarTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void getRomanNumber_Int9_ReturnsIX()
        {
          //Arrange
          var cesar = new Cesar();
          //Act
          var result =cesar.getRomanNumber(9);
          //Assert
          Assert.AreEqual(result,"IX");
        }

        [Test]
        public void getRomanNumber_Int35_ReturnsXXXV()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(35);
            //Assert
            Assert.AreEqual(result, "XXXV");
        }


        [Test]
        public void getRomanNumber_Int77_ReturnsLXXV()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(77);
            //Assert
            Assert.AreEqual(result, "LXXVII");
        }

        [Test]
        public void getRomanNumber_Int100_ReturnsC()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(100);
            //Assert
            Assert.AreEqual(result, "C");
        }
        [Test]
        public void getRomanNumber_Int200_ReturnsCC()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(200);
            //Assert
            Assert.AreEqual(result, "CC");
        }
        [Test]
        public void getRomanNumber_Int250_ReturnsCCL()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(250);
            //Assert
            Assert.AreEqual(result, "CCL");
        }

        [Test]
        public void getRomanNumber_Int700_ReturnsDCC()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(700);
            //Assert
            Assert.AreEqual(result, "DCC");
        }

        [Test]
        public void getRomanNumber_Int1000_ReturnsM ()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(1000);
            //Assert
            Assert.AreEqual(result, "M");
        }

        [Test]
        public void getRomanNumber_Int1500_ReturnsMD()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(1500);
            //Assert
            Assert.AreEqual(result, "MD");
        }

        [Test]
        public void getRomanNumber_Int1833_ReturnsMDCCCXXXIII()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(1833);
            //Assert
            Assert.AreEqual(result, "MDCCCXXXIII");
        }


        [Test]
        public void getRomanNumber_Int2243_ReturnsMMCCXLIII
()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(2243);
            //Assert
            Assert.AreEqual(result, "MMCCXLIII");
        }


        [Test]
        public void getRomanNumber_Int3230_ReturnsMMMCCXXX()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(3230);
            //Assert
            Assert.AreEqual(result, "MMMCCXXX");
        }

        [Test]
        public void getRomanNumber_Int3999_ReturnsMMMCMXCIX()
        {
            //Arrange
            var cesar = new Cesar();
            //Act
            var result = cesar.getRomanNumber(3999);
            //Assert
            Assert.AreEqual(result, "MMMCMXCIX");
        }
    }
}