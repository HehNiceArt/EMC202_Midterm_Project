using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    MeshRenderer rend;
    MeshRenderer render;

    ColorBehavior colorBehavior;
    // Start is called before the first frame update
    void Start()
    {
        colorBehavior = GetComponent<ColorBehavior>();
        rb = GetComponent<Rigidbody>();
        //var myColor = ColorBehavior.Instance.bullet.sharedMaterial.color;
        //var otherColor = ColorBehavior.Instance.RandomColor();
        //rend.material.color = myColor;
        //render.material.color = otherColor;
    }

    private void Update()
    {
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    var myColor = ColorBehavior.Instance.colors;
    //    var otherColor = EnemyBehavior.rend.material.color;
    //    if (collision.gameObject.tag == "Enemy")
    //    {
    //        Destroy(collision.gameObject);
    //        Destroy(this.gameObject);
    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    //var bulletColor = colorBehavior.bullet.sharedMaterial.color;
    //    //var enemyColor = EnemyBehavior.Instance.rend.material.color;
    //    //if (collision.gameObject.tag == "Enemy")
    //    //{

    //    //    print("a");
    //    //        Destroy(collision.gameObject);
    //    //        Destroy(this.gameObject);



    //    //}
    //}
    private void OnCollisionEnter(Collision collision)
    {
        //var bulletColor = GetComponent<Renderer>().material.color;
        //ColorBehavior.Instance.bullet.sharedMaterial.color;
        //var enemyColor = EnemyBehavior.Instance.rend.material.color;
        if (collision.gameObject.tag == "Enemy")
        {
            //if (bulletColor.Equals(enemyColor))
            //{
            //    print("a");
            //}

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

}
