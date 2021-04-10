using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{


    public float health = 3f;
    bool gameOver = false;

    public GameObject zeroHealthUI;
    public GameObject oneHealthUI;
    public GameObject twoHealthUI;
    public GameObject threeHealthUI;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (health > 0)
        {
            health -= 1;
            UIHandler();


        }
        else
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        if (health == 0)
        {
            gameOver = true;
        }
    }
    
    private void UIHandler()
    {
        if (health == 3)
        {
            threeHealthUI.SetActive(true);
        }
        else if (health == 2)
        {
            threeHealthUI.SetActive(false);
            twoHealthUI.SetActive(true);
        }
        else if (health == 1)
        {
            twoHealthUI.SetActive(false);
            oneHealthUI.SetActive(true);
        }
        else
        {
            GameOver();
            oneHealthUI.SetActive(false);
            zeroHealthUI.SetActive(true);
        }
    }
}
