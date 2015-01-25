using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractionBehaviour : MonoBehaviour {

    public ScreenFadeBehaviour screenFade;

    private KeyboardManager keyboardManager;

    public string interactionMessage;
    public Text interactionText;

	// Use this for initialization
	void Start () {
	   keyboardManager = Camera.main.GetComponent<KeyboardManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerCharacterBehaviour>().DisplayInteractionMark(true);
        }     
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerCharacterBehaviour>().DisplayInteractionMark(false);
        }
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            if ((keyboardManager.transitionTimer == 0f) && (Input.GetKeyUp("space") || Input.GetKeyDown("space"))) {
                Debug.Log("Initializing fading");
                screenFade.Initialize();
				if(GetComponent<AudioSource>().isPlaying)
				{
					GetComponent<AudioSource>().Stop();
				}
				else
				{
                	GetComponent<AudioSource>().PlayDelayed(1f);
				}
                interactionText.text = interactionMessage;
                keyboardManager.transitionTimer = 5f;
				GetComponent<BoxCollider2D>().enabled=false;
            }
        }
    }
}
