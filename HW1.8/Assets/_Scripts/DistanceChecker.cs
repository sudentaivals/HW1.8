using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    [SerializeField] Transform _first;
    [SerializeField] Transform _second;
    [SerializeField] TextMeshProUGUI _tmpText;

    // Update is called once per frame
    void Update()
    {
        _tmpText.text = $"Distance: {(_first.position - _second.position).magnitude.ToString("0.00")}";
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawLine(_first.position, _second.position);
    }
}
