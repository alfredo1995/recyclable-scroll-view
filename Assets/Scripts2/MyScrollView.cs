using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyScrollView : MonoBehaviour, IEndDragHandler, IBeginDragHandler
{
    public ScrollRect scrollRect = null;
    private Vector2 previousScrollPosition;
    public float lastPosition = 0f;

    public void OnBeginDrag(PointerEventData eventData)
    {
        lastPosition = scrollRect.content.position.y;
        print("BeginDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (scrollRect.content.position.y > lastPosition)
        {
            Debug.Log("Scrolling Up");
        }
        else if (scrollRect.content.position.y < lastPosition)
        {
            Debug.Log("Scrolling Down");
        }
    }

    protected void Start()
    {
        previousScrollPosition = scrollRect.normalizedPosition;
    }
}
