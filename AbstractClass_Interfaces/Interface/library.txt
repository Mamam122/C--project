using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidangdatar
{
    public class menghitung
	{
		public double persegi(double sisi)
		{
			return 4*sisi;
		}
		public double luasPersegi(double sisi)
		{
			return sisi * sisi;
		}
		public double persegipanjang(double panjang, double lebar)
		{
			return 2 * (panjang + lebar);
		}
		public double LuasPersegipanjang(double panjang, double lebar)
		{
			return panjang * lebar;
		}
		public double luasSegitiga(double alas, double tinggi)
		{
			return alas * tinggi / 2;
		}
	}
}
