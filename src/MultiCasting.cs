using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiCasting : MonoBehaviour
{
    public static List<Collider> Cast(Vector3 _origin, float _distanceFromStartingPoint, Vector3 _direction, float _radius, int _instanceAmount)
    {
        var collisions = new List<Collider>();
        var last_position = _origin;

        for (int i = 0; i < _instanceAmount; i++)
        {
            var new_position = last_position;
            
            if (i > 0)
                new_position = last_position + (_direction * _radius);
            else
                new_position = last_position + (_direction * _distanceFromStartingPoint);

            var colliders_detected = Physics.OverlapSphere(new_position, _radius);
            Debug.Log(colliders_detected.Length);
            if (colliders_detected.Length > 0) collisions.AddRange(colliders_detected);

            last_position = new_position;
        }

        return collisions;
    }
}
