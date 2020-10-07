using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Camera cam;
    public Rigidbody2D rbody;
    public GameObject player;
    private float maxWidth; 

	void Start ()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        maxWidth = targetWidth.x; 
    }

	void FixedUpdate ()
    {
        Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
        Vector3 targetPosition = new Vector3 (rawPosition.x, 0.0f, 0.0f);
        float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth +3.0f, maxWidth -3.0f);
        targetPosition = new Vector3(targetWidth, targetPosition.y, targetPosition.z);
        rbody.MovePosition (targetPosition);
	}
}
