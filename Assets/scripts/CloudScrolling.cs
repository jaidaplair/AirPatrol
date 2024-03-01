using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScrolling : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float resetPosition = 9f;
    // Update is called once per frame
    void Update()
    {
        //move left across the screen
        transform.Translate(Time.deltaTime * speed * Vector3.left);
        if (transform.position.x < -resetPosition - 16.80f) 
        {
            ResetCloudPosition();
        }
    }
    private void ResetCloudPosition()
    {
        // Reposition the cloud just before the viewing window
        float offset = Mathf.Abs(transform.position.x) + resetPosition;
        transform.position = new Vector3(offset, transform.position.y, transform.position.z);
    }
    
}
