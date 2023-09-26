using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;

public class DeteccionCara : MonoBehaviour
{
    public static WebCamTexture _webcamTexture;
    CascadeClassifier cascade;
    OpenCvSharp.Rect MyFace;
    public float faceX;
    public float faceY;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        DeteccionCara._webcamTexture = new WebCamTexture(devices[0].name);
        DeteccionCara._webcamTexture = new WebCamTexture(1080, 1920);
        DeteccionCara._webcamTexture.Play();

        cascade = new CascadeClassifier(System.IO.Path.Combine(Application.streamingAssetsPath, @"haarcascade_frontalface_default.xml"));
    }

    void Update()
    {
        DeteccionCara._webcamTexture.Play();
        Mat frame = OpenCvSharp.Unity.TextureToMat(DeteccionCara._webcamTexture);

        findNewFace(frame);
        display(frame);
    }

    void findNewFace(Mat frame)
    {
        var faces = cascade.DetectMultiScale(frame, 2, 2, HaarDetectionType.ScaleImage);

        if (faces.Length >= 1)
        {
            MyFace = faces[0];
            faceX = faces[0].X;
            faceY = faces[0].Y;
        }
    }

    void display(Mat frame)
    {
        if (MyFace != null)
        {
            frame.Rectangle(MyFace, new Scalar(250, 0, 0), 2);
        }

        Texture newtexture = OpenCvSharp.Unity.MatToTexture(frame);
        GetComponent<Renderer>().material.mainTexture = newtexture;
    }
}