
// (c) viluon 2016 under MIT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmenaPenez
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] bankovky = { 5000,	2000,	1000,	500,	200,	100,	50,	20,	10,	5,	2,	1 };
			int[] in_stock = { 1,		5,		3,		1,		2,		0,		1,	17,	3,	1,	0,	3 };
			
			int castka = int.Parse( Console.ReadLine() );
			int index = 0;

			while( index < bankovky.Length )
			{
				int count = 0;
				int orig_amount = in_stock[ index ];

				while( castka % bankovky[ index ] < castka && in_stock[ index ] > 0 )
				{
					castka -= bankovky[ index ];
					count++;
					in_stock[ index ]--;
				}

				if( count > 0 )
				{
					Console.WriteLine( bankovky[ index ] + "  " + count + "/" + orig_amount );
				}

				index++;
			}

			if( castka > 0 )
			{
				Console.WriteLine( "\nNevratitelny zbytek:" + castka );
			}

			Console.ReadLine();
		}
	}
}
