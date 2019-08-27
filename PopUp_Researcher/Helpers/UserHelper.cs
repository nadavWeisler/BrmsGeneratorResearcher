using System.Collections.Generic;

namespace bRMS_Generator
{
    public class UserHelper
    {
        protected string name;
        protected string pass;
        protected List<Experiment> experiments;

        public UserHelper(string _name, List<Experiment> _experiments)
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
