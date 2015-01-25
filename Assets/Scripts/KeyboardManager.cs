using UnityEngine;
using System.Collections;

public class KeyboardManager : MonoBehaviour {

    public bool canMove = true;
    public PlayerCharacterBehaviour character;
    public float movementSpeed = 1f;

    public float transitionTimer = 0f;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        if (transitionTimer > 0f) {
            character.movementSpeed = 0f;
            transitionTimer -= Time.deltaTime;
            if (transitionTimer < 0f) {
                transitionTimer = 0f;
            }
        } else {
            if(Input.GetKey(KeyCode.RightArrow)) {
                character.movementSpeed = movementSpeed;
            } else if(Input.GetKey(KeyCode.LeftArrow)) {
                character.movementSpeed = -movementSpeed;
            } else {
                character.movementSpeed = 0f;
            }
        }
    }
}
