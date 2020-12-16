using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TestGithubCodeSync.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Web.Models
{
	public class testEntityModel: CommonModel<testEntity>
	{
		public string mystring {get; set;}

		public override void PopulateFrom(testEntity entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.mystring = entity.mystring;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(testEntity entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.mystring = this.mystring;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
