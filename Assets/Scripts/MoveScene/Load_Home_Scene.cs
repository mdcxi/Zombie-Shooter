using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Home_Scene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}
