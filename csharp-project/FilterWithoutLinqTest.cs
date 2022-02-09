using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterWithoutLinqTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			var result = FilterWithoutLinq.KeepPositiveNumbers(new[] { -5, 4, 10, 0, -9 }).ToList();
			CollectionAssert.AreEqual(new []{ 4, 10 }, result);
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
				TechIO.PrintMessage("Kudos 🌟", "You can filter positive integers!");
			}
		}
    }
}
