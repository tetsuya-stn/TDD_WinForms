using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
	public class DBAccess: IDBAccess
	{
		public int GetDBValue()
		{
			//本来はDBに接続
			return 200;
		}
	}
}
