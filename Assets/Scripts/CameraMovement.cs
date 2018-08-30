using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


    // TODO Notice when mouse is on side of screen

    private const int MIN_CAMERA_DISTANCE = 5;
    private const int MAX_CAMERA_DISTANCE = 50;
    private const int MAX_DISTANCE = 100;

	// Update is called once per frame
	void Update () {

        float modifier = Time.deltaTime * 30;

        if (Input.GetKey("w") && transform.position.z < MAX_DISTANCE)
        {
            // move up
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + modifier);
        }

        if (Input.GetKey("s") && transform.position.z > -MAX_DISTANCE) {

            // move down

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - modifier);
            
        }

        if (Input.GetKey("a") && transform.position.x > -MAX_DISTANCE)
        {
            // move left
            transform.position = new Vector3(transform.position.x - modifier, transform.position.y, transform.position.z);

        }

        if (Input.GetKey("d") && transform.position.x < MAX_DISTANCE)
        {
            // move right
            transform.position = new Vector3(transform.position.x + modifier, transform.position.y, transform.position.z);

        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f && transform.position.y > MIN_CAMERA_DISTANCE) // Closer
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - modifier, transform.position.z);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f && transform.position.y < MAX_CAMERA_DISTANCE) // Farther
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + modifier, transform.position.z);
        }
	}
}
