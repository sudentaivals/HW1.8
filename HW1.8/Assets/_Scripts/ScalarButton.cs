using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalarButton : MonoBehaviour
{
    [SerializeField] Transform _gameObject;

    private float _scaleValue;

    public void SetNewScale(float newScale)
    {
        _scaleValue = newScale;
    }

    public void ChangeScale()
    {
        _gameObject.transform.position *= _scaleValue;
    }
}
