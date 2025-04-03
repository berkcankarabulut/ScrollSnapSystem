using System;

namespace Project.ScrollSnapSystem.Runtime
{
    public interface ISnap
    {
        int SnappedIndex { get; }
        event Action<int> OnSnappedIndexUpdated;
    }
}