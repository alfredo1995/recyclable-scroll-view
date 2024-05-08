<h2>  ScrollView in Unity infinite and recyclable, optimized to handle a large number of elements without compromising performance. </h2> 

![unity-infinite-reusable-scroll-view](https://github.com/alfredo1995/infinite-scroll-view/assets/71193893/6d877a7f-02d5-4911-83a3-8685e4d142da)

<h3> 1° Practical Implementation: Developed an infinite and recyclable ScrollView that can be used in mobile and desktop WebGL applications. </h3> 

ScrollView 

    Logic: Managing the content of the ScrollView, organizing the arrangement and spacing of child items within it.
    
    Initial configuration of a flexible content layout within a RectTransform, taking into account margins and orientation (horizontal or vertical).
    
    Positioning of child elements within the parent object's RectTransform, maintaining an orderly and spaced arrangement according to the layout orientation (horizontal or vertical).

InfiniteScroll 

    Logic: Implementing infinite scroll functionality for a ScrollView, allowing items to dynamically reposition themselves when dragging or scrolling the ScrollView.
    
    ScrollRect to allow scrolling and moving ("unconstrained") based on scrollContent properties, respectively.
    
    Determining when an object starts to be dragged. Using an OnBeginDrag(PointerEventData eventData) callback function that is part of the IBeginDragHandler interface.
    
    Determining while an object is being dragged (during pointer movement). Using OnDrag(PointerEventData eventData) callback function from IDragHandler interface.
    
    Scroll event, movement of the mouse scroll wheel. Using an OnScroll(PointerEventData eventData) callback from the IScrollHandler interface. OnViewScroll() function to handle scroll events in a view component.
    
    ReachedThreshold(Transform item) function checking whether an item has reached the limit for scrolling out of view in a ScrollView, based on the orientation (vertical or horizontal) of the ScrollView and the user's dragging direction.

ItemManager 

    Logic : Managing the dynamic creation of image items (Image) with specific colors, limiting the number of items created based on a color list (ColotList).

ColotList 
    
    Logic : Using ScriptableObject as a color list resource that can be created and managed in the Editor

<br>
<h3> 2° Project Architecture (Component-Based Design) for each component to have a specific responsibility, such as managing game logic, the appearance of objects and user interaction. </h3> 

    Content Management System: ItemManager handling dynamic creation of items in the UI based on a list of colors. Where objects are instantiated and dynamically managed at runtime.
    
    Factory Design Pattern: Using Instantiate to create objects from a prefab follows a simplified factory design pattern, where objects are created without the need for direct code construction, making the system more flexible and modular.
    
    Scriptable Objects: Using a ScriptableObject to store a list of colors (ColorList) is a common practice for maintaining data and settings that can be shared between multiple objects and instances during game execution.

    This software architecture for game development follows principles of object-oriented design, modularity and component reuse. Contributing to organized, flexible, and scalable code as your game project evolves.
<br>
<h3> Applied optimization techniques and the results obtained.

    Use of Object Pooling: In the InfiniteScroll script, the object pooling technique is employed by recycling existing elements instead of instantiating new objects whenever necessary. This helps reduce memory usage and processing associated with frequently creating and destroying objects in the UI.

    Dynamic Item Creation: In ItemManager, you dynamically create items based on a list of colors. This can be optimized by properly configuring the object pool and ensuring that unused elements are disabled when off-screen to reduce resource usage.

    Use of Prefabs and Reusable Components: The use of prefabs and reusable components such as Image, RectTransform, etc. contributes to the modularity and reusability of UI elements, which can improve development efficiency and UI performance.

    Configuration of ScrollViews: In the ScrollContent and InfiniteScroll scripts, you are dealing with the configuration and manipulation of ScrollViews. Ensuring that ScrollViews and their contents are configured correctly in terms of size, layout, and positioning can improve the fluidity and responsiveness of the UI, especially on devices with different      resolutions.
    
    Optimizing UI Updates: When working with elements that are dynamically updated in the UI, such as changes in color, size, or position, it is important to optimize the code to avoid unnecessary updates. For example, you can use efficient methods to modify UI elements only when necessary, thus minimizing update operations.
    
