﻿using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TechIo
{
    [TestClass]
    public class SortPeopleWithLinqTest
    {
		private bool shouldShowHint = false;

		[TestMethod]
		public void Verify() 
		{
			shouldShowHint = true;
			TechIO.PrintMessage("Input", People.Instance);
			
			var expected = People.Instance
				.OrderBy(p => p.Name)
				.ThenByDescending(p => p.Age)
				.ToList();
			
			var actual = SortPeopleWithLinq.SortByNameAndAge(People.Instance).ToList();
			
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
			} 
			else
			{
				TechIO.PrintMessage("Kudos 🌟", "You can query objects!");
			}
		}
    }
}
