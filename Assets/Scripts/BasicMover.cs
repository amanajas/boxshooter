using UnityEngine;
using System.Collections;

public class BasicMover : MonoBehaviour {

    public float spinSpeed = 180.0f;
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
	}
}
