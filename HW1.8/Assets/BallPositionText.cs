using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallPositionText : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] TextMeshProUGUI _tmpText;
    void Update()
    {
        _tmpText.text = "Ball position: " + _ball.transform.position.ToString();
    }
}
