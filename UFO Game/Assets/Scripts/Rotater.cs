using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

    void Start() {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}
}
