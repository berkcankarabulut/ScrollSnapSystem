Unity Scroll Snap System
This project is a modular Scroll Snap system for Unity's UI, designed to manage scrolling and snapping functionality efficiently. It includes automatic scrolling, manual drag support, and button controls.

🚀 Features
✅ Modular Structure: The Snap class provides the core functionality, while ScrollSnap and AutoSnap extend its capabilities.
✅ Smooth Transitions: Uses Lerp for seamless scrolling animations.
✅ Automatic Snapping: AutoSnap smoothly aligns items based on the set speed.
✅ Drag Support: ScrollSnap implements IBeginDragHandler and IEndDragHandler for user interaction.
✅ Previous/Next Buttons: Navigation buttons for easy control.

📂 Code Structure
Snap.cs → Base class managing the snap mechanism

ScrollSnap.cs → Handles drag input and button-based navigation

AutoSnap.cs → Performs automatic scrolling with smooth transitions

SnapPositionCalculator.cs → Helper class for position calculations

📦 How to Use
Add the ScrollSnap or AutoSnap component to a Scroll View object.

Assign Snap items (RectTransform elements).

(Optional) Set up Previous/Next buttons for navigation.

🎉 You're ready to go! Smooth scrolling and snapping are now working.

🛠 Potential Improvements
📌 Using SmoothDamp instead of Lerp for even smoother motion.
📌 Making SnapPositionCalculator a static class to optimize memory usage.
📌 Adding null checks for scrollPanel to improve error handling.
