
using System;
using UnityEngine;

public class VelocitySender : MonoBehaviour {

    public float velocity = 0;
    public string address = "";

    protected float prevVelocity;

	// Use this for initialization
    void Start () {
        sendOsc(this.velocity);
        prevVelocity = this.velocity;
    }
	
	// Update is called once per frame
	void Update () {
        if (Math.Abs(this.prevVelocity - this.velocity) > 0) {
            sendOsc(this.velocity);
            prevVelocity = this.velocity;
        }
    }

    protected void sendOsc(float velocity) {
        OSCHandler.Instance.SendMessageToClient("Haptic", this.address, velocity);
        OSCHandler.Instance.UpdateLogs();
    }
}
