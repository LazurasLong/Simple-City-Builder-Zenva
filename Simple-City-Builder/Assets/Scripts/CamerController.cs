using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    private Vector3 mouseOriginPoint;
    private Vector3 offset;
    private bool isDragging;

    //change size to zoom in/out
    // clamp values to min and max
    // mouse wheel scrolling
    private void LateUpdate()
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel")* Camera.main.orthographicSize, 2.5f, 50f);
        if (Input.GetMouseButton(2))
        {
            offset = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            if(!isDragging)
            {
                isDragging = true;
                mouseOriginPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
            isDragging = false;
        if (isDragging)
            transform.position = mouseOriginPoint - offset;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
