using UnityEngine;
using System.Collections;

public class DayEndBehaviour : MonoBehaviour {

    private Animator animator;
    public bool lastDay = false;
    public AudioSource lastMusic;

	// Use this for initialization
	void Start () {
	   animator = GetComponent<Animator>();
	}
	
    public void EndDay() {
        animator.SetTrigger("Animate outro");
        if (lastDay) {
            lastMusic.volume = 1f;
        }
    }

    public void SkipToNextDay() {
        if (!lastDay) {
            Application.LoadLevel(Application.loadedLevel+1);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
