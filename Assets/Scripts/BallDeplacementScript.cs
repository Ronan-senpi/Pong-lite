using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeplacementScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    LayerMask PlayerMask;
    [SerializeField]
    LayerMask wallMask;
    Vector3 direction = Vector3.left;

    private void Start()
    {
        var xDirection = Random.Range(-1f, 1f);
        var zDirection = Random.Range(-1f, 1f);

        direction = new Vector3(xDirection,0, zDirection);
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += direction.normalized * Time.deltaTime * speed;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //Compare sur les bit et non sur la text plus rapide
        if ((wallMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            //Debug.Log("aie ! un mur !");
            direction = new Vector3(-direction.x, direction.y, direction.z);
        }
        if ((PlayerMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            direction = new Vector3(direction.x, direction.y, -direction.z);
            //Debug.Log("AJHHHHH !!! un joueur !");
        }
    }
}
