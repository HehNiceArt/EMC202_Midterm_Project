using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject remove;
    private Transform target;
    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(target);
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = moveSpeed * Time.deltaTime * transform.forward;
    }
    // Update is called once per frame
    void Update()
    {

    }

}
