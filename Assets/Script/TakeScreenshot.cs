using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.InteropServices;
using NatShareU;

public class TakeScreenshot : MonoBehaviour {

    public Image canvas;
    public string subject, ShareMessage;
    string ShareText = "Bagikan Ke Dapur";
    Texture2D tex;

    public GameObject CanvasMenu;
    public GameObject CanvasTakeCapture;
    public GameObject CanvasScreenshot;
    CaptureAndSave snapShot;

    public void HidePanelMenu()
    {
        CanvasMenu.SetActive(false);
    }

    public void ShowPanelMenu()
    {
        CanvasMenu.SetActive(true);
    }

    void Start()
    {
        snapShot = GameObject.FindObjectOfType<CaptureAndSave>();
    }

    void OnEnable()
    {
        CaptureAndSaveEventListener.onError += OnError;
        CaptureAndSaveEventListener.onSuccess += OnSuccess;
        CaptureAndSaveEventListener.onScreenShotInvoker += OnScreenShot;
    }

    void OnDisable()
    {
        CaptureAndSaveEventListener.onError -= OnError;
        CaptureAndSaveEventListener.onSuccess -= OnSuccess;
        CaptureAndSaveEventListener.onScreenShotInvoker -= OnScreenShot;
    }

    void OnError(string error)
    {
        Debug.Log("Error : " + error);
    }

    void OnSuccess(string msg)
    {
        Debug.Log("Success : " + msg);
    }

    void OnScreenShot(Texture2D tex2D)
    {
        // assign screenshot
        tex = tex2D;
    }

    public void TakeScreenshotCanvas()
    {
        StartCoroutine(TakeCapture());
    }

    IEnumerator TakeCapture()
    {
        yield return new WaitForEndOfFrame();
        snapShot.GetFullScreenShot(ImageType.JPG);
        //snapShot.GetFullScreenShot(ImageType.JPG, watermark, WatermarkAlignment.TOP_RIGHT);// save with watermark
        yield return new WaitForSeconds(2f);
    }

    public void SaveScreenshot()
    {
        // save screenshot
        snapShot.SaveTextureToGallery(tex, ImageType.JPG);
        Sprite sp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
            new Vector2(0.5f, 0.5f));
        canvas.GetComponent<Image>().sprite = sp;
    }

    public void ShareScreenshot()
    {
        //AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");

        //intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
        //AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + snapShot);
        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
        //intentObject.Call<AndroidJavaObject>("setType", "image/png");

        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), ShareMessage);

        //AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        //AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

        //AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share Picture");
        //currentActivity.Call("startActivity", jChooser);

        Texture2D image = tex;
        NatShare.Share(image);
    }

}
