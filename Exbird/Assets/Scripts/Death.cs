using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public TimeManager timeManager;
    public MoveObjects[] moveObjects;
    public PlayerController playerController;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            //Set the animation
            animator.SetTrigger("isDead");

            //Make slow motion
            timeManager.DoSlowmotion();

            //Stop the moving objects
            foreach (var item in moveObjects)
            {
                item.speed = 0;
            }

            //Stop to take input in player controller.
            playerController.isDead = true;

        }
    }
}
