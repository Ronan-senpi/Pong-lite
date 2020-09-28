using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeplacementScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private string axisName = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetAxis(axisName) > 0)
        {
            direction = Vector3.left;
        }
        if (Input.GetAxis(axisName) < 0 )
        {
            direction = Vector3.right;

        }
        gameObject.transform.position += direction.normalized * Time.deltaTime * speed;
    }
}
