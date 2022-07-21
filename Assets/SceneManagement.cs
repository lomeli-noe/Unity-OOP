using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneManagement : MonoBehaviour
{
    public void LoadScene()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Test");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
