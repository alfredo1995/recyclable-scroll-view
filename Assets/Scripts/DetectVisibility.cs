using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectVisibility : MonoBehaviour
{
    [SerializeField] ColotList colotList;
    [SerializeField] List<Image> obj = new List<Image>();
    [SerializeField] GameObject objPrefab;

    [SerializeField] RectTransform content;
    [Space]

    [SerializeField] Canvas canvas;
    public ScrollRect scrollView;
    public RectTransform itemRectTransform;


    private void Awake()
    {
        //int t = 0;

        //if (colotList.colors.Count > 10)
        //    t = 10;
        //else
        //    t = colotList.colors.Count;

        //for (int i = 0; i < t; i++)
        //{
        //    Image img = Instantiate(objPrefab, content).GetComponent<Image>();
        //    img.color = colotList.colors[i];
        //    img.GetComponent<ItemManager>().colotList = colotList;
        //    img.GetComponent<ItemManager>().id = i;

        //    obj.Add(img);
        //}
    }
}