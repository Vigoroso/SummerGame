using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed = 1;
    public Text pickupCountText;
    public Text winText;

    private Rigidbody2D rb2d;
    private int pickupCount;

    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        pickupCount = 0;
        winText.text = "";
        setCountText();
    }

    void FixedUpdate() {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 keyboardMovement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(keyboardMovement * speed);
        Vector2 mouseMovement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        rb2d.AddForce(mouseMovement * speed);

    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("PickUp")){

           other.gameObject.SetActive(false);
           pickupCount++;
           setCountText();

        }
    }

    void setCountText()
    {
        pickupCountText.text = "Count: " + pickupCount.ToString();
        if(pickupCount == 15)
        {
            winText.text = "";
        }
    }
}
