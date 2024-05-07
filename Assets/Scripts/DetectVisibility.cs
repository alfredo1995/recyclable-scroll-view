using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class DetectVisibility : MonoBehaviour
{
    [SerializeField] List<Color> colors = new List<Color>();
    [SerializeField] List<Image> obj = new List<Image>();
    [SerializeField] GameObject objPrefab;

    [SerializeField] RectTransform content;

    private void Start()
    {
        int t = 0;

        if (colors.Count > 10)
            t = 10;
        else
            t = colors.Count;

        for (int i = 0; i < t; i++)
        {
            Image img = Instantiate(objPrefab, content).GetComponent<Image>();
            img.color = colors[i];
            obj.Add(img);
        }
    }


}
