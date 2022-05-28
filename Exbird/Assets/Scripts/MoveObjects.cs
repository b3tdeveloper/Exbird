using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    //Set the speed of moving objects in Unity
    public float speed = 5f;

    //The limit where the pipes disapper.
    private float leftBound = -14;

    //The boundary where the pipes reappear
    private float rightBound = 11;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Move objects
        transform.position += new Vector3(0,0,-speed * Time.deltaTime);

        //When the pipes reach to the left bound and if it is a pipe, change the location of the pipe that touches there.
        if (transform.position.z < leftBound && gameObject.CompareTag("Pipe"))
        {
            //Spawn for 0.6 to 1.5 seconds.
            Invoke("Spawn", Random.Range(0.6f,1.5f));   
        }
    }

    private void Spawn()
    {
        //Randomly generate between 3 and 8 heights. Generate on the right border.
        gameObject.transform.position = new Vector3(0,Random.Range(3,8),rightBound);
    }
}
