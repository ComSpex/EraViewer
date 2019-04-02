using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EraViewer {
	class Program {
		static void Main(string[] args) {
			Calendar era = new NewJapaneseCalendar();
			string[] names = { "江戸","明治","大正","昭和","平成","令和" };
			DateTime target = new DateTime(2019,4,30);
			Console.WriteLine("{1:ddMMMyyyy} is of {0}",names[era.GetEra(target)],target);
		}
	}
	public class NewJapaneseCalendar:JapaneseCalendar {
		public override int GetEra(DateTime time) {
			DateTime newEra = new DateTime(2019,5,1);
			int index = base.GetEra(time);
			if(time<newEra) {
				return index;
			}
			return ++index;
		}
	}
}
