using System;

namespace Items
{
	public sealed class SubItem
	{
		public string Name { get; } = Guid.NewGuid().ToString();
	}
}