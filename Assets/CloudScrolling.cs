using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScrolling : MonoBehaviour
{/*
    public float scrollSpeed = 1f;
    public float resetPosition = 10f;

    private Transform[] clouds;


    // Start is called before the first frame update
    void Start()
    {
        // Get the transform components of both cloud objects
        clouds = new Transform[2];
        clouds[0] = transform;
        clouds[1] = transform.GetChild(0); // Assuming both clouds are children of the same parent

    }

    // Update is called once per frame
    void Update()
    {
        // Move clouds horizontally
        foreach (Transform cloud in clouds)
        {
            cloud.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

            // Reset position if cloud goes beyond reset position
            if (cloud.position.x < -resetPosition)
            {
                ResetCloudPosition(cloud);
            }
        }

    }

    private void ResetCloudPosition(Transform cloud)
    {
        // Reposition the cloud just before the viewing window
        float offset = Mathf.Abs(cloud.position.x) + resetPosition;
        cloud.position = new Vector3(offset, cloud.position.y, cloud.position.z);
    }*/
    public float scrollSpeed = 1f;
    public float resetPosition = 10f;

    private void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x < -resetPosition)
        {
            ResetCloudPosition();
        }
    }

    private void ResetCloudPosition()
    {
        float offset = Mathf.Abs(transform.position.x) + resetPosition;
        transform.position = new Vector3(offset, transform.position.y, transform.position.z);
    }












}
