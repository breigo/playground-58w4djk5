using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class QuizExample2Test
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			TechIO.PrintMessage("Input", People.Instance);
			var expected = People.Instance
				.Where(p => p.Age >= 30)
                .OrderBy(p => p.Name)
				.ToList();
			var actual = QuizExample2.GetSortedAdults(People.Instance).ToList();
			TechIO.PrintMessage("Output", actual);
			
			CollectionAssert.AreEqual(expected, actual);
			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{	
				// On Failure
				TechIO.PrintMessage("Hint 💡", "Did you properly implemented the method? 🤔");
				TechIO.PrintMessage("Hint 💡", "");
				TechIO.PrintMessage("Hint 💡", "Use Where() to filter elements.");
				TechIO.PrintMessage("Hint 💡", "Use OrderBy() to sort elements.");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can query objects!");
			}
		}
    }
}
