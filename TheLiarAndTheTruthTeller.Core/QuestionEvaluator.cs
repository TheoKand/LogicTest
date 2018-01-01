using System.Collections.Generic;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller.Core
{
    public class QuestionEvaluator
    {

        /// <summary>
        /// Returns TRUE if this question returns a conclusive answer regardless of which guard answers.
        /// </summary>
        public static bool QuestionHasConclusiveAnswer(Question question,List<Configuration> configurations)
        {

            for (int i = 0; i < configurations.Count; i++)
            {
                Configuration configuration = configurations[i];

                var firstGuardAnswer= question.AskQuestion(configuration.guard1);
                var secondGuardAnswer = question.AskQuestion(configuration.guard2);

                if (firstGuardAnswer == secondGuardAnswer) return false;
            }

            return true;
        }

        public static bool AnswerAlwaysLeadsToFreedom(Question question, List<Configuration> configurations)
        {

            for (int i = 0; i < configurations.Count; i++)
            {
                Configuration configuration = configurations[i];

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

        public static bool OppositeAnswerAlwaysLeadsToFreedom(Question question, List<Configuration> configurations)
        {

            for (int i = 0; i < configurations.Count; i++)
            {
                Configuration configuration = configurations[i];

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
