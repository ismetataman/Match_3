using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GoalPanel : MonoBehaviour
{
    public Image thisImage;
    public Sprite thisSprite;
    public TextMeshProUGUI thisText;
    public string thisString;
    void Start()
    {
        Setup();
    }

    
    void Setup()
    {
        thisImage.sprite = thisSprite;
        thisImage.preserveAspect = true;
        thisText.text = thisString;
    }
}
