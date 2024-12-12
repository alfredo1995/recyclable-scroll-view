https://github.com/alfredo1995/recyclable-scroll-view/assets/71193893/a8eeb87b-7a91-49e0-b19a-96e2ca49db6d

<h3> Implementation of infinite and recyclable ScrollView for mobile and desktop WebGL applications </h3>

ScrollRectPool.cs

    Manages a pool of objects (represented by GameObjects) in a ScrollRect, allowing you to activate objects as needed to avoid frequent object creation and destruction, which can be more efficient in terms of performance.

Item.cs

    Controls the behavior of an item in the scene, allowing it to be activated, deactivated, and have its text updated as needed. Keeps track of whether the item is visible or invisible, for managing the object pool system.

ItemList.cs

    Using ScriptableObject to create a custom data type called ItemList that is being used to store a list of strings.

InfiniteScroll.cs

    Infinite scroll logic for a list of items in a ScrollRect, moving the items up or down, and updating the visible items with new data from the item list.

CheckVisibility.cs

    Managing the visibility of items in a list within a ScrollRect, activating and deactivating (Object Pooling) the items as they enter and leave the visible area of ​​the list (interacts with the InfiniteScroll component to handle infinite scrolling of the list).

<br>
<h3> Optimization techniques applied and results obtained. </h3>

    Object Pooling to recycle existing elements instead of instantiating new objects whenever necessary.
    Avoiding frequent allocation and deallocation of memory, reducing garbage collector overhead.

    Singleton for Single Instance Management in the CheckVisibility script,
    Avoiding multiple unnecessary memory allocations for the same object and simplifying global state management.

    Optimizing the object pool and ensuring that unused elements are disabled when they are off-screen to reduce resource usage.

    Checks whether an item is visible or not, such as calculating the position of the item and the visible corners of the list.

    Avoiding unnecessary or complex calculations that could negatively impact performance.

<br>
<h3> Running the Project</h3>

    Installing the Unity Editor

install the Unity Editor version 2022:3.27

Clone the repository:

    Find and select the desired cloning method, such as HTTPS or SSH (Copy Clone URL)

<br>
<h3> Running the application:</h3>

    Access the URL below to download and run the APK (Android) or IPA (iOS) file on your device.
    
    > https://abre.ai/apk-scroll
