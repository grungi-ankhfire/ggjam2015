using UnityEngine;
using System.Collections;

public class DayEndBehaviour : MonoBehaviour {

    private Animator animator;

	// Use this for initialization
	void Start () {
	   animator = GetComponent<Animator>();
	}
	
    public void EndDay() {
        animator.SetTrigger("Animate outro");
    }

    public void SkipToNextDay() {
        Application.LoadLevel(Application.loadedLevel+1);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
