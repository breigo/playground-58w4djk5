using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterWithFuncBTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			
			var input = new[] { -5, 4, 10, 0, -9 };
			
			TechIO.PrintMessage("Input", input);
			var actual = FilterWithFuncB.KeepNegativeNumbers(input).ToList();
			TechIO.PrintMessage("Output", actual);

			CollectionAssert.AreEqual(new []{ -5, -9 }, actual);

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
