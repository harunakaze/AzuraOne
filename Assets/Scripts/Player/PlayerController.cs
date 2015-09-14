using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public TouchDetector touchDetector;

	private Animator animator;
	private int isOpen;

	void Start ()
	{
		animator = GetComponent<Animator> ();
		isOpen = Animator.StringToHash ("isOpen");
	}

	void Update ()
	{
		animator.SetBool(isOpen, touchDetector.isClicked);
	}
}
