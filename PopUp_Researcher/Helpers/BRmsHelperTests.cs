using Microsoft.VisualStudio.TestTools.UnitTesting;
using PopUp_Researcher.Helpers;
using System;
using System.Collections.Generic;

namespace PopUp_Researcher.Helpers
{
    [TestClass]
    public class BRmsHelperTests
    {
        [TestMethod]
        public void UpdateStimulusFromCsv_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var bRmsHelper = new BRmsHelper();
            string fileName = null;

            // Act
            bRmsHelper.UpdateStimulusFromCsv(fileName);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetStimulusByTags_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var bRmsHelper = new BRmsHelper();
            List<string> tagsList = null;

            // Act
            var result = bRmsHelper.GetStimulusByTags(
                tagsList);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetStimulusByOneTag_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var bRmsHelper = new BRmsHelper();
            string tag = null;

            // Act
            var result = bRmsHelper.GetStimulusByOneTag(
                tag);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetTagList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var bRmsHelper = new BRmsHelper();

            // Act
            var result = bRmsHelper.GetTagList();

            // Assert
            Assert.Fail();
        }
    }
}
