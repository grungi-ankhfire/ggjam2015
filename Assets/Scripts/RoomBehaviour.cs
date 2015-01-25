using UnityEngine;
using System.Collections;

public class RoomBehaviour : MonoBehaviour {

    public string name;
    public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Slide(int direction) {
        animator.SetInteger("Slide direction", direction);
    }
}
