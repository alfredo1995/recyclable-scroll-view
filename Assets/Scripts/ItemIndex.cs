using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ItemIndex : MonoBehaviour
{
    public int id = 0;
    public ColotList colotList;

    public void UpdateID()
    {
        if (transform.position.y > 433)
        {
            id--;
            print("subiu");
        }
        else if (transform.position.y < 124)
        {
            id++;
            print("desceu");
        }

        if (id < 0)
            id = colotList.colors.Count - 1;

        if (id > colotList.colors.Count - 1)
            id = 0;

        GetComponent<Image>().color = colotList.colors[id];
    }

}
