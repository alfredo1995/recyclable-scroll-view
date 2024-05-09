


https://github.com/alfredo1995/unity-infinite-reusable-scroll-view/assets/71193893/543619b6-ad68-44a6-9058-1bed693cf3aa




<h3> 1° Practical Implementation: Developed an infinite and recyclable ScrollView that can be used in mobile and desktop WebGL applications. </h3> 

ScrollView.cs

    Managing the content of the ScrollView, organizing the arrangement and spacing of child items within it.    
   
InfiniteScroll.cs

    Implementing infinite scroll functionality for a ScrollView, allowing items to dynamically reposition themselves when dragging or scrolling the ScrollView. checking whether an item has reached the limit for scrolling out of view in a ScrollView,
            
    Determining drags, scroll events, mouse scroll wheel movement, ScrollRect and handling them in view components        

ItemManager.cs

    Managing the dynamic creation of image items (Image) with specific colors, limiting the number of items created based on a color list (ColotList).

ColotList.cs
    
    Using ScriptableObject as a color list resource that can be created and managed in the Editor

DetectVisibility.cs

    Implementing a recycling mechanism (Object Pooling) to remove recycled color elements from the visible area in a scroll view. 
    
    Missing to calculate the visible area (height 290) of the scroll view is to define its height and top position, while the bottom coincides with the sum of the top position and the height of the view (total container height 2000)
    
<br>
<h3> 2° Project Architecture (Component-Based Design) for each component to have a specific responsibility, such as managing game logic, the appearance of objects and user interaction. </h3> 

    This software architecture for game development that follows principles of object-oriented design, modularity, and component reuse.

    Content management system to handle dynamic creation of items in the UI based on a list of colors. Where objects are instantiated and dynamically managed at runtime.

    The factory design pattern for creating objects from a prefab where objects are created without the need for direct code building

    Using ScriptableObject to store a list of colors (ColorList) to hold data and settings that can be shared between multiple objects and instances during game execution.
    
<br>
<h3> 3° Applied optimization techniques and the results obtained. </h3>

    Use of object pooling in the InfiniteScroll and DetectVisibility scripts, using the object pooling technique to recycle existing elements instead of instantiating new objects whenever necessary.

    Dynamic creation of items based on a master list. Optimizing the set of objects and ensuring that elements are not used disabled when they are off-screen to reduce resource usage.

    Use of pre-made and reusable components like Image, RectTransform, etc. Contributing to modularity and reuse of UI elements, improving development efficiency and performance.

    Manipulation of ScrollViews so that your content is correctly configured in terms of size, layout and positioning to improve UI fluidity and responsiveness

    Optimizing elements that dynamically update in the UI, such as color, size, or position changes
    
<br>  
<h3> 4° Project Execution </h3> 

Unity Editor Installation

    install the Unity Editor in version 2022:3.27

Clone the repository:

    Find and select the desired cloning method, such as HTTPS or SSH (Copy Clone URL)

    Alternatively, you can use the hotkey (usually F5) to launch the game
 
<br>
<h3> 5° App Execution: </h3> 

    Access the URL below to download and run the APK (Android) or IPA (iOS) file on your device and tap it to start installing and running the game. 
> https://abre.ai/webgl-scroll-view   

    Access the URL below to open a web browser (such as Chrome, Firefox, Safari, etc.) to load the game's main HTML file 
> https://abre.ai/apk-scroll-view
