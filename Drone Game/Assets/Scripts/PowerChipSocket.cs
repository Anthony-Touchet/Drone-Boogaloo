﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerChipSocket : MonoBehaviour
{
    [SerializeField] GameObject m_powerChip;
    [SerializeField] SignalTransmitter m_signalTransmitter;

    private bool m_grabbing
    {
        get
        {
            // PC testing edit
            //if (Input.GetKey(KeyCode.Space))
            //    return true;
            //else
            //    return false;

            while (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                return true;
            }
            return false;
        }
    }

    private void Update()
    {
        if (m_powerChip == null)
            m_signalTransmitter.PowerOff();
        else
            m_signalTransmitter.PowerOn();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Chip")) return;

        m_powerChip.SetActive(true);
        other.gameObject.SetActive(false);
    }
}
