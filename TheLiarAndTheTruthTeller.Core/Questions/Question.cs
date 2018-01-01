using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core.Questions
{
    public abstract class Question
    {
        public enum AnswerEnum
        {
            Yes,
            No
        }

        public string Text { get; protected set; }


        /// <summary>
        /// The answers must be implemented in this method
        /// </summary>
        public abstract AnswerEnum AskQuestion(Guard toThisGuard);

    }

}
