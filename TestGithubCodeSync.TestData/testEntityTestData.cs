using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestGithubCodeSync.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.TestData
{
	public class testEntityTestData
	{
		public const int testEntityCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<testEntity> CreatetestEntity()
		{
			return new List<testEntity>
			{
				CreatetestEntity1(),
				CreatetestEntity2(),
				CreatetestEntity3(),
			};
		}

		 public static testEntity CreatetestEntity1()
		{
			return new testEntity
			{
					Id = 1, 
					Name = string.Empty, 
					mystring = string.Empty, 
					Description = string.Empty, 
			};
		}
		 public static testEntity CreatetestEntity2()
		{
			return new testEntity
			{
					Id = 2, 
					Name = string.Empty, 
					mystring = string.Empty, 
					Description = string.Empty, 
			};
		}
		 public static testEntity CreatetestEntity3()
		{
			return new testEntity
			{
					Id = 3, 
					Name = string.Empty, 
					mystring = string.Empty, 
					Description = string.Empty, 
			};
		}
		public static void AssertAreEqual(testEntity expected, testEntity actual)
		{
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.mystring, actual.mystring);
			Assert.AreEqual(expected.Description, actual.Description);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
