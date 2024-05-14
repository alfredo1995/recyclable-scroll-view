


https://github.com/alfredo1995/unity-infinite-reusable-scroll-view/assets/71193893/b714be7e-6b97-457c-8e19-f0c72ca3e869




<h3> Implementation of the infinite and recyclable ScrollView that can be used in mobile and desktop WebGL applications. </h3>

ScrollView.cs

    Managing the content of the ScrollView, organizing the arrangement and spacing of child items within it.    
   
InfiniteScroll.cs

    infinite scroll functionality for items dynamically reposition themselves when dragging or scrolling.(Determining drags, scroll events, mouse scroll wheel movement) 

ItemManager.cs

    Managing the dynamic creation of image items (Image) with specific colors, limiting the number of items created based on a color list (ColotList).

ColotList.cs
    
    Using ScriptableObject as a color list resource that can be created and managed in the Editor

DetectVisibility.cs

    Implementing a recycling mechanism (Object Pooling) to remove recycled color elements from the visible area in a scroll view.     
   
<br>
<h3> 2° Project Architecture (Component-Based Design) Single Responsibility </h3> 

    This software architecture for game development that follows principles of object-oriented design, modularity, and component reuse.

    Using the factory design pattern to create objects from a prefab, where objects are being created without the need for direct building code
    
    Using ScriptableObject to store a list of colors (ColorList) to hold data and settings that can be shared between multiple objects and instances during game execution.
    
<br>
<h3> 3° Applied optimization techniques and the results obtained. </h3>

    Using the object pooling technique to recycle existing elements instead of instantiating new objects whenever necessary.
    
    Dynamic creation of items based on a master list. Optimizing the set of objects and ensuring that elements are not used is disabled when they are off-screen to reduce resource usage.
    
    Use of prefabricated and reusable components, to contribute to the modularity and reuse of UI elements
    
    Handling ScrollViews with content correctly configured in terms of size, layout and positioning to improve UI fluidity and responsiveness   
    
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
> https://abre.ai/apk-scroll
