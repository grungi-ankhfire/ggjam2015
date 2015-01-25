using UnityEngine;
using System.Collections;

public class ScreenFadeBehaviour : MonoBehaviour {

    public string message;
    // TODO : Add sound

    public float fadeTime = 2.0f;
    public Animator animator;

    public Animator textAnimator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Initialize() {
        animator.SetTrigger("Fade to black");
    }

    public void FadeFromBlack() {
        animator.SetTrigger("Fade from black");
    }

    public void StartText() {
        textAnimator.SetTrigger("Animate");
    }
}
