using UnityEngine;
using System.Collections;

public class Pawn : Piece {
	
	public GameObject highlight;

	void Start()
	{

	}

	void Update()
	{
//		if(Input.GetMouseButtonDown(0) && isSelected)
//		{
//			Debug.Log ("click");
//			Select ();
//			ShowAvailableMoves();
//		}
		
	}
	public void ShowAvailableMoves()
	{
		// Destroy all highlights on board
		GameObject[] objs = GameObject.FindGameObjectsWithTag("highlight");
		
		for(int i=0; i<objs.Length; i++)
		{
			Destroy (objs[i]);
		}
		
		if(isSelected)
		{
			Color yel = Color.yellow;
//			yel.a = 0.8f;
			if(colour == Colour.BLACK)
			{
				GameObject hl = Instantiate (highlight, new Vector3(curPos.x, curPos.y + 1, -3), Quaternion.identity) as GameObject;
				hl.renderer.material.color = yel;
				hl.tag = "highlight";
			}
			else
			{
				// handle opposite side of the board case
				GameObject hl = Instantiate (highlight, new Vector3(curPos.x, curPos.y-1, -3), Quaternion.identity) as GameObject;
				hl.renderer.material.color = yel;
				hl.tag = "highlight";
			}
		}
	}


	void OnMouseDown()
	{
		Select ();
		ShowAvailableMoves ();
	}

}
