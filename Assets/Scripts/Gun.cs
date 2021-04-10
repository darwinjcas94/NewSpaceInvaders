using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioSource shootingSound;

    // Update is called once per frame


    private void Start()
    {
        //shootingSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            
            shoot();
        }
    }

    //shooting using raycasting 
    void shoot()
    {

        //muzzleFlash.Play();
        //shootingSound.Play();

        /*   RaycastHit hit;
          if( Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
           {
               Debug.Log(hit.transform.name);

               Target target = hit.transform.GetComponent<Target>();

               if (target != null)
               {
                   target.takeDamage(damage);
               }
           } 



       */
    }
}
