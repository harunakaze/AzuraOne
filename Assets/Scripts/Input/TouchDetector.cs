using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class TouchDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	[HideInInspector]
	public bool isClicked { get; private set; }

	//TODO: Implement double touch protection

	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log ("Clicked");
		isClicked = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		Debug.Log ("Released");
		isClicked = false;
	}
}
