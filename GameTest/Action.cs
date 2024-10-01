namespace GameTest
{
    class Action
    {
        private string Actions;
        private string Context;
        private bool Item;

        public Action(string Actions, string Context, bool Item)
        {
            this.Actions = Actions;
            this.Context = Context;
            this.Item = Item;
        }

        public string getActions()
        {
            return this.Actions;
        }

        public string getContext()
        {
            return this.Context;
        }

        public bool getYes()
        {
            return this.Item;
        }
    }
}
