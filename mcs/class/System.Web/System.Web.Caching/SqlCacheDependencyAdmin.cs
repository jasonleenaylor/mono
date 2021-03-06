//
// Authors:
//   Marek Habersack <mhabersack@novell.com>
//
// (C) 2010 Novell, Inc (http://novell.com/)
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Security.Permissions;
using System.Web;

namespace System.Web.Caching 
{
	[AspNetHostingPermission (SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.High)]
	public static class SqlCacheDependencyAdmin
	{
		public static string[] GetTablesEnabledForNotifications (string connectionString)
		{
			throw new NotImplementedException ();
		}

		public static void DisableNotifications (string connectionString)
		{
			throw new NotImplementedException ();
		}

		public static void DisableTableForNotifications (string connectionString, string table)
		{
			throw new NotImplementedException ();
		}
		
		public static void DisableTableForNotifications (string connectionString, string[] tables)
		{
			throw new NotImplementedException ();
		}

		public static void EnableNotifications (string connectionString)
		{
			throw new NotImplementedException ();
		}

		public static void EnableTableForNotifications (string connectionString, string table)
		{
			throw new NotImplementedException ();
		}

		public static void EnableTableForNotifications (string connectionString, string[] tables)
		{
			throw new NotImplementedException ();
		}
	}
}
