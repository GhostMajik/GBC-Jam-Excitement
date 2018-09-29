using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {

    public bool isRunning;
    private float speed = 1.0f;
    //magic number used until screen width calculation is done
    private float endPoint = -6.0f;
    private Material defaultMaterial;

	// Use this for initialization
	void Start () {
        isRunning = true;
        defaultMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= endPoint) {
            isRunning = false;
        }
        if (!isRunning) {
            Destroy(this.gameObject, 0.3f);
        }
        
	}
    //move platforms
    private void FixedUpdate(){
        if (isRunning) {
            transform.Translate(transform.right * -speed * Time.deltaTime, Space.World);   
        }
    }
    //get transform can be used for sending the colors to platform position
    public Vector3 getPostion() {
        return transform.position;
    }

    //set and get movement speed of the platforms.
    public float getSpeed() {
        return speed;
    }

    public void setSpeed(float inSpeed) {
        speed = inSpeed;
    }

}
