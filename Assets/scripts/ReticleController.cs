using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] AudioClip firingSound;
    //made reference prefab of the explosion
    [SerializeField] GameObject explosion;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       // Destroy(gameObject, 3.6f);
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
            //function to make a explosioneverytime space is pushed, returns a reference to the pbject that was created
            Instantiate(explosion, transform.position, transform.rotation);
            /*
             //make a new baby everytime space is pushed, returns a reference to the pbject that was created
            GameObject obj;
            obj= Instantiate(babyPrefab);
            //Vector3.zero is equivalent to new Vector3(0,0,0)
            //spews babys out of the boss
            obj.transform.position = transform.position;*/
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
