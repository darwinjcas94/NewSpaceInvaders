using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderControl : MonoBehaviour
{
    // Movement range
    public float horizontalRange = 5f;
    public float verticalRange = 1f;

    //speed
    public float speed = 1f;

    //direction
    int direction = 1;

    //current total distance moved
    float totalMovement = 0;

    //enum for 3 states - Moving Horizontally, Vertically, Dead
    //available states
    enum state { movingHorizontal, movingVertical, invaderDead };
    //keep track of current state
    state currentState;

    // Start is called before the first frame update
    void Start()
    {
        //initial state
        currentState = state.movingHorizontal;


    }

    // Update is called once per frame
    void Update()
    {
        //nothing happens if the invader is dead
        if (currentState == state.invaderDead) return;

        //distance d = v * t
        float movement = speed * Time.deltaTime;
        totalMovement += movement;

        if (currentState == state.movingHorizontal)
        {
            if (totalMovement >= horizontalRange) //reached maximum range
            {
                //if yes, move vertically
                currentState = state.movingVertical;

                //moving foward
                direction = direction * 1;

                //reset the total movement
                totalMovement = 0;

            }

            else
            {
                transform.position += transform.forward * movement * direction;
            }

        }
        else  //vertical movement
        {
            //transform.position -= transform.right * movement * direction * -1;

            if (totalMovement >= verticalRange) //reached maximum range
            {
                //if yes, move horizontally
                currentState = state.movingHorizontal;

                //reset the total movement
                totalMovement = 0;
                

            }

            else
            {
                transform.position += transform.right * movement;
                
            }
            
        }



    }
}
