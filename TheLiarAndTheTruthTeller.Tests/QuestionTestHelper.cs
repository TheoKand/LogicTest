using System.Collections.Generic;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller.Tests
{
    public class QuestionTestHelper
    {
        private Question question;

        public QuestionTestHelper(Question question)
        {
            this.question = question;
        }

        /// <summary>
        /// Returns TRUE if this question returns a conclusive answer regardless of which guard answers.
        /// </summary>
        public bool QuestionHasConclusiveAnswer()
        {

            for (int i = 0; i < Configuration.AllPossible.Count; i++)
            {
                Configuration configuration = Configuration.AllPossible[i];

                var firstGuardAnswer= question.AskQuestion(configuration.guard1);
                var secondGuardAnswer = question.AskQuestion(configuration.guard2);

                if (firstGuardAnswer == secondGuardAnswer) return false;
            }

            return true;
        }

        /// <summary>
        /// Returns TRUE if the answer always leads to freedom, for all configurations
        /// </summary>
        public bool AnswerAlwaysLeadsToFreedom()
        {

            for (int i = 0; i < Configuration.AllPossible.Count; i++)
            {
                Configuration configuration = Configuration.AllPossible[i];

                var firstGuardAnswer = question.AskQuestion(configuration.guard1);
                if (configuration.guard1.Door.LeadsToFreedom && firstGuardAnswer!= Question.AnswerEnum.Yes)
                {
                    return false;
                } else if (configuration.guard1.Door.LeadsToDeath && firstGuardAnswer != Question.AnswerEnum.No)
                {
                    return false;
                }

                var secondGuardAnswer = question.AskQuestion(configuration.guard2);
                if (configuration.guard2.Door.LeadsToFreedom && secondGuardAnswer != Question.AnswerEnum.Yes)
                {
                    return false;
                }
                else if (configuration.guard2.Door.LeadsToDeath && secondGuardAnswer != Question.AnswerEnum.No)
                {
                    return false;
                }


            }

            return true;
        }
   
        /// <summary>
        /// Returns TRUE if the opposite answer always leads to freedom, for all configurations.
        /// </summary>
        /// <param name="configurations"></param>
        /// <returns></returns>
        public bool OppositeAnswerAlwaysLeadsToFreedom( )
        {

            for (int i = 0; i < Configuration.AllPossible.Count; i++)
            {
                Configuration configuration = Configuration.AllPossible[i];

                var firstGuardAnswer = question.AskQuestion(configuration.guard1);
                if (configuration.guard1.Door.LeadsToFreedom && firstGuardAnswer != Question.AnswerEnum.No)
                {
                    return false;
                }
                else if (configuration.guard1.Door.LeadsToDeath && firstGuardAnswer != Question.AnswerEnum.Yes)
                {
                    return false;
                }

                var secondGuardAnswer = question.AskQuestion(configuration.guard2);
                if (configuration.guard2.Door.LeadsToFreedom && secondGuardAnswer != Question.AnswerEnum.No)
                {
                    return false;
                }
                else if (configuration.guard2.Door.LeadsToDeath && secondGuardAnswer != Question.AnswerEnum.Yes)
                {
                    return false;
                }

            }

            return true;
        }

    }
}
