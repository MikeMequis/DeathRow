using System.Collections.Generic;

namespace GameTest
{
    class Inventory
    {
        private string Name;

        public Inventory(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {
            return this.Name;
        }
    }
}
