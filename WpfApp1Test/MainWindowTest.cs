using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace WpfApp1Test
{
    [TestClass]
    public class MainWindowTest
    {
        [TestMethod]
        // тест на передачу числа -10, ответ должен быть не принадлежит
        public void CheckNumberX_EnterMinus10_AnswerDoNotBelong()
        {
            // данные для передачи
            double x = -10;
            // ожидаемый ответ
            string excpected = "не принадлежит";
            // фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка
            // если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        // тест на передачу числа -5, ответ должен быть принадлежит
        public void CheckNumberX_EnterMinus5_AnswerBelong()
        {
            // данные для передачи
            double x = -5;
            // ожидаемый ответ
            string excpected = "принадлежит";
            // фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }
        [TestMethod]
        // тест на передачу числа 4, ответ должен быть не принадлежит
        public void CheckNumberX_Enter4_AnswerDoNotBelong()
        {
            // данные для передачи
            double x = 4;
            // ожидаемый ответ
            string excpected = "не принадлежит";
            // фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]

        public void CheckNumberX_Enter6_AnswerBeLong()
        {
            //Данные для передачи
            double x = 6;
            //ожидаемый ответ
            string excpected = "принадлежит";
            //фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter25_AnswerDoNotBeLong()
        {
            //Данные для передачи
            double x = 25;
            //ожидаемый ответ
            string excpected = "не принадлежит";
            //фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_EnterMinus9_AnswerBeLong()
        {
            //Данные для передачи
            double x = -9;
            //ожидаемый ответ
            string excpected = "принадлежит";
            //фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter3_AnswerBeLong()
        {
            //Данные для передачи
            double x = 3;
            //ожидаемый ответ
            string excpected = "принадлежит";
            //фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter5_AnswerBeLong()
        {
            //Данные для передачи
            double x = 5;
            //ожидаемый ответ
            string excpected = "принадлежит";
            //фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void CheckNumberX_Enter20_AnswerBeLong()
        {
            //Данные для передачи
            double x = 20;
            //ожидаемый ответ
            string excpected = "принадлежит";
            //фактический ответ
            string actual = MainWindow.CheckNumberX(x);
            // проверка, если ожидаемый и актуальный ответ одинаковы
            // то тест будет пройден
            Assert.AreEqual(excpected, actual);
        }
    }
}
