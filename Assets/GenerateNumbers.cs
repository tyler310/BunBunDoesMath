using UnityEngine;
using System.Collections;

public class GenerateNumbers : MonoBehaviour {
	public GameObject prefab0;
	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	public GameObject prefab5;
	public GameObject prefab6;
	public GameObject prefab7;
	public GameObject prefab8;
	public GameObject prefab9;

	// Use this for initialization

	public int platform;
	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, 0.3f);    //generate
	}
	
	void CreateObstacle()
	{
		platform = Random.Range (0, 10);             //radom number generator b/w 1 and 7
		float randomX = Random.Range(-100f, 100f);      // appear b/w -5 and 5 in y-axis
		
		switch (platform)
		{
		case 0: 
			Instantiate(prefab0, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 1: 
			Instantiate(prefab1, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 2: 
			Instantiate(prefab2, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 3: 
			Instantiate(prefab3, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 4: 
			Instantiate(prefab4, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 5: 
			Instantiate(prefab5, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 6: 
			Instantiate(prefab6, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 7: 
			Instantiate(prefab7, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 8: 
			Instantiate(prefab8, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		case 9: 
			Instantiate(prefab9, new Vector2(randomX, 6), Quaternion.identity); 
			break;
		}
	}
}