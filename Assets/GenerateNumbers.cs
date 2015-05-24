using UnityEngine;
using System.Collections;

public class GenerateNumbers : MonoBehaviour {
	public GameObject Prefab;
	// Use this for initialization

	public int platform;
	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, 0.3f);    //generate
	}
	
	void CreateObstacle()
	{
		//platform = Random.Range (0, 9);             //radom number generator b/w 1 and 7
		float randomX = Random.Range(-6f, 6f);      // appear b/w -5 and 5 in y-axis
		
		//switch (platform)
		//{
		//case 0: 
			Instantiate(Prefab, new Vector2(randomX, 6), Quaternion.identity); 
		//	break;
		//}
	}
}