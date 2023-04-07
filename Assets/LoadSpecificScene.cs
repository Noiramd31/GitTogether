using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSpecificScene : MonoBehaviour
{
    //public string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("poulet");
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Lvl002");
        }
    }
}
