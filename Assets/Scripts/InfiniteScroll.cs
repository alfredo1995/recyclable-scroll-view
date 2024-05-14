using UnityEngine;
using UnityEngine.UI;

public class InfiniteScroll : MonoBehaviour
{
    [SerializeField] public ScrollRect scrollRect;

    public int currentPosInList = 0;

    [Space]
    public float itemSpace = 150f;
    public float itemHeight = 400f;

    public ItemList itemList = null;

    private void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        scrollRect.movementType = ScrollRect.MovementType.Unrestricted;

        for (int i = 0; i < scrollRect.content.childCount; i++)
        {
            scrollRect.content.GetChild(i).GetComponent<Item>().id = i;
            scrollRect.content.GetChild(i).GetComponent<Item>().UpdateItem(itemList.items[i]);
        }
    }

    public void HandleVerticalScroll(RectTransform _item)
    {
        Item currentItem = _item.GetComponent<Item>();
        int lastItemID = currentItem.above? scrollRect.content.childCount - 1 : 0;

        var lastItemInList = scrollRect.content.GetChild(lastItemID);

        Vector2 newPos = lastItemInList.position;

        if (currentItem.above)
        {
            newPos.y = lastItemInList.position.y - itemHeight * 1.5f + itemSpace;
            _item.position = newPos;
            _item.SetSiblingIndex(lastItemID);

            if (currentItem.id + scrollRect.content.childCount < itemList.items.Count)
            {
                currentItem.id += scrollRect.content.childCount;
                currentItem.UpdateItem(itemList.items[currentItem.id]);
            }
        }
        else
        {
            newPos.y = lastItemInList.position.y + itemHeight * 1.5f - itemSpace;

            var lastPosInList = scrollRect.content.GetChild(scrollRect.content.childCount - 1);
            lastPosInList.position = newPos;
            lastPosInList.SetSiblingIndex(lastItemID);

            if (currentItem.id - scrollRect.content.childCount > -1)
            {
                currentItem.id -= scrollRect.content.childCount;
                currentItem.UpdateItem(itemList.items[currentItem.id]);
            }        
        }
    }
}