using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class SelectFirstAdultWithLinqTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			TechIO.PrintMessage("Input", People.Instance);
			var expected = People.Instance.First(x => x.Age >= 30);
			var actual = SelectFirstAdultWithLinq.GetFirstAdult(People.Instance);
			TechIO.PrintMessage("Output", actual);
			
			Assert.AreEqual(expected, actual);
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
				TechIO.PrintMessage("Kudos 🌟", "You can query objects!");
			}
		}
    }
}
