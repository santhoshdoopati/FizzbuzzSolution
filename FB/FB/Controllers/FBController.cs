using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FB.Controllers
{
    public class FBController : ApiController
    {

		public string GetFIZZBUZZString(int startNum, int limit)
		{
			string fizzBuzz = string.Empty;
			string[] result = new string[(limit - startNum) + 1];
			int x = 0;
			for (int i = startNum; i <= limit; i++)
			{
				if ((i % 3 == 0) && (i % 5 == 0))
				{
					result[x] = "FIZZBUZZ";
				}
				else if (i % 3 == 0)
				{
					result[x] = "FIZZ";
				}
				else if (i % 5 == 0)
				{
					result[x] = "BUZZ";

				}
				else
					result[x] = i.ToString();
				x++;
			}
			fizzBuzz = string.Join(",", result);

			if (result == null)
			{
				return NotFound().ToString();
			}
			return fizzBuzz;
		}
	}
}
