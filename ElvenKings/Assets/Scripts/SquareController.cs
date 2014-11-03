using UnityEngine;
using System.Collections;

public class SquareController : MonoBehaviour {


	public GameObject piece;

	public void SetPiece(GameObject obj)
	{
		piece = obj;
	}

	public GameObject GetPiece()
	{
		return piece;
	}

}
