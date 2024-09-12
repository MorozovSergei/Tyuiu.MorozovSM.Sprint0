using Tyuiu.MorozovSM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MorozovSM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Сергей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Сергей", res);
        }
    }
}