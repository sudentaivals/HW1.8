using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScalarSlider : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _tmpText;
    [SerializeField] ScalarButton _button;
    void Start()
    {
        var slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(a =>
       {
           _tmpText.text = a.ToString("0.00");
           _button.SetNewScale(a);
       });
    }

}
