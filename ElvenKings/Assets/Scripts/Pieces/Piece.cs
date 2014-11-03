using UnityEngine;
using System.Collections;

/* Parent class for all game pieces */
public class Piece : MonoBehaviour {

	public enum Colour {BLACK, WHITE};

	public Colour colour;
	public Vector2 curPos;
	public int PieceValue;

	protected bool isSelected;

	void Start()
	{
		isSelected = false;
	}



	public void ShowAvailableMoves()
	{}

	public void Select()
	{
		isSelected = !isSelected;

		if(isSelected)
		{
			if(GameObject.FindGameObjectWithTag("GameController").GetComponent<Board>().selected != null)
			{
				GameObject.FindGameObjectWithTag("GameController").GetComponent<Board>().selected.GetComponent<Piece>().Select ();
			}
			GameObject.FindGameObjectWithTag("GameController").GetComponent<Board>().selected = gameObject;
		}
		else
		{
			GameObject.FindGameObjectWithTag("GameController").GetComponent<Board>().selected = null;
		}

	}

	public bool DetectThreat()
	{
		return false;
	}

}
