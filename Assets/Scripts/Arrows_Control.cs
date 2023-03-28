using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows_Control : MonoBehaviour
{
    Vector3 Vec;
    float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;
         if (Input.GetKey(KeyCode.LeftArrow))
            Vec.x -= Time.deltaTime * speed;

         if (Input.GetKey(KeyCode.RightArrow))
            Vec.x += Time.deltaTime * speed;

         if (Input.GetKey(KeyCode.UpArrow))
            Vec.y += Time.deltaTime * speed;

         if (Input.GetKey(KeyCode.DownArrow))
            Vec.y -= Time.deltaTime * speed;
            
        transform.localPosition = Vec;
    }
}
