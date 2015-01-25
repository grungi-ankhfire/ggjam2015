using UnityEngine;
using System.Collections;

public class FootstepBehaviour : MonoBehaviour {

    public AudioSource[] footstepsBedroom;
    public AudioSource[] footstepsBathroom;
    public AudioSource[] footstepsLivingroom;
    public AudioSource[] footstepsKitchen;

    public string room = "bathroom";

    public void PlayFootstep() {
        if (room == "bedroom") {
            int index = Random.Range(0, footstepsBedroom.Length);
            footstepsBedroom[index].Play();
        }
        if (room == "bathroom") {
            int index = Random.Range(0, footstepsBathroom.Length);
            footstepsBathroom[index].Play();
        }
        if (room == "livingroom") {
            int index = Random.Range(0, footstepsLivingroom.Length);
            footstepsLivingroom[index].Play();
        }
        if (room == "kitchen") {
            int index = Random.Range(0, footstepsKitchen.Length);
            footstepsKitchen[index].Play();
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
