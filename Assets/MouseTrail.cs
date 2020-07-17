using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MouseTrail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = 10;
        this.transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
