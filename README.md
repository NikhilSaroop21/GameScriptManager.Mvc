🌌 Game Script Manager – Zara the Stardust Courier

A playful ASP.NET Core MVC project demonstrating data structures + fun UI design.
It uses a custom Linked List (not the built-in one!) and sorts an unordered story using linked-list merge sort, then displays it in two modes with a modern, gradient UI.

✨ Features

🧱 Custom Linked List (StoryNode, StoryLinkedList)

🔀 Linked-List Merge Sort (O(n log n), no arrays/lists used)

📖 Two viewing modes:

Full Story (all paragraphs in order)

Line-by-Line with Next / Previous navigation + progress indicator

🎨 Cool Design: animated gradients, glassmorphism cards, glowing chips

🕹️ Fun Story: Zara the Stardust Courier

🧩 The Story (Sorted)
1  In the sky city of Lumina, Zara, a rookie stardust courier, receives her first midnight delivery.
2  With her hoverboard Nebula and a map of shifting constellations, she dives into the wind tunnels between towers.
3  Each checkpoint leaves a comet mark on her wristband, humming with stored momentum.
4  A rogue wind spirit, Siro, scrambles her compass and scatters the stardust canisters across the Neon Archipelago.
5  Zara lands at Echo Docks where a puzzle lock echoes her footsteps; she solves rhythms to retrieve the first canister.
6  In the Mistral Markets, code-weavers trade breeze scripts; Zara barters a tune to mend her compass.
7  She teams up with Kade, a mechanic who grafts a microthruster tail onto Nebula for tighter drift-turns.
8  At Thunderbridge, she outruns bolt-hounds by surfing the rail’s humming resonance.
9  Siro returns, but Zara calms it with a wind-song learned from old sky-charts, turning the spirit into an ally.
10 Together they cross the Cloud Reef maze, where magnetic tides try to peel the cargo away.
11 Zara completes the midnight route, the city’s auroras brighten as every home receives a pinch of stardust sleep.
12 Promoted to Keeper Courier, Zara and Siro prepare the dawn route—because in Lumina, the sky never runs out of stories.

🏗️ Tech Stack

.NET 8 (works on .NET 6/7 too)

ASP.NET Core MVC

Bootstrap + Custom CSS (animated gradients, blur, neon chips)



🚀 Getting Started
Prerequisites

Visual Studio 2022 (or VS Code + C# Dev Kit)

.NET 8 SDK

Run Locally
git clone <your-repo>
cd GameScriptManager.Mvc
dotnet run


Visit:

Full Story → http://localhost:5000/Script/Index

Line-by-Line → http://localhost:5000/Script/Line

🖼️ Screenshots (add once you run it)

🌈 Full Story mode: All sorted paragraphs in a glowing glass card.

🛹 Line-by-Line mode: Navigate Zara’s sky journey step-by-step.

🎨 Theming

Animated gradient background

Glassmorphism cards

Gradient text headers

Glow chips for story numbers

Subtle fade animations for smoother UX

✅ Requirements Mapping

Linked List → StoryNode, StoryLinkedList

Populate unordered data → ScriptService

Sorting algorithm → Linked-list merge sort

GUI with two modes → MVC Views

Interaction features → Next/Prev navigation, mode switching

Smooth transitions → CSS animations

📜 License

MIT – free to learn, remix, and use.
