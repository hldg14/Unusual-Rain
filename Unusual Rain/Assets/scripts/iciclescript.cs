using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iciclescript : MonoBehaviour
{
     
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "table")
        {
            transform.position = new Vector3(transform.position.x , transform.position.y + Random.Range(5,30));
            transform.rotation = new Quaternion(0, 0, 0,0);
        }
    }
}
