using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float score;

    void Update()
    {
       score = ((player.position.z)/5)-1.5f;
        if (score < 0)
        {
            score = 0;
        }
       scoreText.text = score.ToString("0"); 
    }

}
