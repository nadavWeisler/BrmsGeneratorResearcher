﻿namespace PopUp_Researcher.Helpers
{
    public abstract class Trial
    {
        #region Properties

        /// <summary>
        /// Experiment type
        /// </summary>
        public string type;

        /// <summary>
        /// Trial Group
        /// </summary>
        public decimal block;

        /// <summary>
        /// Trial Sub Group
        /// </summary>
        public decimal sub_block;

        #endregion

        #region Public Methods

        /// <summary>
        /// Set Group
        /// </summary>
        /// <param name="_group"></param>
        public void SetGroup(decimal _group)
        {
            this.block = _group;
        }

        /// <summary>
        /// Set Sub Group
        /// </summary>
        /// <param name="_sub_group"></param>
        public void SetSubGroup(decimal _sub_group)
        {
            this.sub_block = _sub_group;
        }

        #endregion
    }
}
