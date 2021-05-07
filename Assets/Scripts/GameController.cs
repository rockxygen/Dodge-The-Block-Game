using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{
    public float matrixEffect = 10f;

    public void EndGame()
    {
        StartCoroutine(RestartGame());
    }

    IEnumerator RestartGame()
    {
        Time.timeScale = 1f / matrixEffect;
        Time.fixedDeltaTime /= matrixEffect;

        yield return new WaitForSeconds(2f / matrixEffect);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * matrixEffect;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
