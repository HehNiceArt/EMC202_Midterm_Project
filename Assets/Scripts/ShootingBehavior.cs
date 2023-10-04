using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    private GameObject bullet;
    public float bulletSpeed;
    public float fireRate;
    private bool canShoot = false;
    public float timeToLive = 5f;

    public Transform enemy;
    public float rangeValue;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && !canShoot)
        {
            StartCoroutine(FireShot());
        }

        Destroy(bullet, timeToLive);
        float dist = Vector3.Distance(transform.position, enemy.transform.position);
        if (dist <= rangeValue)
        
            Debug.Log("Aaa");
            LookRotation();
        
    }
    void LookRotation()
    {
        Vector3 relativePos = enemy.position - transform.position;
        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    IEnumerator FireShot()
    {
        canShoot = true;
        Fire();
        yield return new WaitForSeconds(fireRate);
        canShoot = false;
    }

    private void Fire()
    {
        //bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Player.transform.rotation);
        bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f);
        //Rigidbody rb = bullet.GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * bulletSpeed);
        //rb.velocity = transform.TransformDirection(new Vector3(bulletSpeed, 0, bulletSpeed));
    }
}
