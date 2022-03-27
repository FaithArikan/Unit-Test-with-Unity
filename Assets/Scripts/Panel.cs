using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Panel : MonoBehaviour
{
    private List<TabButton> tabButtons;
    public List<GameObject> objectsToSwap;
    public void Add(TabButton button)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        tabButtons.Add(button);
        Debug.Log(tabButtons.Count);
    }
    public void Open(TabButton button){
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if(i == index)
            {
                objectsToSwap[i].SetActive(true);
                Debug.Log("Opened = " + i);
                TabString(i.ToString());
                Debug.Log("GameObject" + objectsToSwap[i].gameObject);
                Debug.Log("IsActive" + objectsToSwap[i].gameObject.activeSelf);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }
    public static string TabString(string x)
    {
        Debug.Log("xxx = " + x);
        return x;
    }
    public static int Calculate(int amount, float percent){
        return Convert.ToInt32(amount * percent);
    }
}
