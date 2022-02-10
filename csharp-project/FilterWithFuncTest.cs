using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterWithFuncTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			CollectionAssert.AreEqual(new []{ 4, 10 }, FilterWithFunc.KeepPositiveNumbers(new[] { -5, 4, 10, 0, -9 }).ToList());
			CollectionAssert.AreEqual(new []{ -5, -9 }, FilterWithFunc.KeepNegativeNumbers(new[] { -5, 4, 10, 0, -9 }).ToList());
			CollectionAssert.AreEqual(new []{ 0 }, FilterWithFunc.FilterNumbers(new[] { -5, 4, 10, 0, -9 }, x => x == 0).ToList());
			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{	
				// On Failure
				TechIO.PrintMessage("Hint 💡", "Did you properly implemented the methods? 🤔");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can filter integers!");
			}
		}
    }
}
