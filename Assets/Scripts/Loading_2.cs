using UnityEngine;
using UnityEngine.UI;

public class Loading_2 : MonoBehaviour {
    public float speed;
    public GameObject obj;
    private float currentLoading = 0;
    private GameObject text1,text2;
    private bool isStartLoadingnow = false;


	void Start () {
        text1 = GameObject.Find("Text-gg");
        text2 = GameObject.Find("Text-dd");
	}
	
	void Update () {
		if(isStartLoadingnow == true)
        {
            if (currentLoading < 100)
            {
                currentLoading += Time.deltaTime * speed;
                obj.GetComponent<Image>().fillAmount = currentLoading / 100;
                text1.GetComponent<Text>().text = (int)currentLoading + "%";
                text2.GetComponent<Text>().text = "正在载入...";
            }
            else
            {
                text1.GetComponent<Text>().text = "完成！";
                text2.SetActive(false);
            }
        }
	}

    public void StartLoading_2()
    {
        isStartLoadingnow = true;
    }
}
