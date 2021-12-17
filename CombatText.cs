using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatText : MonoBehaviour
{
	private Camera uiCamera;
	private Canvas uiCanvas;
	private RectTransform uiCanvasRectTransform;
	private Vector3 spawnPos;
	private string textShown;

	public void SetInitialValues(Vector3 position, string textToShow)
	{
		spawnPos = position;
		textShown = textToShow;
	}

	/// <summary>
	/// Initiate
	/// </summary>
	void Start ()
	{
		uiCamera = GameObject.Find("UICamera").GetComponent<Camera>();
		uiCanvas = GameObject.Find("CombatTextCanvas").GetComponent<Canvas>();
		uiCanvasRectTransform =  GameObject.Find("CombatTextCanvas").GetComponent<RectTransform>();
		GetComponent<RectTransform>().SetParent(uiCanvasRectTransform, false);
		GetComponent<Text>().text = textShown;
	}

	/// <summary>
	/// Move the UI element to the world position
	/// </summary>
	/// <param name="objectTransformPosition"></param>
	void LateUpdate()
	{
		Vector3 viewPos = uiCamera.WorldToViewportPoint(spawnPos);
		GetComponent<RectTransform>().anchoredPosition = new Vector2(viewPos.x * uiCanvas.pixelRect.width, viewPos.y * uiCanvas.pixelRect.height);
		spawnPos.y += Time.deltaTime;
		var a = GetComponent<Text>().color;
		a.a -= Time.deltaTime;
		
		if(a.a <= 0.0f)
			Destroy(gameObject);
		else
			GetComponent<Text>().color = a;
	}
}
