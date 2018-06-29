using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class AllTests
	{
		[TestMethod]
		public void SimpleTrueMatch()
		{
			Assert.IsTrue(MiniRegex.MiniRegex.IsMatch("thun3cats", "thundercats"));
		}

		[TestMethod]
		public void ComplexTrueMatch()
		{
			Assert.IsTrue(MiniRegex.MiniRegex.IsMatch("th2de4s are on4 loose", "thundercats are on the loose"));
		}

		[TestMethod]
		public void NotAMatch()
		{
			Assert.IsFalse(MiniRegex.MiniRegex.IsMatch("this", "that"));
		}
	}
}