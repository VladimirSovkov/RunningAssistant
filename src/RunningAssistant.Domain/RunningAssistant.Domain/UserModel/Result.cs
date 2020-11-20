using RunningAssistant.Domain.Toolkit.Domain;
using RunningAssistant.Domain.TrainingModel;
using System;

namespace RunningAssistant.Domain.UserModel
{
    public class Result : Entity
    {
        public Result(
            User user
            , Training training
            , float value)
        {
            User = user;
            Training = training;
            Value = value;
        }

        public int UserId { get; private set; }
        public virtual User User { get; private set; }
        
        public int TrainingId { get; private set; }
        public virtual Training Training { get; private set; }

        public DateTime CreationDate { get; private set; }
        public float Value { get; private set; }
    }
}
