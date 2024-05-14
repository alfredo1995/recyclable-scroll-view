using System.Collections.Generic;
using UnityEngine;

public class ScrollRectPool : MonoBehaviour
{
    public static ScrollRectPool Instance;
    public List<GameObject> pooledItems = new List<GameObject>();

    private void Awake() 
    {
        Instance = this;
    }

    public GameObject ActivateObject()
    {
        // Procura por um item inativo no pool
        foreach (GameObject item in pooledItems)
        {
            if (!item.activeInHierarchy && CheckVisibility.Instance.IsBetweenCorners(item.GetComponent<RectTransform>()))
            {
                item.SetActive(true);
                return item;
            }
        }

        return null;
    }
}