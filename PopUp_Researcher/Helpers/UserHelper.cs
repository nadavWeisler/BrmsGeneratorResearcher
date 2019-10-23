using System.Collections.Generic;

namespace PopUp_Researcher.Helpers
{
    public class UserHelper
    {
        protected string name;
        protected string pass;
        protected List<Trial> experiments;

        public UserHelper(string _name, List<Trial> _experiments)
        {
            this.name = _name;
            this.experiments = _experiments;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetPass()
        {
            return this.pass;
        }
    }
}
