using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;
    float directionX;
    float directionY;
    float timer;

    // Use this for initialization
    void Start () {
        timer = 0f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        directionX = Input.GetAxis("Horizontal");
        directionY = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(directionX, directionY) * speed * Time.deltaTime);

        timer += Time.deltaTime;
    }
}
