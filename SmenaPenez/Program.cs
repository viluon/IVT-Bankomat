
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
			// Typy bankovek/minci
			int[] bankovky = { 5000,	2000,	1000,	500,	200,	100,	50,	20,	10,	5,	2,	1 };
			// Pocty bankovek ktere ma bankomat k dispozici. Index odpovida indexu v array bankovky
			int[] in_stock = { 1,		5,		3,		1,		2,		0,		1,	17,	3,	1,	0,	3 };
			
			// Napiste castku k vraceni
			int castka = int.Parse( Console.ReadLine() );
			int index = 0;

			// Iterujeme pres vsechny velikosti bankovkek, od nejvetsi k nejmensi
			while( index < bankovky.Length )
			{
				// Pocet bankovek vydanych
				int count = 0;
				// Ulozime si pocet bankovek tohoto typu celkem k pozdejsimu vyuziti
				int orig_amount = in_stock[ index ];

				// Dokud se castka da zmensit bankovkou tohoto typu a nejake tohoto typu porad zbyvaji
				while( castka % bankovky[ index ] < castka && in_stock[ index ] > 0 )
				{
					// Odecteme velikost bankovky od celkove castky
					castka -= bankovky[ index ];
					// Pridame k poctu vydanych bankovek tohoto typu
					count++;
					// Odecteme ze zbyvajicich bankovek tohoto typu
					in_stock[ index ]--;
				}

				// Vypiseme na obrazovku jen v pripade, ze alespon nejake bankovky teto velikosti vydane byly
				if( count > 0 )
				{
					Console.WriteLine( bankovky[ index ] + "  " + count + "/" + orig_amount );
				}

				// Pricteme 1 k indexu a posuneme se tak na dalsi typ bankovky
				index++;
			}

			// Pokud se castku nepodarilo zmensit na 0
			if( castka > 0 )
			{
				Console.WriteLine( "\nNevratitelny zbytek:" + castka );
			}

			// Konec programu
			Console.ReadLine();
		}
	}
}
