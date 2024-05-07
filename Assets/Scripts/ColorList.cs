using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorList", menuName = "Scriptable/ColorList")]
public class ColotList : ScriptableObject
{
    public List<Color> colors = new List<Color>();
}
