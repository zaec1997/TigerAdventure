using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadscene : MonoBehaviour
{
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
        SceneManager.LoadScene("Level" + _numberOfLevel);
    }
    
    



}
