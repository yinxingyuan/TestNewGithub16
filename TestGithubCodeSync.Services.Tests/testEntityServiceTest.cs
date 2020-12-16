using System;
using System.Collections.Generic;
using NUnit.Framework;
using TestGithubCodeSync.Entities;
using TestGithubCodeSync.TestData;
using TestGithubCodeSync.Services.Tests.Common;
using TestGithubCodeSync.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Services.Tests
{

	[TestFixture]
	public class testEntityServiceTest : CommonServiceTest<testEntity, ItestEntityService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<testEntity> items = this.Service.SelectAll();
			Assert.AreEqual(testEntityTestData.testEntityCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			testEntity itemTest = testEntityTestData.CreatetestEntity1();

			List<testEntity> find = this.Service.SelectBy(new testEntity {Name = itemTest.Name}, new List<string> {"Name"});
			Assert.IsNotNull(find);

			foreach (testEntity item in find)
			{
				Assert.AreEqual(itemTest.Name, item.Name);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			testEntity itemTest = testEntityTestData.CreatetestEntity1();

			testEntity find = this.Service.SelectById(new testEntity {Id = itemTest.Id});
			Assert.IsNotNull(find);

			testEntityTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			testEntity itemTest = testEntityTestData.CreatetestEntity2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<testEntity> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, testEntityTestData.testEntityCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			testEntity itemTest = new testEntity
			{
				Name = string.Empty, 
				mystring = string.Empty, 
				Description = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<testEntity> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, testEntityTestData.testEntityCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			testEntity itemTest = testEntityTestData.CreatetestEntity1();

			testEntity beforeUpdate = this.Service.SelectById(new testEntity {Id = itemTest.Id});
			beforeUpdate.Name = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			testEntity afterUpdate = this.Service.SelectById(new testEntity {Id = itemTest.Id});
			testEntityTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
