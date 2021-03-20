using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerLookSc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
