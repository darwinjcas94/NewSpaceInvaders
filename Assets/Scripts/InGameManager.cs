using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : MonoBehaviour
{

    public float enemiesPerRow = 3f;
    public float enemiesPerColunm = 4f; 

    public float fireInterval = 2f;
    private bool canFire = true;
    public AudioSource shootingSound;
    public ParticleSystem muzzleFlash;

    public GameObject rocketPrefab;
    public Transform rocketSpawnPoint1, rocketSpawnPoint2;

 
    private void Start()
    {
      
    }

    void Update()
    {

        if (Input.GetButtonDown("Space"))
        {
            if (canFire)
            {
                //fire rockets
                FireRockets1();

                canFire = false;

                StartCoroutine(ReloadDelay());
            }
        }
        if (Input.GetButtonDown("Submit"))
        {
            if (canFire)
            {
                //fire rockets
                FireRockets2();

                canFire = false;

                StartCoroutine(ReloadDelay());
            }
        }
     }

    private void FireRockets1()
    {

        shootingSound.Play();
        muzzleFlash.Play();
        Instantiate(rocketPrefab, rocketSpawnPoint1.position, Quaternion.identity);
    }
    private void FireRockets2()
    {
        shootingSound.Play();
        muzzleFlash.Play();
        Instantiate(rocketPrefab, rocketSpawnPoint2.position, Quaternion.identity);
    }


        private IEnumerator ReloadDelay()
    {
        yield return new WaitForSeconds(fireInterval);

        canFire = true;
    }
}
