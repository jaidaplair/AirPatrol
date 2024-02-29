using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] float speed = 4.7f;
    [SerializeField] float minY = -4.7f;
    [SerializeField] float maxY = 4f;
    [SerializeField] float speed = 5f;
    [SerializeField] float y = 0.0005f;
    [SerializeField] AudioClip firingSound;
    [SerializeField] GameObject bulletPrefab;

    //made reference prefab of the explosion
    //[SerializeField] GameObject explosion;



    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        // Control reticle movement
        //float horizontalInput = Input.GetAxis("Horizontal");
       // float verticalInput = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        //transform.Translate(movement * speed * Time.deltaTime);
       // transform.Translate(Time.deltaTime * y * speed * Vector3.up);
        float y = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * y * speed * Vector3.up);

        //peg the movement to max y
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0f);
        }
        //peg the movement to min y
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0f);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            float newY = transform.position.y + 0.59f;
            float newX = transform.position.x + 0.5f;

            //Fire();

            Instantiate(bulletPrefab, new Vector3(newX, newY, transform.position.z), transform.rotation);
            //Fire();
        }

        // Wrap around screen edges
        /*if (transform.position.x > 7f)
        {
            transform.position = new Vector3(7f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -7f)
        {
            transform.position = new Vector3(-7f, transform.position.y, transform.position.z);
        }*/
        //peg the movement to max y
        /*
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0f);
        }
        //peg the movement to min y
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0f);
        }

        // Check for firing input
        
        if (Input.GetButtonDown("Fire1"))
        {
            //float newY = transform.position.y + 1f;
            float newX = transform.position.x + 0.9f;
            Fire();
            //function to make a explosion everytime space is pushed, returns a reference to the pbject that was created
            //Instantiate(explosion, new Vector3(newX, transform.position.y, transform.position.z), transform.rotation);

            //Instantiate(explosion, transform.position, transform.rotation);
            /*
             //make a new baby everytime space is pushed, returns a reference to the pbject that was created
            GameObject obj;
            obj= Instantiate(babyPrefab);
            //Vector3.zero is equivalent to new Vector3(0,0,0)
            //spews babys out of the boss
            obj.transform.position = transform.position;
        */
        }

    /*
        void Fire()
        {
            // Play firing sound
            if (firingSound != null)
            {
                audioSource.PlayOneShot(firingSound);

            }
        }*/
}

