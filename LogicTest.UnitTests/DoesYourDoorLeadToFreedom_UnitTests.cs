using System.Collections.Generic;
using NUnit.Framework;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller.UnitTests
{
    [TestFixture]
    public class DoesYourDoorLeadToFreedom_UnitTests
    {
        private Question question;

        [SetUp]
        public void Setup()
        {
            question = new DoesYourDoorLeadToFreedom();

        }

        [Test]
        public void DoesYourDoorLeadToFreedom_HasConclusiveAnswer()
        {
            Assert.IsTrue(QuestionEvaluator.QuestionHasConclusiveAnswer(question, TheLiarAndTheTruthTeller.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void DoesYourDoorLeadToFreedom_ConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionEvaluator.AnswerAlwaysLeadsToFreedom(question, TheLiarAndTheTruthTeller.UnitTests.Setup.allConfigurations));
        }

        [Test]
        public void DoesYourDoorLeadToFreedom_OppositeOfConclusiveAnswerAlwaysLeadsToFreedom()
        {
            Assert.IsTrue(QuestionEvaluator.OppositeAnswerAlwaysLeadsToFreedom(question, TheLiarAndTheTruthTeller.UnitTests.Setup.allConfigurations));
        }



    }
}
