using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTransition : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 8f;   //After 8 seconds pass from when the scene is loaded the next scene loads
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

}
    

    
