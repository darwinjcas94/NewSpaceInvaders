using UnityEngine;

public class Target : MonoBehaviour
{
    public float damage = 10f;
    public float health = 50f;

    public GameObject explosionPrefab;
   


    private void Start()
    {
        
    }
    public void takeDamage()
    {
        health -= damage;

        if (health <= 0f)
        {
            
            die();
        }
    }

    private void OnCollisionStay(Collision collision)
    {

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        takeDamage();
        
    }

    public void die()
    {

        Destroy(gameObject);

    }


}
