using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {

/* ---------- Public ---------- */
	public enum Faction {HUMAN};

	/* Game Objects */
	public GameObject square;
	public GameObject camera;

	public GameObject selected;

	public Faction faction_1;
	public Faction faction_2;

	public GameObject[][] gameboard;


	/* Integers */
	public int WIDTH, HEIGHT;


/* ---------- Private ---------- */


/* ---------- Init Methods ----------*/

	void Start()
	{
		// Create board
		for(int i=0; i<HEIGHT; i++)
		{
			for(int j=0; j<WIDTH; j++)
			{

			}
		}

		bool isBlack = true;
		gameboard = new GameObject[WIDTH][];
		for(int i=0; i<WIDTH; i++)
		{
			gameboard[i] = new GameObject[HEIGHT];
			for(int j=0; j<HEIGHT; j++)
			{
				GameObject squr = Instantiate (square, new Vector2(i, j), Quaternion.identity) as GameObject;
				if(isBlack)
				{
					squr.renderer.material.color = Color.black;
				}
				else
				{
					squr.renderer.material.color = Color.white;
				}
				gameboard[i][j] = squr;
				isBlack = !isBlack;
			}
			isBlack = !isBlack;
		}

		camera.transform.position = new Vector3(WIDTH/2 - 0.5f, HEIGHT/2 - 0.5f, -10);
		camera.camera.orthographicSize = 9;

		SpawnPlayer_1 ();
		SpawnPlayer_2 ();

	}

	public void SpawnPlayer_1()
	{
		switch(faction_1)
		{
		case Faction.HUMAN:
			GetComponent<SpawnHuman>().SpawnFirst(WIDTH, HEIGHT);
			break;
		default:
			break;
		}
	}

	public void SpawnPlayer_2()
	{
		switch(faction_2)
		{
		case Faction.HUMAN:
			GetComponent<SpawnHuman>().SpawnSecond(WIDTH, HEIGHT);
			break;
		default:
			break;
		}
	}

}
