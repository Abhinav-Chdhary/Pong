using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float playerScore;
    public float computerScore;
    public Ball ball;
    public Text computerText;
    public Text playerText;
    
    public void PlayerScores()
    {
        playerScore++;
        playerText.text = playerScore.ToString();
        ball.ResetPosition();
        ball.addStartingForce();
    }
    public void ComputerScores()
    {
        computerScore++;
        computerText.text = computerScore.ToString();
        ball.ResetPosition();
        ball.addStartingForce();
    }



}
