using System.Collections.ObjectModel;
using System.Linq;

namespace Items
{
	public sealed class MainWindowViewModel
	{
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>(Enumerable.Range(0, 100).Select(_ => new Item()));
	}
}