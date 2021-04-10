using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    public Transform playerTransform;
    private Vector3 cameraOffset;
    public bool lookAtPlayer = false;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f; 
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = playerTransform.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);


        if(lookAtPlayer)
        {
            transform.LookAt(playerTransform);
        }
    }
}
