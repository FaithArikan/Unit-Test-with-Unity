using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class PanelController
{
    [Test]
    public void Getting50()
    {
        int final = Panel.Calculate(10, 5);
        Assert.AreEqual(50, final);
    }
    [Test]
    //False example
    public void Getting5()
    {
        int final = Panel.Calculate(10, 5);
        Assert.AreEqual(5, final);
    }
    [Test]
    public void RedButton()
    {
        Button button = GameObject.Find("ButtonR").GetComponent<Button>();
        Assert.NotNull(button);
    }
}
