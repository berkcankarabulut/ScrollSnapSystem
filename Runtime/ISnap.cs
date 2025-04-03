using System;

namespace Project.ScrollSnapSystem
{
    public interface ISnap
    {
        int SnappedIndex { get; }
        event Action<int> OnSnappedIndexUpdated;
    }
}