using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterWithLinqExerciseTest
    {
		private bool shouldShowHint = false;

		private int[] Input {
			get{
				return new[] { -5, 4, 10, 0, -9 };
			}
		}
		
		private List<int> Expected {
			get {
				return Input.Where(x => x == 0).ToList();
			}
		}

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			var target = new FilterWithLinqExercise();
			var actual = target.KeepZeros(Input).ToList();

			TechIO.PrintMessage("Input", Input);
			TechIO.PrintMessage("Output", actual);

			CollectionAssert.AreEqual(Expected, actual);

			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{	
				// On Failure
				TechIO.PrintMessage("Hint 💡", "Have you properly implemented the methods? 🤔");
				TechIO.PrintMessage("Hint 💡", "");
				TechIO.PrintMessage("Hint 💡", "Use Where() to filter elements.");
				TechIO.PrintMessage("Hint 💡", "You can compare to integers for equality with 'a == b'.");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can filter integers!");
			}
		}
    }
}
