// Ignore Spelling: Gizmos Behaviour
// Ignore Spelling: Gizmo
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerBehaviour : MonoBehaviour
{

    [Header("---Gizmo---")]
   // [Range(5f, 15f)]
    public float rangeValue;
    [Header("---Player---")]
    public GameObject player;
    public Rigidbody rigidBody;
    [Header("---Enemy---")]
    public Transform enemy;
    public float moveSpeed;

    

    // Update is called once per frame
    void Update()
    {
        if (rigidBody == null)
        {
            Time.timeScale = 0;
        }
    }
   
    public void OnDrawGizmos()
    {
        //just checks if the player is still alive
        if (rigidBody == true) {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(player.transform.position, rangeValue);
        }
    }


}
