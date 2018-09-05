using UnityEngine;
using UnityEngine.UI;
public class Loading : MonoBehaviour {

    public  float moveSpeed;
    private  float currentLoading = 0;
    private  GameObject text;
    private  GameObject loadingText;
    private  GameObject bj;
    private bool isOk = false;


    private void Awake()
    {
        text = GameObject.Find("hhh");
        loadingText = GameObject.Find("jjj");
        bj = GameObject.Find("Fill");
    }
    public void onClicked()
    {
        isOk = true;
    }
    void Update()
    {
        if(isOk == true)
        {
            if (currentLoading < 100)
            {

                currentLoading += Time.deltaTime * moveSpeed;
                text.GetComponent<Text>().text = (int)currentLoading + "%";


                loadingText.GetComponent<Text>().text = "载入中...";
                bj.GetComponent<Image>().fillAmount = currentLoading / 100;

            }
            else
            {
                text.GetComponent<Text>().text = "完成!";
                loadingText.gameObject.SetActive(false);
            }
        }

    }
}
