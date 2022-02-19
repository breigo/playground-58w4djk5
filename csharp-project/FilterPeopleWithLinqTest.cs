using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class FilterPeopleWithLinqTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			TechIO.PrintMessage("Input", People.Instance);
			var expected = People.Instance.Where(x => x.Age >= 30).ToList();
			var actual = new FilterPeopleWithLinq().KeepAdults(People.Instance).ToList();
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
				TechIO.PrintMessage("Hint 💡", "Have you properly implemented the method? 🤔");
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can query objects!");
			}
		}
    }
}
