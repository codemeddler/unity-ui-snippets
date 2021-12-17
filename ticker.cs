using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ticker : MonoBehaviour {

	public Text text;

	public class tickerMessage
	{	
		public string message;
		public float timeShown;
		public float timeVisible;
	}

	Queue<tickerMessage> messages;
	tickerMessage currentMessage;

	static ticker m_instance;

	public static ticker Instance
	{
		get{ return m_instance; }
	}

	void Awake() {
		currentMessage = null;
		messages = new Queue<tickerMessage> ();
		m_instance = this;
	}

	public void pushMessage( tickerMessage message ) {
		messages.Enqueue (message);
	}
		
	// Update is called once per frame
	void Update () {
		if (currentMessage != null) {
			if (currentMessage.timeVisible >= currentMessage.timeShown) {
				currentMessage = null;
				text.text = "";
			} else {
				currentMessage.timeVisible += Time.deltaTime;
			}
		} else {
			if(messages.Count <= 0 )
				return;

			currentMessage = messages.Dequeue ();
			text.text = currentMessage.message;
			currentMessage.timeVisible = 0.0f;
		}
	}
}
