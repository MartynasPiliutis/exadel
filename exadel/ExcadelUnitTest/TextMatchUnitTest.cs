using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextMatchLibrary;

namespace TextMatchUnitTest
{
    [TestClass]
    public class TextMatchTests
    {
        [TestMethod]
        public void TikrinameArSuformuojamiListaiPagalTikrinamoTekstoSimboliuKieki()
        {
            //Assign
            InputTextRepository InputTextRepository = new InputTextRepository();
            string text = "Abc Def";
            string subText = "def";
            //Act
            int countTheList = InputTextRepository.BuildTheList(text, subText).Count;
            //Assert
            Assert.AreEqual(countTheList, 5);
        }

        [TestMethod]
        public void TikrinameArRandameFrazeTekste()
        {
            //Assign
            InputTextRepository InputTextRepository = new InputTextRepository();
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            string subText = "Polly";
            //Act
            InputTextRepository.BuildTheList(text, subText);
            int countTheList = InputTextRepository.BuildMatchList(subText).Count;
            //Assert
            Assert.AreEqual(countTheList, 3);
        }
    }
}
