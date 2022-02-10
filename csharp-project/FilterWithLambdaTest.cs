using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterWithLambdaTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			CollectionAssert.AreEqual(new []{ 4, 10 }, FilterWithLambda.KeepPositiveNumbers(new[] { -5, 4, 10, 0, -9 }).ToList());
			CollectionAssert.AreEqual(new []{ -5, -9 }, FilterWithLambda.KeepNegativeNumbers(new[] { -5, 4, 10, 0, -9 }).ToList());
			CollectionAssert.AreEqual(new []{ 0 }, FilterWithLambda.FilterNumbers(new[] { -5, 4, 10, 0, -9 }, x => x == 0).ToList());
			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{	
				// On Failure
				TechIO.PrintMessage("Hint 💡", "Did you properly implemented the method? 🤔");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can filter integers!");
			}
		}
    }
}
