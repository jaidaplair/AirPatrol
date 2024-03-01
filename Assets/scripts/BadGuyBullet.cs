using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyBullet : MonoBehaviour
{
    //[SerializeField] float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        //destroy object after a certain amount of seconds
        Destroy(gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Random.Range(4f, 7f);
        //move left across the screen
        transform.Translate(Time.deltaTime * speed * Vector3.left);
    }
}
