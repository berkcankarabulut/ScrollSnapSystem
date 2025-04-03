<!DOCTYPE html>
<html lang="en">

<body> 
    <h1>Unity Scroll Snap System</h1>
    <p>This project is a modular Scroll Snap system for Unity's UI, designed to manage scrolling and snapping functionality efficiently. It includes automatic scrolling, manual drag support, and button controls.</p>
    <h2>🚀 Features</h2>
    <ul>
        <li><strong>Modular Structure:</strong> The <code>Snap</code> class provides the core functionality, while <code>ScrollSnap</code> and <code>AutoSnap</code> extend its capabilities.</li>
        <li><strong>Smooth Transitions:</strong> Uses <code>Lerp</code> for seamless scrolling animations.</li>
        <li><strong>Automatic Snapping:</strong> <code>AutoSnap</code> smoothly aligns items based on the set speed.</li>
        <li><strong>Drag Support:</strong> <code>ScrollSnap</code> implements <code>IBeginDragHandler</code> and <code>IEndDragHandler</code> for user interaction.</li>
        <li><strong>Previous/Next Buttons:</strong> Navigation buttons for easy control.</li>
    </ul>
    <h2>📂 Code Structure</h2>
    <ul>
        <li><code>Snap.cs</code> → Base class managing the snap mechanism</li>
        <li><code>ScrollSnap.cs</code> → Handles drag input and button-based navigation</li>
        <li><code>AutoSnap.cs</code> → Performs automatic scrolling with smooth transitions</li>
        <li><code>SnapPositionCalculator.cs</code> → Helper class for position calculations</li>
    </ul>
    <h2>📦 How to Use</h2>
    <ol>
        <li>Add the <code>ScrollSnap</code> or <code>AutoSnap</code> component to a <strong>Scroll View</strong> object.</li>
        <li>Assign <strong>Snap items</strong> (RectTransform elements).</li>
        <li>(Optional) Set up <strong>Previous/Next buttons</strong> for navigation.</li>
    </ol>
    <p>🎉 <strong>You're ready to go!</strong> Smooth scrolling and snapping are now working.</p>

</body>
</html>
