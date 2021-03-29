using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Practic.Repos
{
	public class DBContext<T> : IReadAllFromDB<T>
	{
		public List<T> ReadAll()
		{
			try
			{
				using (IDbConnection db = new SqlConnection(Path.path))
				{
					return db.Query<T>($"SELECT * FROM {typeof(T).Name}").ToList();
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
