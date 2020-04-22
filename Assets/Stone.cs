using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    
    Vector3 _initialPosition;

    private void Awake()
    {
        _initialPosition = transform.position;
        
    }
    private void OnMouseUp()
    {
        GameObject spike = GameObject.Find("spike-w");
        //transform.position = spike.GetComponent<Collider>().bounds.max;
        transform.position = spike.transform.position;
    }

    private void OnMouseDown()
    {

    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x,newPosition.y);
    }

    
}
