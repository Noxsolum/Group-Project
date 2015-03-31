using UnityEngine;
using System.Collections;

public class SeigeTower : MonoBehaviour {

	public int startingHealth = 10;
	public int currentHealth;
	public float speed = 10;

	public GameObject seige;
	GameObject wall;
	void Awake ()
	{
		seige = GameObject.FindGameObjectWithTag("Player");
		wall = GameObject.FindGameObjectWithTag ("Finish");
		currentHealth = startingHealth;
	}
	// Update is called once per frame
	void Update() 
	{
		rigidbody2D.velocity = new Vector2(speed,0);

		if (currentHealth == 0)
		{
			Destroy(gameObject);
			Debug.Log ("DeadClick");
			Application.Quit();
		}
	}

	public void TakeDamage (int amount)
	{
		
		// Reduce the current health by the damage amount.
		currentHealth -= amount;

		if (currentHealth <= 0)
		{
			Destroy(gameObject);
			Debug.Log ("DeadClick");
			Application.Quit();
		}
	}
		
		void OnTriggerEnter2D (Collider2D other)
		{
			if(other.gameObject == wall)
		{
			Debug.Log ("Dead");
			Application.Quit();
		}
	}
}