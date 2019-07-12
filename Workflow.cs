using System;

namespace InterfacesExercise1
{
    public class Workflow
    {
        private readonly IActivity _activity;

        public Workflow(IActivity activity)
        {
            _activity = activity;
        }

        public void Run()
        {
            _activity.Execute();
        }
    }
}
