using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcollision : MonoBehaviour
{
    public GameObject player;
    

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.gameObject == player)
        {
            Vector3 force = new Vector3(0, 1000, 0);
            this.GetComponent<Rigidbody>().AddForce(force);
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
