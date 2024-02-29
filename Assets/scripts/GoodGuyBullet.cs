using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGuyBullet : MonoBehaviour
{
   [SerializeField] float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        //destroy object after a certain amount of seconds
        Destroy(gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        //move left across the screen
        transform.Translate(Time.deltaTime * speed * Vector3.left);
    }
}
