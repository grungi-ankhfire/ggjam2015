﻿using UnityEngine;
using System.Collections;

public class KeyboardManager : MonoBehaviour {

    public bool canMove = true;
    public PlayerCharacterBehaviour character;
    public float movementSpeed = 1f;

    public PlayerCharacterBehaviour shadow;

    public float transitionTimer = 0f;

    public bool shadowActive = false;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        UpdateShadow();
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

    void UpdateShadow() {
        if (shadow != null && shadowActive) {
            if (transitionTimer > 0f) {
                shadow.movementSpeed = 0f;
                transitionTimer -= Time.deltaTime;
                if (transitionTimer < 0f) {
                    transitionTimer = 0f;
                }
            } else {
                if(Input.GetKey(KeyCode.RightArrow)) {
                    shadow.movementSpeed = movementSpeed*1.6f;
                } else if(Input.GetKey(KeyCode.LeftArrow)) {
                    shadow.movementSpeed = movementSpeed*1.6f;
                } else {
                    shadow.movementSpeed = 0f;
                }
            }            
        }
    }
}
