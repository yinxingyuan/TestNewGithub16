using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TestGithubCodeSync.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Web.Models
{
	public class ProductModel: CommonModel<Product>
	{

		public override void PopulateFrom(Product entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Product entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
