using UnityEngine;
using System.Collections;

public class SpawnHuman : MonoBehaviour {

	public GameObject black_pawn, white_pawn;

	public void SpawnFirst(int w, int h)
	{
		SpawnInfantry (0, w, h);
	}

	public void SpawnSecond(int w, int h)
	{
		SpawnInfantry (1, w, h); 
	}

	private void SpawnInfantry(int player, int width, int height)
	{
		if(0 == player)
		{
			for(int i=0; i<width; i++)
			{
				GameObject p = Instantiate (black_pawn, new Vector3(i, 1, -2), Quaternion.identity) as GameObject;
				GetComponent<Board>().gameboard[i][1].GetComponent<SquareController>().SetPiece(p);
				GetComponent<Board>().gameboard[i][1].GetComponent<SquareController>().GetPiece().GetComponent<Piece>().curPos = new Vector2(i,1);
			}
		}
		else
		{
			for(int i=0; i<width; i++)
			{
				GameObject p = Instantiate (white_pawn, new Vector3(i, height-2, -2), Quaternion.identity) as GameObject;
				GetComponent<Board>().gameboard[i][height-2].GetComponent<SquareController>().SetPiece(p);
				GetComponent<Board>().gameboard[i][height-2].GetComponent<SquareController>().GetPiece().GetComponent<Piece>().curPos = new Vector2(i,height-2);
			}
		}

	}

}
