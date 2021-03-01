using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject prefab;

    int delay = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        Ray clickRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit result;
        if (Physics.Raycast(clickRay, out result)) {
            Debug.Log(result);
            GameObject.Instantiate(prefab, result.point, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            delay = delay + 1;
            if (delay >= 15)
            {
                Debug.Log("click");
                Ray clickRay = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit result;
                if (Physics.Raycast(clickRay, out result))
                {
                    Debug.Log(result);
                    GameObject.Instantiate(prefab, result.point, Quaternion.identity);
                }
                delay = 0;
            }
        } else {
            delay = 15;
        }
    }
}
