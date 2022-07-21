using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSubtractButton : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    [SerializeField] Vector3 _vector;

    public void Subtract()
    {
        _gameObject.transform.position -= _vector;
    }

    public void Add()
    {
        _gameObject.transform.position += _vector;
    }
}
