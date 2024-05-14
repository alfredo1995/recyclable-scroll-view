using UnityEngine.UI;
using UnityEngine;

public class CheckVisibility : MonoBehaviour
{   
    public static CheckVisibility Instance; 

    public RectTransform[] imageRectTransform;
    public RectTransform topLeftCorner;
    public RectTransform bottomLeftCorner;
    public ScrollRect scrollRect;
    public InfiniteScroll infiniteScroll; 

    public bool isBetweenCorners;

    private void Awake() 
    {
        Instance = this;
    }

    private void Start()
    {
        //OnScrollRectValueChanged(new Vector2(0,0));
        scrollRect.onValueChanged.AddListener(OnScrollRectValueChanged);
    }

    void OnScrollRectValueChanged(Vector2 value)
    {
        Item itemComp = null;

        foreach (var item in imageRectTransform)
        {
            itemComp = item.GetComponent<Item>();

            if (IsBetweenCorners(item))
            {
                itemComp.BecameVisible();
            }
            else
            {
                if (!itemComp.isInvisivble)
                {
                    if (item.position.y > topLeftCorner.position.y)
                        itemComp.above = true;
                    else if (item.position.y < bottomLeftCorner.position.y)
                        itemComp.above = false;

                    infiniteScroll.HandleVerticalScroll(item);
                }

                itemComp.BecameInvisible();
            }
        }
    }

    public bool IsBetweenCorners(RectTransform item)
    {
        Vector3 topLeftCornerPosition = topLeftCorner.position;
        Vector3 bottomLeftCornerPosition = bottomLeftCorner.position;

        Vector3 imagePosition = item.position;

        bool isBetweenCorners = imagePosition.y > bottomLeftCornerPosition.y && imagePosition.y < topLeftCornerPosition.y;

        return isBetweenCorners;
    }
}
