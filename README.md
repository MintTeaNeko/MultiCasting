# MultiCasting
A simplistic thing I made for unity to cast X amount of spheres towards any direction

# Usage Example

`MultiCasting.Cast(origin_point, distance_from_origin, direction, radius, sphere_amount)`

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClassScript : MonoBehaviour
{
    [SerializeField] private float _radius;

    private void Start()
    {
        var cam_transform = Camera.main.transform;

        Debug.Log("casting forward");
        MultiCasting.Cast(cam_transform.position, 3.5f, cam_transform.forward, _radius, 3);

        Debug.Log("casting backwards");
        MultiCasting.Cast(cam_transform.position, 3.5f, -cam_transform.forward, _radius, 3);

        Debug.Log("casting right");
        MultiCasting.Cast(cam_transform.position, 3.5f, cam_transform.right, _radius, 3);

        Debug.Log("casting left");
        MultiCasting.Cast(cam_transform.position, 3.5f, -cam_transform.right, _radius, 3);
    }
}
```
