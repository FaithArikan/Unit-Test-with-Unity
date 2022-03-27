using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{
    Panel panel;
    Button button;

    void Start()
    {
        panel = GetComponentInParent<Panel>();
        button = GetComponent<Button>();


        Debug.Log(panel.gameObject.name);
        panel.Add(this);
        button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        panel.Open(this);

    }
}
