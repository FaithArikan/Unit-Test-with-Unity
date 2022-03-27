using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using System;
public class PanelControllerPlay
{
    bool clicked = false;

    [UnityTest]
    public IEnumerator  RedButtonClickedCheck()
    {   
        var gameObject = new GameObject();
        var button = gameObject.AddComponent<Button>();
        clicked = false;
        button.onClick.AddListener(Clicked);
        button.onClick.Invoke();
        Assert.True(clicked);
        yield return new WaitForSeconds(.1f);
    }
    private void Clicked()
    {
        clicked = true;
    }
    [UnityTest]
    public IEnumerator IsTabChangedCheck()
    {
        List<GameObject> Objects = new List<GameObject>();

        var redTab = new GameObject();         redTab.AddComponent<TabButton>();
        var blueTab = new GameObject();        blueTab.AddComponent<TabButton>();
        var greenTab = new GameObject();        greenTab.AddComponent<TabButton>();
        var orangeTab = new GameObject();        orangeTab.AddComponent<TabButton>();
        var purpleTab = new GameObject();        purpleTab.AddComponent<TabButton>();

        Objects.Add(redTab);         
        Objects.Add(blueTab); 
        Objects.Add(greenTab); 
        Objects.Add(orangeTab); 
        Objects.Add(purpleTab); 
        Assert.IsNotEmpty(Objects);

        for (int i = 0; i < Objects.Count; i++)
        {
            int index = Objects[i].transform.GetSiblingIndex();

            if (i == index)
            {
                Objects[i].SetActive(true);
                Debug.Log("Opened = " + i);
                Panel.TabString(i.ToString());
                Assert.AreEqual(Objects[i].gameObject, Objects[i].gameObject.activeSelf);
            }
            else
            {
                Objects[i].SetActive(false);
            }
            //IndexOutOfRangeException
            //Assert.Catch(typeof(IndexOutOfRangeException), () => i = (Objects.Count + 1));
        }

        yield return new WaitForSeconds(.1f);
    }
}
