using System.Collections.Generic;

namespace GameTest
{
    class POI
    {
        private string Name;
        List<Action> Actions = new List<Action>();

        public POI(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return this.Name;
        }

        //Adds more than one action (Name, Context)
        public void addActions(params Action[] actions)
        {
            foreach (Action action in actions)
            {
                this.Actions.Add(action);
            }
        }

        public List<Action> getActions()
        {
            return this.Actions;
        }
    }
}
