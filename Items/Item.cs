using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Items
{
	public sealed class Item
	{
		public string Name { get; } = Guid.NewGuid().ToString();
		public ObservableCollection<SubItem> SubItems { get; set; } = new ObservableCollection<SubItem>(Enumerable.Range(0, 10).Select(_ => new SubItem()));
		public int Year { get; } = new Random().Next(1000, 2000);
	}
}