using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject remove;
    private Transform target;
    public int moveSpeed;
    public MeshRenderer rend;
    public Material colorMat;
    public static EnemyBehavior Instance;
    public Material mat
    { 
        get
        {
            return rend.material;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(target);

        rend.material.color = ColorBehavior.Instance.RandomColor();
        print(rend.material.color);
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = moveSpeed * Time.deltaTime * transform.forward;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //var myColor = ColorBehavior.Instance.colors;
        //var otherColor = rend.material.color;
        //print(otherColor);
        //print(myColor);
        //if (collision.gameObject.tag == "Bullet")
        //{
        //    Debug.Log("adasw");
        //    if (otherColor.Equals(myColor))
        //    {
        //        print("aa");
        //        print("bullet dead");
        //        Destroy(collision.gameObject);
        //        Destroy(this.gameObject);
        //    }
        //    else
        //    {
        //        print("aaa");
        //        Destroy(this.gameObject);
        //        Destroy(collision.gameObject);
        //    }
        //}
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
    }


}
