using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed = 5f;
    private float leftBound = -14;
    private float rightBound = 11;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,0,-speed * Time.deltaTime);

        if (transform.position.z < leftBound && gameObject.CompareTag("Pipe"))
        {
            //Destroy(gameObject);
            Invoke("Spawn", Random.Range(0.6f,1.5f));
            //Spawn();
        }
    }

    private void Spawn()
    {
        gameObject.transform.position = new Vector3(0,Random.Range(3,8),rightBound);
    }
}
