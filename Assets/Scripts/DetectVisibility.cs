using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectVisibility : MonoBehaviour
{
    [SerializeField] ColotList colotList;
    [SerializeField] List<Image> obj = new List<Image>();
    [SerializeField] GameObject objPrefab;

    [SerializeField] RectTransform content;

    private void Start()
    {
        int t = 0;

        if (colotList.colors.Count > 10)
            t = 10;
        else
            t = colotList.colors.Count;

        for (int i = 0; i < t; i++)
        {
            Image img = Instantiate(objPrefab, content).GetComponent<Image>();
            img.color = colotList.colors[i];
            obj.Add(img);
        }
    }
}
