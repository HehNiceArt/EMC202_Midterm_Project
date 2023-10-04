using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerBehaviour : MonoBehaviour
{

    public float rangeValue;
    public GameObject player;
    public Rigidbody rigidBody;

   // private float dist;
    public Transform enemy;
    public float moveSpeed;
    //public float detect;
    //public LayerMask layer;
    //public float rotSpeed;
    //private float area;
    //private Collider[] collide = new Collider[10];
    //private float close;
    //private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    
       // float dist = Vector3.Distance(player.transform.position, enemy.transform.position);
       //if(dist <= rangeValue)
       // {
       //     Debug.Log("Aaa");
       //     LookRotation();
       // }
    }
    //void LookRotation()
    //{
    //    Vector3 relativePos = enemy.position - player.transform.position;
    //    // the second argument, upwards, defaults to Vector3.up
    //    Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
    //    player.transform.rotation = rotation;
    //}

    //private GameObject Fire()
    //{
    //    var targets = GameObject.FindGameObjectsWithTag("Enemy");
    //    detect = Physics.OverlapCapsuleNonAlloc(transform.position, Vector3.one, area, collide, layer);
    //    GameObject near = null;
    //    close = 0;

    //    if (detect > 0)
    //    {
    //        near = collide[0].gameObject;
    //        close = Vector3.Distance(transform.position, near.transform.position);
    //    }
    //    for (int i = 0; i < detect; i++)
    //    {
    //        var cld = collide[i].gameObject;
    //        float position = Vector3.Distance(transform.position, cld.transform.position);
    //        if (position < close)
    //        {
    //            close = position;
    //            near = cld;
    //        }
    //    }
    //    return near;
    //}
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(player.transform.position, rangeValue);
        // Gizmos.DrawLine(Player.transform.position, Player.transform.forward);
    }
}
