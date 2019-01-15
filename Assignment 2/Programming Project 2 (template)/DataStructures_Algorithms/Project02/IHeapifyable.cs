using System;

namespace DataStructures_Algorithms.Project02
{
	public interface IHeapifyable<D, K>
	{
		D Data { get; set; }
		K Key { get; }

		int Position { get; }
	}
}