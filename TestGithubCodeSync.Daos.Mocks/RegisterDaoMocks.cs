using MetaShare.Common.Core.Daos;
using TestGithubCodeSync.Daos.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(ItestEntityDao), new testEntityDaoMock(), isRegister);
			factory.Register(typeof(IProductDao), new ProductDaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
