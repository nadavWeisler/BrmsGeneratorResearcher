namespace BrmsGeneratorResearcher.Helpers
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

        /// <summary>
        /// Trial Name
        /// </summary>
        public string name;

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
        /// <param name="subGroup"></param>
        public void SetSubGroup(decimal subGroup)
        {
            this.sub_block = subGroup;
        }

        #endregion
    }
}
