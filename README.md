


https://github.com/alfredo1995/unity-infinite-reusable-scroll-view/assets/71193893/543619b6-ad68-44a6-9058-1bed693cf3aa




<h3> 1° Practical Implementation: Developed an infinite and recyclable ScrollView that can be used in mobile and desktop WebGL applications. </h3> 

Script (ScrollView)

    Logic: Managing the content of the ScrollView, organizing the arrangement and spacing of child items within it.
    
    Initial configuration of a flexible content layout within a RectTransform, taking into account margins and orientation (horizontal or vertical).
    
    Positioning of child elements within the parent object's RectTransform, maintaining an orderly and spaced arrangement according to the layout orientation (horizontal or vertical).

Script InfiniteScroll 

    Logic: Implementing infinite scroll functionality for a ScrollView, allowing items to dynamically reposition themselves when dragging or scrolling the ScrollView.
    
    ScrollRect to allow ("unrestricted") scrolling and movement based on the scrollContent properties, respectively.
        
    Determining when an object starts dragging with an OnBeginDrag function. While an object is being dragged (during pointer movement). Using the OnDrag function
    
    Scroll event, mouse scroll wheel movement. Returning the OnScroll call. Using the OnViewScroll() Function to handle scroll events in a view component.
    
    ReachedThreshold(Transform item) function checking whether an item has reached the limit for scrolling out of view in a ScrollView, based on the orientation (vertical or horizontal) of the ScrollView and the user's dragging direction.

Script ItemManager 

    Logic : Managing the dynamic creation of image items (Image) with specific colors, limiting the number of items created based on a color list (ColotList).

Script ColotList 
    
    Logic : Using ScriptableObject as a color list resource that can be created and managed in the Editor

Script DetectVisibility 

    Implementing a recycling mechanism (Object Pooling) to remove recycled color elements from the visible area in a scroll view. (Missing to calculate the visible area (height 290) of the scroll view is to define its height and top position, while the bottom coincides with the sum of the top position and the height of the view (total container height 2000)
    

<br>
<h3> 2° Project Architecture (Component-Based Design) for each component to have a specific responsibility, such as managing game logic, the appearance of objects and user interaction. </h3> 

    Content Management System: ItemManager handling dynamic creation of items in the UI based on a list of colors. Where objects are instantiated and dynamically managed at runtime.
    
    Factory Design Pattern: Using Instantiate to create objects from a prefab follows a simplified factory design pattern, where objects are created without the need for direct code construction, making the system more flexible and modular.
    
    Scriptable Objects: Using a ScriptableObject to store a list of colors (ColorList) is a common practice for maintaining data and settings that can be shared between multiple objects and instances during game execution.

    This software architecture for game development follows principles of object-oriented design, modularity and component reuse. Contributing to organized, flexible, and scalable code as your game project evolves.
    
<br>
<h3> 3° Applied optimization techniques and the results obtained. </h3>

    Use of Object Pooling: In the InfiniteScroll script, the object pooling technique is employed by recycling existing elements instead of instantiating new objects whenever necessary.     

    Dynamic Item Creation: In ItemManager, you dynamically create items based on a list of colors. This can be optimized by properly configuring the object pool and ensuring that unused elements are disabled when off-screen to reduce resource usage.

    Use of Prefabs and Reusable Components: The use of prefabs and reusable components such as Image, RectTransform, etc. contributes to the modularity and reusability of UI elements, which can improve development efficiency and UI performance.

    Configuration of ScrollViews: In the ScrollContent and InfiniteScroll scripts, you are dealing with the configuration and manipulation of ScrollViews. Ensuring that ScrollViews and their contents are configured correctly in terms of size, layout, and positioning can improve the fluidity and responsiveness of the UI, especially on devices with different      resolutions.
    
    Optimizing UI Updates: When working with elements that are dynamically updated in the UI, such as changes in color, size, or position, it is important to optimize the code to avoid unnecessary updates. For example, you can use efficient methods to modify UI elements only when necessary, thus minimizing update operations.

<br>  
<h3> 4 Project execution </h3> 

Unity Editor Installation

    install the Unity Editor in version 2022:3.27

Clone the repository:

    Locate and Select the desired cloning method, such as HTTPS or SSH

    Copy Clone URL: Copy the given clone URL. This URL represents the location of the repository on GitHub.

    Alternatively, you can use the hotkey (usually F5) to launch the game
 
<br>
<h3> 5 Game Execution: </h3> 

    Access the URL below to download and run the APK (Android) or IPA (iOS) file on your device and tap it to start installing and running the game. 
> https://abre.ai/webgl-scroll-view   

    Access the URL below to open a web browser (such as Chrome, Firefox, Safari, etc.) to load the game's main HTML file 
> https://abre.ai/apk-scroll-view
