namespace PopUp_Researcher.Helpers
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
        public decimal group;

        /// <summary>
        /// Trial Sub Group
        /// </summary>
        public decimal sub_group;

        #endregion

        #region Public Methods

        /// <summary>
        /// Set Group
        /// </summary>
        /// <param name="_group"></param>
        public void SetGroup(decimal _group)
        {
            this.group = _group;
        }

        /// <summary>
        /// Set Sub Group
        /// </summary>
        /// <param name="_sub_group"></param>
        public void SetSubGroup(decimal _sub_group)
        {
            this.sub_group = _sub_group;
        }

        #endregion
    }
}
