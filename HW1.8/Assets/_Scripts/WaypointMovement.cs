using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] Transform _waypoints;
    [SerializeField] float _speed = 5f;

    private List<Vector3> _actualPoints;

    private int _currentWaypointIndex = 0;
    void Start()
    {
        _actualPoints = new List<Vector3>();
        foreach (Transform wp in _waypoints)
        {
            _actualPoints.Add(wp.position);
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _actualPoints[_currentWaypointIndex], _speed * Time.deltaTime);
        if(transform.position == _actualPoints[_currentWaypointIndex])
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        _currentWaypointIndex++;
        if(_currentWaypointIndex >= _actualPoints.Count)
        {
            _currentWaypointIndex = 0;
        }
    }
}
