using RunningAssistant.Domain.Toolkit.Domain;
using RunningAssistant.Domain.UserModel;
using System;
using System.Collections.Generic;

namespace RunningAssistant.Domain.TrainingModel
{
    public class Training : Entity
    {
        public Training(
            string name
            , string type
            , float Calories
            , string description = "")
        {

        }
        
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Description { get; private set; }
        public DateTime Duration { get; private set; }
        public float Calories { get; private set; }

        private readonly List<Result> _results = new List<Result>();
        public virtual IReadOnlyCollection<Result> Results => _results.AsReadOnly();


        public void SetDuration(DateTime time)
        {
            ///продолжительност должна быть больше чем ничего
            if (time < new DateTime())
            {
                throw new ArgumentException("Incorrect workout duration");
            }
            Duration = time;
        }
    }
}
