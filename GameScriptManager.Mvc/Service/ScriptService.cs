using System.Collections.Generic;
using System.Linq;
using GameScriptManager.Mvc.Models;

namespace GameScriptManager.Mvc.Services
{
    public class ScriptService : IScriptService
    {
        private readonly StoryLinkedList _list;

        public ScriptService()
        {
            _list = new StoryLinkedList();

            // NEW ✨ "Zara the Stardust Courier" (unordered on purpose)
            _list.AddLast(8, "At Thunderbridge, she outruns bolt-hounds by surfing the rail’s humming resonance.");
            _list.AddLast(2, "With her hoverboard Nebula and a map of shifting constellations, she dives into the wind tunnels between towers.");
            _list.AddLast(12, "Promoted to Keeper Courier, Zara and Siro prepare the dawn route—because in Lumina, the sky never runs out of stories.");
            _list.AddLast(4, "A rogue wind spirit, Siro, scrambles her compass and scatters the stardust canisters across the Neon Archipelago.");
            _list.AddLast(10, "Together they cross the Cloud Reef maze, where magnetic tides try to peel the cargo away.");
            _list.AddLast(5, "Zara lands at Echo Docks where a puzzle lock echoes her footsteps; she solves rhythms to retrieve the first canister.");
            _list.AddLast(7, "She teams up with Kade, a mechanic who grafts a microthruster tail onto Nebula for tighter drift-turns.");
            _list.AddLast(3, "Each checkpoint leaves a comet mark on her wristband, humming with stored momentum.");
            _list.AddLast(1, "In the sky city of Lumina, Zara, a rookie stardust courier, receives her first midnight delivery.");
            _list.AddLast(9, "Siro returns, but Zara calms it with a wind-song learned from old sky-charts, turning the spirit into an ally.");
            _list.AddLast(6, "In the Mistral Markets, code-weavers trade breeze scripts; Zara barters a tune to mend her compass.");
            _list.AddLast(11, "Zara completes the midnight route, the city’s auroras brighten as every home receives a pinch of stardust sleep.");

            _list.Sort(); // keep: linked-list merge sort
        }

        public int Count => _list.Count;

        public IReadOnlyList<StoryNode> GetSortedScript()
            => _list.Enumerate().ToList();

        public StoryNode? GetLine(int index)
            => index >= 0 && index < _list.Count ? _list.GetAt(index) : null;
    }
}
