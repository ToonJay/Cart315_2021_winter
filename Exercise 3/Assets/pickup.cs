using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.gameObject);
        if (collision.collider.gameObject.CompareTag("pickup"))
        {
            Debug.Log("Picked up " + collision.collider.gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
