using UnityEngine;
using UnityEngine.UI;

public class SimpleVerticalLayout : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float spacing = 10f;
    private RectTransform contentRect;

    void Start()
    {
        contentRect = scrollRect.content;
        scrollRect.onValueChanged.AddListener(OnScrollValueChanged);
        ArrangeChildren();
    }

    void OnDestroy()
    {
        scrollRect.onValueChanged.RemoveListener(OnScrollValueChanged);
    }

    void OnScrollValueChanged(Vector2 value)
    {
        ArrangeChildren();
    }

    void ArrangeChildren()
    {
        float posY = 0f;

        for (int i = 0; i < contentRect.childCount; i++)
        {
            RectTransform childRect = contentRect.GetChild(i) as RectTransform;
            if (childRect != null && childRect.gameObject.activeSelf)
            {
                childRect.anchoredPosition = new Vector2(childRect.anchoredPosition.x, posY);
                posY -= childRect.sizeDelta.y + spacing;
            }
        }
        contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, -posY + spacing);
    }
}