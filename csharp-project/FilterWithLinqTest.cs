using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterWithLinqTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			var input = new[] { -5, 4, 10, 0, -9 };
			var target = new FilterWithLinq();

			TechIO.PrintMessage("Input", input);
			var actualPositive = target.KeepPositiveNumbers(input).ToList();
			var actualNegative = target.KeepNegativeNumbers(input).ToList();
			TechIO.PrintMessage("Output - KeepPositiveNumbers", actualPositive);
			TechIO.PrintMessage("Output - KeepNegativeNumbers", actualNegative);
			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{	
				// On Failure
				TechIO.PrintMessage("Hint 💡", "Have you properly implemented the methods? 🤔");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can filter integers!");
			}
		}
    }
}
