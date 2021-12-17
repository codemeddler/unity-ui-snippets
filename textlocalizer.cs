using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class textlocalizer : MonoBehaviour {

	public string text;

	void Start () {
		GetComponent<Text> ().text = locale.getLocalizedText (text);
	}
}
