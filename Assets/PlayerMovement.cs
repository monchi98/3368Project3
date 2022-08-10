using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Update()
    {    
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0);  
    }
}
