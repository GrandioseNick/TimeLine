using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageTimeLineUI : MonoBehaviour
{
    private Image barImage;
    // Start is called before the first frame update
    void Start()
    {
        barImage = transform.Find("bar").GetComponent<Image>();
        barImage.fillAmount = .3f;
    }
}
