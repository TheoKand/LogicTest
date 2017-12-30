using System.Collections.Generic;
using NUnit.Framework;

namespace LogicTest.UnitTests
{
    [TestFixture]
    public class WillYouGoThroughThisDoor_UnitTests
    {
        private Question question;

        [SetUp]
        public void Setup()
        {
            question = new WillYouGoThroughThisDoor();

        }

        [Test]
        public void WillYouGoThroughThisDoor_HasConclusiveAnswer()
        {
            Assert.IsTrue(QuestionRunner.QuestionResultsInConclusiveAnswer(question, LogicTest.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void WillYouGoThroughThisDoor_ConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionRunner.AnswerAlwaysLeadsToFreedom(question, LogicTest.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void WillYouGoThroughThisDoor_OppositeOfConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionRunner.OppositeAnswerAlwaysLeadsToFreedom(question, LogicTest.UnitTests.Setup.allConfigurations));
        }



    }
}
