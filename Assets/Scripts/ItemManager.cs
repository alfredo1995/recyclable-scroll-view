using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    [SerializeField] ColotList colotList;

    [SerializeField] GameObject objPrefab;

    [SerializeField] RectTransform content;

    [SerializeField] List<Image> obj = new List<Image>();


    private void Awake()
    {
        int startingItems = 0;

        if (colotList.colors.Count > 10)
            startingItems = 10;
        else
            startingItems = colotList.colors.Count;

        for (int i = 0; i < startingItems; i++)
        {
            Image img = Instantiate(objPrefab, content).GetComponent<Image>();
            img.color = colotList.colors[i];
            obj.Add(img);
        }
    }
}
