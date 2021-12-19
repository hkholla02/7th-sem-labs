using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//UI -> Button
//UI -> Panel
//Under Panel -> UI -> slider (interactale uncheck, Transition and Navigation == none) -> delete Handle slider area
//In slider -> change color (slider -> fill area -> fill) -> add Text (UI -> Text) (change to 0%)
//Empty GameObj -> script -> Loading scene == panel, Slider == slider, Progress text = text (drag and drop those components in inspector)
//Button -> onClick -> Drag and drop GameObj -> loadlevel
//1
//Disable panel in inspector

public class nine : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LoadingScreen;
    public Slider slider;
    public Text progressText;
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        
    }
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation Operation = SceneManager.LoadSceneAsync(sceneIndex);

        LoadingScreen.SetActive(true);

        while(!Operation.isDone)
        {
            float progress = Mathf.Clamp01(Operation.progress/.9f);
            slider.value = progress;
            progressText.text=progress*100f+"%";
            yield return null;
        }
    }
}
