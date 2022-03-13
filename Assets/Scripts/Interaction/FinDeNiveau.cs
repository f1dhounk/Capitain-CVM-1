using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDeNiveau : MonoBehaviour
{

    private bool FinNiveau1 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Félicitation, le niveau est terminé.");
            GameManager.Instance.SaveData();
            FinNiveau1 = true;
            SceneManager.LoadScene("Level2");
        }
    }
}
