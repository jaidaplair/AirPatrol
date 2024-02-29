using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyMovement : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] GameObject BadGuy;
    [SerializeField] GameObject GoodGuy;
    [SerializeField] int GoodToBadRatio = 50;
    float futureTime = 0f; //this is the time when we will istantiate a good or bad guy
    [SerializeField] float minRange = 1f;
    [SerializeField] float maxRange = 3f;
    [SerializeField] GameObject explosion;
    [SerializeField] float minY = -8f;
    [SerializeField] float maxY = 8f;
    // Start is called before the first frame update
    //the boolean travelDirection is true when we are going up and false when we are going down.
    bool travelDirection = true;
    void Start()
    {
        //destroy object after a certain amount of seconds
        //Destroy(gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {

        if (travelDirection == true)
        {//we are moving up
            transform.Translate(Time.deltaTime * speed * Vector3.up);
        }
        else
        {//we are moving down
            transform.Translate(Time.deltaTime * speed * Vector3.down);
        }
        //if we hit the top change direction
        if (transform.position.y > maxY)
        {
            travelDirection = false;
        }
        //if we hit the bottom change direction
        if (transform.position.y < minY)
        {
            travelDirection = true;
        }


        //move left across the screen
        //transform.Translate(Time.deltaTime * speed * Vector3.left);

        if (Time.time > futureTime)//
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            futureTime = Time.time + Random.Range(minRange, maxRange);
            int r = Random.Range(0, 100);
            if (r < GoodToBadRatio)
            {
                Instantiate(BadGuy, transform.position, transform.rotation);
            }
            else
            {
                //function to make a new goodguy everytime space is pushed, returns a reference to the pbject that was created
                Instantiate(GoodGuy, transform.position, transform.rotation);
            }
            //function to make a new baby everytime space is pushed, returns a reference to the pbject that was created
            //Instantiate(babyPrefab, transform.position, transform.rotation);
            /*
             //make a new baby everytime space is pushed, returns a reference to the pbject that was created
            GameObject obj;
            obj= Instantiate(babyPrefab);
            //Vector3.zero is equivalent to new Vector3(0,0,0)
            //spews babys out of the boss
            obj.transform.position = transform.position;*/
            

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BadGuy") == true)
        {   //increment score
            //gm.score += 10;
            Instantiate(explosion, transform.position, transform.rotation);

        }
        if (collision.CompareTag("GoodGuy") == true)
        {   //decrement score
            Instantiate(explosion, transform.position, transform.rotation);
            //gm.score -= 15;

        }
    }
}
