using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{   public int score = 0;
    public float xRange = 10;
    public float speed = 10.0f;
    public float horizontalInput;
    public GameObject projectilePrefab; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
           
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
             Debug.Log("your new score is " + score + " now");
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //launches projectile
            Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation);
        }
    }
}
