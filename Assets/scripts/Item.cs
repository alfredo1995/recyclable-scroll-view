using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public int id = 0;
    public TextMeshProUGUI infoText;

    public bool isInvisivble = false;
    public bool above = false;

    public void BecameVisible() 
    {
        if (!isInvisivble)
            return;

        isInvisivble = false;
    }

    public void BecameInvisible()
    {
        if (isInvisivble)
            return;

        ScrollRectPool.Instance.ActivateObject();
        gameObject.SetActive(false);
        isInvisivble = true;
    }

    public void UpdateItem(string text) 
    {
        infoText.text = text;
    }
}
