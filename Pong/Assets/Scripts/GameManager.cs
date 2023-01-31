using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float playerScore;
    public float computerScore;
    public Ball ball;

    public void PlayerScores()
    {
        playerScore++;
        ball.ResetPosition();
    }
    public void ComputerScores()
    {
        computerScore++;
        ball.ResetPosition();
    }



}
