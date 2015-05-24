public class Score : MonoBehaviour {
    public static int score;

    Text text;

	// Use this for initialization
	void Awake () {
        text = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        score++;
        text.text = score.ToString();

	}
}
