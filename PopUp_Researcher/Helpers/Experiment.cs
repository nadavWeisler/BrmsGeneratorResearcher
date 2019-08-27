using System;

namespace bRMS_Generator
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class Experiment
    {
        /// <summary>
        /// Experiment type
        /// </summary>
        public string type;

        /// <summary>
        /// 
        /// </summary>
        public decimal group;

        /// <summary>
        /// 
        /// </summary>
        public decimal sub_group;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_group"></param>
        public void SetGroup(decimal _group)
        {
            this.group = _group;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sub_group"></param>
        public void SetSubGroup(decimal _sub_group)
        {
            this.sub_group = _sub_group;
        }
    }
}
