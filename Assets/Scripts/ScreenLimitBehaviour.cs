using UnityEngine;
using System.Collections;

public class ScreenLimitBehaviour : MonoBehaviour {

    public int blockingDirection;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerCharacterBehaviour>().blockedDirection = blockingDirection;
        }     
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerCharacterBehaviour>().blockedDirection = 0;
        }
    }

}
