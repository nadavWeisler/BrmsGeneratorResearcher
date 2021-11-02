using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrmsGeneratorResearcher.Helpers
{
    public class Cpt : Trial
    {
        #region Properties

        public string stimulus_shape;

        public string stimulus_color;

        public List<string> other_colors;


        #endregion

        #region Constractors

        /// <summary>
        /// Basic Constructors
        /// </summary>
        /// <param name="_message"></param>
        public Cpt(string _stimulus_shape = Shapes.Squere, List<string> other_colors = null,
            string _stimulus_color = "#0000FF")
        {
            this.type = ExperimentTypes.ConjunctiveCPT;
            this.stimulus_shape = _stimulus_shape;
            if (this.other_colors == null)
            {
                this.other_colors = new List<string> { "#FF0000", "#00FF00", "#FF00FF", "#00FFFF" };
            } 
            else
            {
                this.other_colors = other_colors;
            }
            this.stimulus_color = _stimulus_color;
        }

        #endregion
    }
}
