using UnityEngine;

public class ScrollContent : MonoBehaviour
{
    #region Public Properties

    public float ItemSpacing { get { return itemSpacing; } }

    public float HorizontalMargin { get { return horizontalMargin; } }

    public float VerticalMargin { get { return verticalMargin; } }

    public bool Horizontal { get { return horizontal; } }

    public bool Vertical { get { return vertical; } }

    public float Width { get { return width; } }

    public float Height { get { return height; } }

    public float ChildWidth { get { return childWidth; } }

    public float ChildHeight { get { return childHeight; } }

    #endregion

    #region Private Members

    private RectTransform rectTransform;

    private RectTransform[] rtChildren;

    private float width, height;

    private float childWidth, childHeight;

    [SerializeField]
    private float itemSpacing;

    [SerializeField]
    private float horizontalMargin, verticalMargin;

    [SerializeField]
    private bool horizontal, vertical;

    #endregion

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rtChildren = new RectTransform[rectTransform.childCount];

        for (int i = 0; i < rectTransform.childCount; i++)
        {
            rtChildren[i] = rectTransform.GetChild(i) as RectTransform;
        }

        width = rectTransform.rect.width - (2 * horizontalMargin);

        height = rectTransform.rect.height - (2 * verticalMargin);

        childWidth = rtChildren[0].rect.width;
        childHeight = rtChildren[0].rect.height;

        horizontal = !vertical;
        if (vertical)
            InitializeContentVertical();
        else
            InitializeContentHorizontal();
    }

    private void InitializeContentHorizontal()
    {
        float originX = 0 - (width * 0.5f);
        float posOffset = childWidth * 0.5f;
        for (int i = 0; i < rtChildren.Length; i++)
        {
            Vector2 childPos = rtChildren[i].localPosition;
            childPos.x = originX + posOffset + i * (childWidth + itemSpacing);
            rtChildren[i].localPosition = childPos;
        }
    }

    private void InitializeContentVertical()
    {
        float originY = 0 - (height * 0.5f);
        float posOffset = childHeight * 0.5f;
        for (int i = 0; i < rtChildren.Length; i++)
        {
            Vector2 childPos = rtChildren[i].localPosition;
            childPos.y = originY + posOffset + i * (childHeight + itemSpacing);
            rtChildren[i].localPosition = childPos;
        }
    }
}
