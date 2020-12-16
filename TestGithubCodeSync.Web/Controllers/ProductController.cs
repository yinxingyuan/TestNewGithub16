using TestGithubCodeSync.Entities;
using System.Collections.Generic;
using TestGithubCodeSync.Services.Interfaces;
using TestGithubCodeSync.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Web.Controllers
{
	public class ProductController:CommonController<Product, IProductService, ProductModel>
	{


		protected override List<Product> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Product> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Product { Name = pagerSearchModel.Name }, product => product.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
