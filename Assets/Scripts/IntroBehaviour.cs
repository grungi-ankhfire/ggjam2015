using UnityEngine;
using System.Collections;

public class IntroBehaviour : MonoBehaviour {

    public Animator textAnimator;
    public Animator cameraAnimator;
    public AudioSource alarmClock;

    private bool done = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyUp("space") && !done) {
            done = true;
            textAnimator.SetTrigger("Fade");
            cameraAnimator.SetTrigger("Animate");
            alarmClock.PlayDelayed(0.5f);
        }
	}
}
