using System.Collections.Generic;
using NUnit.Framework;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller.Tests
{
    [TestFixture]
    public class QuestionTests
    {

        [Test]
        public void DoesThisDoorLeadToFreedom_IsTheRightQuestionToAsk()
        {
            QuestionTestHelper helper = new QuestionTestHelper(new DoesThisDoorLeadToFreedom());

            Assert.IsTrue(helper.QuestionHasConclusiveAnswer(Setup.allConfigurations));

            Assert.That(helper.AnswerAlwaysLeadsToFreedom(Setup.allConfigurations) || helper.OppositeAnswerAlwaysLeadsToFreedom(Setup.allConfigurations));
        }

        [Test]
        public void WhatWillTheOtherGuardSay_IsTheRightQuestionToAsk()
        {
            QuestionTestHelper helper = new QuestionTestHelper(new WhatWillTheOtherGuardSay());

            Assert.IsTrue(helper.QuestionHasConclusiveAnswer(Setup.allConfigurations));

            Assert.That(helper.AnswerAlwaysLeadsToFreedom(Setup.allConfigurations) || helper.OppositeAnswerAlwaysLeadsToFreedom(Setup.allConfigurations));
        }

    }
}
