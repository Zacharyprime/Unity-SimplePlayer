using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = false;

    }

    
    private float y;
    private Vector3 rotateValue;

    void Update()
    {
        y = Input.GetAxis("Mouse Y");
        rotateValue = new Vector3(y, 0, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;

        if (Input.GetKey("escape"))
        {
            Cursor.visible = true;
        }
    }


}


