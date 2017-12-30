﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest
{
    public abstract class Question
    {
        public enum AnswerEnum
        {
            Yes,
            No
        }

        public string Text { get; protected set; }

        public abstract AnswerEnum AskQuestion(Guard toThisGuard);

    }

    public class WhatWillTheOtherOneAnswer : Question
    {
        public WhatWillTheOtherOneAnswer()
        {
            this.Text = @"If I ask the other guard the question 'Will you go through this door?', what will they answer?";
        }

        public override string ToString()
        {
            return Text;
        }

        public override AnswerEnum AskQuestion(Guard askThisGuard)
        {

            if (askThisGuard.Door.LeadsToFreedom)
            {
                if (askThisGuard.TellsTruth)
                {
                    return AnswerEnum.No;
                      
                }
                else //if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.No;
                }
            } else //if (askThisGuard.Door.LeadsToDeath) 
            {
                if (askThisGuard.TellsTruth)
                {
                    return AnswerEnum.Yes;
                } else // if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.Yes;
                }
            }
        }
    }

    public class WillYouGoThroughThisDoor : Question
    {
        public WillYouGoThroughThisDoor()
        {
            this.Text = @"Will you go through this door?";
        }

        public override string ToString()
        {
            return Text;
        }

        public override AnswerEnum AskQuestion(Guard askThisGuard)
        {

            if (askThisGuard.Door.LeadsToFreedom)
            {
                if (askThisGuard.TellsTruth)
                {
                    return AnswerEnum.Yes;

                }
                else //if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.No;
                }
            }
            else //if (askThisGuard.Door.LeadsToDeath) 
            {
                if (askThisGuard.TellsTruth)
                {
                    return AnswerEnum.No;
                }
                else // if (askThisGuard.TellsLies)
                {
                    return AnswerEnum.Yes;
                }
            }
        }
    }

}
