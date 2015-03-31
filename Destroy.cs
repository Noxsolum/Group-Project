using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public int clickDamage = 1;
	GameObject seige;
	SeigeTower seigeHealth;

	// Use this for initialization
	void Start () {
	
		seige = GameObject.FindGameObjectWithTag("Player");
		seigeHealth = seige.GetComponent <SeigeTower> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (worldPoint, Vector2.zero);
			if (hit.collider != null) 
			{
				if (seigeHealth.currentHealth > 0) 
				{	
					// ... damage the player.
					seigeHealth.TakeDamage (clickDamage);
				}
			}
		}
	}
}
