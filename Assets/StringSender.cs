
using System;
using UnityEngine;

public class StringSender : MonoBehaviour
{
    public string value = "";
    public string address = "";

    // Use this for initialization
    void Start()
    {
        sendOsc(this.value);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Select(string value)
    {
        sendOsc(value);
        this.value = value;
    }

    protected void sendOsc(string value)
    {
        OSCHandler.Instance.SendMessageToClient("Haptic", this.address, value);
        OSCHandler.Instance.UpdateLogs();
    }
}
