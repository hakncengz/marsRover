using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace marsRover_Test
{
    [TestClass]
    public class marsRoverTest
    {
        [TestMethod]
        public void gezici_1()
        {
            string boyut = "5 5";
            char[] konum = new char[] {'1','2','N'};
            string talimat = "LMLMLMLMM";            
            marsRover.marsRover _test =new marsRover.marsRover(konum,talimat,boyut);            
            string sonuc = _test.testSonuc();

            Assert.AreEqual("1 3 N",sonuc);
        }
        [TestMethod]
        public void gezici_2()
        {
            string boyut = "5 5";
            char[] konum = new char[] { '3', '3', 'E' };
            string talimat = "MMRMMRMRRM";
            marsRover.marsRover _test = new marsRover.marsRover(konum, talimat, boyut);
            string sonuc = _test.testSonuc();

            Assert.AreEqual("5 1 E", sonuc);
        }
    }
}