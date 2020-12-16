using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using TestGithubCodeSync.Daos.Interfaces;
using TestGithubCodeSync.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestGithubCodeSync.Daos
{
	public class testEntityDao : CommonObjectDao<testEntity>, ItestEntityDao
	{
		public class testEntitySqlBuilder : ObjectSqlBuilder
		{
			public testEntitySqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"testEntity")
			{
				this.SqlInsert = "INSERT INTO testEntity (mystring," + this.SqlBaseFieldInsertFront + ") VALUES (@mystring," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE testEntity SET mystring=@mystring," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class testEntityResultHandler : CommonObjectResultHandler<testEntity>
		{
			public override void GetColumnValues(IDataReader reader, testEntity item)
			{
				base.GetColumnValues(reader, item);
				int ordinalmystring = reader.GetOrdinal("mystring");
				item.mystring = reader.IsDBNull(ordinalmystring) ? null : reader.GetString(ordinalmystring);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, testEntity item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "mystring", item.mystring ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public testEntityDao(SqlDialect sqlDialect) : base(new testEntitySqlBuilder(sqlDialect), new testEntityResultHandler())
		{
		}

		public testEntityDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new testEntitySqlBuilder(sqlDialect), new testEntityResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
