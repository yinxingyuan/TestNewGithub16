using MetaShare.Common.Core.Daos;
using TestGithubCodeSync.Entities;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.TestData;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Daos.Mocks
{
	public class ProductDaoMock : MockDao<Product>, IProductDao
	{
		public ProductDaoMock() : base(ProductTestData.CreateProduct())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
