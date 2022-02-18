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
			var input = new[] { -5, 4, 10, 0, -9 };
			
			TechIO.PrintMessage("Input", input);
			var actual = FilterWithoutLinq.KeepPositiveNumbers(input).ToList();
			TechIO.PrintMessage("Output", actual);

			CollectionAssert.AreEqual(new []{ 4, 10 }, actual);
			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{	
				// On Failure
				TechIO.PrintMessage("Hint 💡", "Have you properly implemented the method? 🤔");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can filter positive integers!");
			}
		}
    }
}
