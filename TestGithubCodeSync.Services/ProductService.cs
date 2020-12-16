using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using TestGithubCodeSync.Entities;
using MetaShare.Common.Core.Services;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Services
{
	public class ProductService : Service<Product>, IProductService
	{
		public ProductService() : base(typeof (IProductDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
