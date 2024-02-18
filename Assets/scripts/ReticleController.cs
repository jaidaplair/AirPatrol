using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] AudioClip firingSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Control reticle movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(movement * speed * Time.deltaTime);

        // Wrap around screen edges
        if (transform.position.x > 7f)
        {
            transform.position = new Vector3(7f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -7f)
        {
            transform.position = new Vector3(-7f, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 4.7f)
        {
            transform.position = new Vector3(transform.position.x, 4.7f, transform.position.z);
        }
        else if (transform.position.y < -4.7f)
        {
            transform.position = new Vector3(transform.position.x, -4.7f, transform.position.z);
        }

        // Check for firing input
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        // Play firing sound
        if (firingSound != null)
        {
            audioSource.PlayOneShot(firingSound);
        }
    }
}
