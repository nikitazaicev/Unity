using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseThings : MonoBehaviour
{

    float speed = 200.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 300.0f))
        {
            if (hit.transform)
            {
                    GameObject go;
                    Rigidbody rb;
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        Print(hit.transform.gameObject);
                        launchUp(rb);
                    }
            }
        }
        }
    }

    void Print(GameObject go)
    {
        print(go);
    }

    void launchUp(Rigidbody rb)
    {
        rb.AddForce(transform.up*speed, ForceMode.Impulse);
    }

}
