using UnityEngine;
using System.Collections;

public class DoorBehaviour : MonoBehaviour {

	public BoxCollider2D[] ToDo;
    public RoomBehaviour roomFrom;
    public RoomBehaviour roomTo;
    public Transform destination;
	public AudioSource Ouvrir;
	public AudioSource Fermer;
	public AudioSource Verouiller;
	public AudioSource Deverouiller;
    public int slideDirection;
    public KeyboardManager keyboardManager;
    public bool makeShadowActive = false;

    private bool activable = false;
    private Collider2D player;
	private bool Unlocked = false;
	// Use this for initialization
	void Start () {
		if (ToDo.Length == 0) {
			Unlocked = true;
		}
        keyboardManager = Camera.main.GetComponent<KeyboardManager>();
	}
	private void Unlock()
	{
		bool CanBeUnlocked = true;
		foreach (BoxCollider2D Box in ToDo) 
		{
			if (Box.enabled == true)
			{
				CanBeUnlocked = false;
			}
		}
		if (CanBeUnlocked && Unlocked == false) {
			Deverouiller.PlayDelayed (5.5f);
			Unlocked = true;
		}
	}
	// Update is called once per frame
	void Update () {
		Unlock ();
        if(activable && Input.GetKeyDown("space")) 
		{
			if (Unlocked)
			{
				Ouvrir.Play ();
				if(roomTo != null)
				{
					Fermer.PlayDelayed(1.5f);
	            	keyboardManager.transitionTimer = 2f;
	            	roomFrom.Slide(slideDirection+2);
	            	roomTo.Slide(slideDirection);
	            	player.transform.parent = destination.parent;
	            	player.transform.position = destination.position;
					player.GetComponent<FootstepBehaviour>().room = roomTo.GetComponent<RoomBehaviour>().name;
				    keyboardManager.shadowActive = makeShadowActive;
                    makeShadowActive = false;
                }
				else {
                    Camera.main.GetComponent<DayEndBehaviour>().EndDay();
			    }
            }
			else
				Verouiller.Play();
        }
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            player = other;
            activable = true;
            other.gameObject.GetComponent<PlayerCharacterBehaviour>().DisplayInteractionMark(true);
        }     
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            activable = false;
            other.gameObject.GetComponent<PlayerCharacterBehaviour>().DisplayInteractionMark(false);
        }
    }
}
