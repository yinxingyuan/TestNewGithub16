using MetaShare.Common.Core.Daos;
using TestGithubCodeSync.Entities;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.TestData;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Daos.Mocks
{
	public class testEntityDaoMock : MockDao<testEntity>, ItestEntityDao
	{
		public testEntityDaoMock() : base(testEntityTestData.CreatetestEntity())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
