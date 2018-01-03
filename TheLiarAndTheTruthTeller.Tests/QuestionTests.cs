using System.Collections.Generic;
using NUnit.Framework;
using TheLiarAndTheTruthTeller.Core;
using TheLiarAndTheTruthTeller.Core.Questions;

namespace TheLiarAndTheTruthTeller.Tests
{
    [TestFixture]
    public class QuestionTests
    {

        [Test]
        public void DoesThisDoorLeadToFreedom_IsTheRightQuestionToAsk()
        {
            QuestionTestHelper helper = new QuestionTestHelper(new DoesThisDoorLeadToFreedom());

            Assert.IsTrue(helper.QuestionHasConclusiveAnswer());

            Assert.That(helper.AnswerAlwaysLeadsToFreedom() || helper.AnswerAlwaysLeadsToDeath());
        }

        [Test]
        public void WhatWillTheOtherGuardSay_IsTheRightQuestionToAsk()
        {
            QuestionTestHelper helper = new QuestionTestHelper(new WhatWillTheOtherGuardSay());

            Assert.IsTrue(helper.QuestionHasConclusiveAnswer());

            Assert.That(helper.AnswerAlwaysLeadsToFreedom() || helper.AnswerAlwaysLeadsToDeath());
        }

    }
}
