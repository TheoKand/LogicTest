using System.Collections.Generic;
using NUnit.Framework;

namespace LogicTest.UnitTests
{
    [TestFixture]
    public class WhatWillTheOtherOneAnswer_UnitTests
    {
        private Question question;

        [SetUp]
        public void Setup()
        {
            question = new WhatWillTheOtherOneAnswer();

        }

        [Test]
        public void WhatWillTheOtherOneAnswer_HasConclusiveAnswer()
        {
            Assert.IsTrue(QuestionRunner.QuestionResultsInConclusiveAnswer(question, LogicTest.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void WhatWillTheOtherOneAnswer_ConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionRunner.AnswerAlwaysLeadsToFreedom(question, LogicTest.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void WhatWillTheOtherOneAnswer_OppositeOfConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionRunner.OppositeAnswerAlwaysLeadsToFreedom(question, LogicTest.UnitTests.Setup.allConfigurations));
        }



    }
}
