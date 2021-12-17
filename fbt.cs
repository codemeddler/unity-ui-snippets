using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fbt : MonoBehaviour {

	public float duration;
	public float speed;
	public Text textmessage;

	float startY;
	float playingtime;

	void Start() {
		startY = transform.position.y;
	}

	public void Play(string message) {
		textmessage.text = message;
		playingtime = duration;
		Vector3 oldpos = transform.position;
		oldpos.y = startY;
		transform.position = oldpos;
	}

	void Update () {
		if (playingtime > 0.0f) {
			Vector3 oldpos = transform.position;
			oldpos.y += speed * Time.deltaTime;
			transform.position = oldpos;
			playingtime -= Time.deltaTime;
			if (playingtime <= 0.0f)
				textmessage.text = "";
		}
	}
}
