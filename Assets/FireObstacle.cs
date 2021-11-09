using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireObstacle : MonoBehaviour
{
    public Transform FirePoint;
    float BulletSpeed = 0.5f;
    public GameObject BulletPrefub;
    private GameObject Bullet;

    private void Start()
    {
        InvokeRepeating("Fire", 2f,5f);
       
    }
    public void Fire ()
    {
       Bullet = Instantiate(BulletPrefub, FirePoint.position, Quaternion.identity);
       
       Destroy(Bullet, 5f);
    }
    void Update()
    {
         Bullet.transform.position = Vector3.Lerp( Bullet.transform.position,  Bullet.transform.position + new Vector3(0.0f, 0.0f, -2f), BulletSpeed * Time.deltaTime);
    }
}
