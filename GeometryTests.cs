using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;


namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RectangleArea_3and4_12returned()
        {
            // исходные данные
            int a = 3;
            int b = 4;
            int expected = 12;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void RectangleArea_1and2_2returned()
        {
            // исходные данные
            int a = 1;
            int b = 2;
            int expected = 2;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void RectangleArea_6and8_48returned()
        {
            // исходные данные
            int a = 6;
            int b = 8;
            int expected = 48;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void RectangleArea_21and3_63returned()
        {
            // исходные данные
            int a = 21;
            int b = 3;
            int expected = 63;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }






        [TestMethod]
        public void CircleArea_3_9pireturned()
        {
            // исходные данные
            int r = 3;
            double expected = 28.26;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CircleArea(r);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CircleArea_4_16pireturned()
        {
            // исходные данные
            int r = 4;
            double expected = 50.24;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CircleArea(r);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea_8_64pireturned()
        {
            // исходные данные
            int r = 8;
            double expected = 200.96;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CircleArea(r);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea_21_441pireturned()
        {
            // исходные данные
            int r = 21;
            double expected = 1384.74;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CircleArea(r);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea_1_1pireturned()
        {
            // исходные данные
            int r = 1;
            double expected = 3.14;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.CircleArea(r);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_11and5and15_19returned()
        {
            // исходные данные
            int a = 11;
            int b = 5;
            int c = 15;
            double expected = 19.136026;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TriangleArea(a,b,c);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_5and9and8_19returned()
        {
            // исходные данные
            int a = 5;
            int b = 9;
            int c = 8;
            double expected = 19.899749;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TriangleArea(a, b, c);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_1and2and4_pireturned()
        {
            // исходные данные
            int a = 5;
            int b = 6;
            int c = 7;
            double expected = 14.696938;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TriangleArea(a, b, c);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_33and57and31_414returned()
        {
            // исходные данные
            int a = 33;
            int b = 57;
            int c = 31;
            double expected = 414.466148;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TriangleArea(a, b, c);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_20and12and9_31returned()
        {
            // исходные данные
            int a = 20;
            int b = 12;
            int c = 9;
            double expected = 31.653396;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TriangleArea(a, b, c);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EllipseArea_3and4_12pireturned()
        {
            // исходные данные
            int r = 3;
            int R = 4;
            double expected = 37.68;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.EllipseArea(r, R);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void EllipseArea_5and9_45pireturned()
        {
            // исходные данные
            int r = 5;
            int R = 9;
            double expected = 141.3;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.EllipseArea(r, R);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EllipseArea_12and8_96pireturned()
        {
            // исходные данные
            int r = 12;
            int R = 8;
            double expected = 301.44;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.EllipseArea(r, R);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EllipseArea_2and50_314returned()
        {
            // исходные данные
            int r = 2;
            int R = 50;
            double expected = 314;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.EllipseArea(r, R);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EllipseArea_12and11_132pireturned()
        {
            // исходные данные
            int r = 12;
            int R = 11;
            double expected = 414.48;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.EllipseArea(r, R);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiamondArea_11and12_66ireturned()
        {
            // исходные данные
            int d1 = 12;
            int d2 = 11;
            double expected = 66;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.DiamondArea(d1,d2);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiamondArea_3and19_28returned()
        {
            // исходные данные
            int d1 = 3;
            int d2 = 19;
            double expected = 28.5;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.DiamondArea(d1, d2);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiamondArea_56and3_84returned()
        {
            // исходные данные
            int d1 = 56;
            int d2 = 3;
            double expected = 84;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.DiamondArea(d1, d2);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiamondArea_57and89_2536returned()
        {
            // исходные данные
            int d1 = 57;
            int d2 = 89;
            double expected = 2536.5;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.DiamondArea(d1, d2);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiamondArea_15and3_22returned()
        {
            // исходные данные
            int d1 = 15;
            int d2 = 3;
            double expected = 22.5;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.DiamondArea(d1, d2);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ParallelogramArea_15and3_45returned()
        {
            // исходные данные
            int a = 15;
            int h = 3;
            double expected = 45;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.ParallelogramArea(a, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParallelogramArea_5and6_30returned()
        {
            // исходные данные
            int a = 5;
            int h = 6;
            double expected = 30;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.ParallelogramArea(a, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void ParallelogramArea_10and8_80returned()
        {
            // исходные данные
            int a = 10;
            int h = 8;
            double expected = 80;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.ParallelogramArea(a, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void ParallelogramArea_51and2_102returned()
        {
            // исходные данные
            int a = 51;
            int h = 2;
            double expected = 102;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.ParallelogramArea(a, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void ParallelogramArea_17and3_51returned()
        {
            // исходные данные
            int a = 17;
            int h = 3;
            double expected = 51;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.ParallelogramArea(a, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TrapezoidArea_17and3and3_51returned()
        {
            // исходные данные
            int a = 17;
            int b = 9;
            int h = 3;
            double expected = 39;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TrapezoidArea(a,b,h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TrapezoidArea_13and3and67_536returned()
        {
            // исходные данные
            int a = 13;
            int b = 3;
            int h = 67;
            double expected = 536;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TrapezoidArea(a, b, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrapezoidArea_2and5and3_3returned()
        {
            // исходные данные
            int a = 2;
            int b = 5;
            int h = 1;
            double expected = 3.5;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TrapezoidArea(a, b, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrapezoidArea_6and89and12_570returned()
        {
            // исходные данные
            int a = 6;
            int b = 89;
            int h = 12;
            double expected = 570;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TrapezoidArea(a, b, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrapezoidArea_56and12and6_204returned()
        {
            // исходные данные
            int a = 56;
            int b = 12;
            int h = 6;
            double expected = 204;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.TrapezoidArea(a, b, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void СonvexQuadrangleArea_56and12and6_204returned()
        {
            // исходные данные
            int d1 = 56;
            int d2 = 12;
            int angle = 5;
            double expected = 29.284329563213145;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.СonvexQuadrangleArea(d1, d2, angle);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void СonvexQuadrangleArea_28and91and30_639returned()
        {
            // исходные данные
            int d1 = 28;
            int d2 = 91;
            int angle = 30;
            double expected = 636.9999999999999;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.СonvexQuadrangleArea(d1, d2, angle);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void СonvexQuadrangleArea_90and20and71_79returned()
        {
            // исходные данные
            int d1 = 90;
            int d2 = 20;
            int angle = 71;
            double expected = 850.9667180393851;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.СonvexQuadrangleArea(d1, d2, angle);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void СonvexQuadrangleArea_9and25and45_79returned()
        {
            // исходные данные
            int d1 = 9;
            int d2 = 25;
            int angle = 45;
            double expected = 79.54951288348659;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.СonvexQuadrangleArea(d1, d2, angle);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void СonvexQuadrangleArea_45and29and11_124returned()
        {
            // исходные данные
            int d1 = 45;
            int d2 = 29;
            int angle = 11;
            double expected = 124.50286948319548;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.СonvexQuadrangleArea(d1, d2, angle);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }






    }
}
