using System.Collections.Generic;
using NUnit.Framework;
using System;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.Daos.DataSchema;
using TestGithubCodeSync.TestData;
using TestGithubCodeSync.Daos.Tests.Common;
using TestGithubCodeSync.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Daos.Tests
{
	public class testEntityDaoTest : CommonDaoTest<testEntity, ItestEntityDao, testEntityDdlBuilder>
	{
		public testEntityDaoTest() : base(testEntityTestData.CreatetestEntity())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(testEntityTestData.testEntityCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			testEntity item = testEntityTestData.CreatetestEntity1();
			testEntity find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			testEntityTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			testEntity item = new testEntity
			{
				Name = string.Empty, 
				mystring = string.Empty, 
				Description = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			testEntity find = this.Dao.SelectById(this.Context, item);
			testEntityTestData.AssertAreEqual(item, find);

			List<testEntity> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(testEntityTestData.testEntityCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			testEntity item = testEntityTestData.CreatetestEntity1();
			testEntity beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Name = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			testEntity afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			testEntityTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			testEntity item = testEntityTestData.CreatetestEntity1();
			testEntity beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			testEntity afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<testEntity> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(testEntityTestData.testEntityCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
