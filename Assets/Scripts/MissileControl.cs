using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControl : MonoBehaviour
{
    public GameObject wall;
    public float moveSpeed = 400f;
    private Rigidbody rb;

    public AudioSource explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {

        
        rb.velocity = new Vector3(-1 * moveSpeed * Time.deltaTime, 0f, 0f);
    }

    void PlaySound()
    {
        explosion.Play();
    }
    private void OnCollisionStay(Collision collision)
    {
        PlaySound();
        Destroy(gameObject);
    }
}
