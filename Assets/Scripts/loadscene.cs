using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadscene : MonoBehaviour
{
    public GameObject loadingCanvas;
    public Image loading;
    public Scene scene;
    private string _numberOfLevel;
    // Start is called before the first frame update
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(LoadLevel);
        _numberOfLevel = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
        print(_numberOfLevel);
    }
    
    private void LoadLevel()
    {
        _numberOfLevel = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
        print("Load Level"  + _numberOfLevel);
        if (SceneManager.LoadSceneAsync("Level" + _numberOfLevel) != null)
        {
            StartCoroutine(LoadingScreen());
        }
    }

    IEnumerator LoadingScreen()
    {
        
        AsyncOperation loadScene = SceneManager.LoadSceneAsync("Level" + _numberOfLevel);
        loadingCanvas.SetActive(true);

        while (!loadScene.isDone)
        {
            loading.fillAmount = Mathf.Clamp01(loadScene.progress/0.9f);

            yield return null;
        }
    }



}
