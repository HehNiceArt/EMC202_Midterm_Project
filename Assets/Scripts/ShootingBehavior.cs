using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public GameObject bullet;
    public float bulletSpeed;
    public float fireRate;
    private bool canShoot = false;
    public float timeToLive = 5f;

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
