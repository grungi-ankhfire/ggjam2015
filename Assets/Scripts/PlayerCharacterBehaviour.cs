using UnityEngine;
using System.Collections;

public class PlayerCharacterBehaviour : MonoBehaviour {

    public float movementSpeed = 0f;
    public Animator animator;

    public int blockedDirection = 0;

    public GameObject interactionMark;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("Movement speed", movementSpeed);
        if (movementSpeed != 0f && ((Mathf.Sign(movementSpeed) != Mathf.Sign(blockedDirection)) ||  blockedDirection == 0)) {
            transform.position = new Vector2(transform.position.x + movementSpeed*Time.deltaTime, transform.position.y);
        }

	}

    public void DisplayInteractionMark(bool enable) {
        interactionMark.SetActive(enable);
    }

}
