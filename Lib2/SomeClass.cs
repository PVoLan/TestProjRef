
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lib2
{
	public class SomeClass
	{
		public static void DoSmth()
		{
#if DEBUG
			Console.WriteLine ("Lib2.SomeClass.DoSmth Debug mode");
#else
			Console.WriteLine ("Lib2.SomeClass.DoSmth Release mode");
#endif
		}
	}
}

