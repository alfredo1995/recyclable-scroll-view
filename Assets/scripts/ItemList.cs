using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ItemList")]
public class ItemList : ScriptableObject
{
    public List<string> items = new List<string>();
}
