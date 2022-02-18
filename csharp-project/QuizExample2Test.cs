using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class QuizExample2Test
    {
		private bool shouldShowHint = false;

		private List<Person> Expected {
			get {
				return People.Instance
					.Where(p => p.Age >= 30)
					.OrderBy(p => p.Name)
					.ToList();
			}
		}

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			TechIO.PrintMessage("Input", People.Instance);
			var actual = QuizExample2.GetSortedAdults(People.Instance).ToList();
			TechIO.PrintMessage("Output", actual);
			
			CollectionAssert.AreEqual(Expected, actual);

			shouldShowHint = false;
		}

		[TestCleanup()]
		public void Cleanup()
		{
			if(shouldShowHint)
			{
				TechIO.PrintMessage("Expected", Expected);

				// On Failure
				TechIO.PrintMessage("Hint 💡", "Did you properly implemented the method? 🤔");
				TechIO.PrintMessage("Hint 💡", "");
				TechIO.PrintMessage("Hint 💡", "Use Where() to filter elements.");
				TechIO.PrintMessage("Hint 💡", "Use OrderBy() to sort elements.");
				TechIO.PrintMessage("Hint 💡", "You can chain LINQ methods.");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can query objects!");
			}
		}
    }
}
