using System.Collections.Generic;
using NUnit.Framework;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller.UnitTests
{
    [TestFixture]
    public class WhatWillTheOtherGuardSay_UnitTests
    {
        private Question question;

        [SetUp]
        public void Setup()
        {
            question = new WhatWillTheOtherGuardSay();

        }

        [Test]
        public void WhatWillTheOtherGuardSay_HasConclusiveAnswer()
        {
            Assert.IsTrue(QuestionEvaluator.QuestionHasConclusiveAnswer(question, TheLiarAndTheTruthTeller.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void WhatWillTheOtherGuardSay_ConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionEvaluator.AnswerAlwaysLeadsToFreedom(question, TheLiarAndTheTruthTeller.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void WhatWillTheOtherGuardSay_OppositeOfConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionEvaluator.OppositeAnswerAlwaysLeadsToFreedom(question, TheLiarAndTheTruthTeller.UnitTests.Setup.allConfigurations));
        }



    }
}
