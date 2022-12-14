using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void TestTest()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_01.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_01.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test2()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_02.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_02.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test3()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_03.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_03.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test4()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_04.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_04.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test5()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_05.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_05.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test6()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_06.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_06.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test7()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_07.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_07.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test8()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_08.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_08.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test9()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_09.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_09.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test10()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_10.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_10.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test11()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_11.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_11.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test12()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_12.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_12.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test13()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_13.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_13.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test14()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_14.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_14.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test15()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_15.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_15.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test16()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_16.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_16.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test17()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_17.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_17.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test18()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_18.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_18.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test19()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_19.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_19.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Test20()
        {
            double productType, materialType, count;
            double width, length;

            ReadInputData("InputData_Easy_20.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Easy_20.txt");

            double actual = Class1.Test(productType, materialType, count, width, length);

            Assert.AreEqual(expected, actual);
        }

        #region Hard Test Methods
        [TestMethod]
        public void QuantityForProduct_Hard_01()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_01.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_01.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_02()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_02.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_02.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_03()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_03.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_03.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_04()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_04.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_04.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_05()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_05.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_05.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_06()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_06.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_06.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_07()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_07.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_07.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_08()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_08.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_08.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_09()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_09.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_09.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuantityForProduct_Hard_10()
        {
            // Arrange
            double productType, materialType, count;
            double width, length;
            ReadInputData("InputData_Hard_10.txt", out productType, out materialType, out count, out width, out length);
            double expected = ReadOutputData("OutputData_Hard_10.txt");

            // Act
            double actual = Class1.Test(productType, materialType, count, width, length);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion


        private void ReadInputData(string fileName, out double productType, out double materialType, out double count, out double width, out double length)
        {
            string path = "..\\..\\..\\..\\TestingData\\" + fileName;
            string[] data = File.ReadAllLines(path);

            data = data.Select(s => s.Replace(".", ",")).ToArray();

            productType = double.Parse(data[0]);
            materialType = double.Parse(data[1]);
            count = double.Parse(data[2]);
            width = double.Parse(data[3]);
            length = double.Parse(data[4]);
        }

        private int ReadOutputData(string fileName)
        {
            string path = "..\\..\\..\\..\\TestingData\\" + fileName;
            string data = File.ReadAllText(path);
            return int.Parse(data);
        }
    }
}