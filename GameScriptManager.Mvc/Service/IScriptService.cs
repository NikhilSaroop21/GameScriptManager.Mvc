using System.Collections.Generic;
using GameScriptManager.Mvc.Models;

namespace GameScriptManager.Mvc.Services
{
    public interface IScriptService
    {
        IReadOnlyList<StoryNode> GetSortedScript(); // 1..N
        int Count { get; }
        StoryNode? GetLine(int index); // 0-based
    }
}
