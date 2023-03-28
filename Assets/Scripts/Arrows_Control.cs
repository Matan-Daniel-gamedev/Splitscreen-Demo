using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows_Control : MonoBehaviour
{
    Vector3 Vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;  
         if (Input.GetKey(KeyCode.LeftArrow))
            Vec.x -= Time.deltaTime * 20;  
         if (Input.GetKey(KeyCode.RightArrow))
            Vec.x += Time.deltaTime * 20;
         if (Input.GetKey(KeyCode.UpArrow))
            Vec.y += Time.deltaTime * 20;  
         if (Input.GetKey(KeyCode.DownArrow))
            Vec.y -= Time.deltaTime * 20;  
        transform.localPosition = Vec;
    }
}
