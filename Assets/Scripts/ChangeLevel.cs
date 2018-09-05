using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeLevel : MonoBehaviour {


    public void Level_02()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_01()
    {
        SceneManager.LoadScene(0);
    }
}
