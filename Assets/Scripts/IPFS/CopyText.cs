using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CopyText : MonoBehaviour
{
    public TMP_Text hashText;
    public TMP_Text CID;

    public void CopyAddress_ButtonCall()
    {
        GUIUtility.systemCopyBuffer = hashText.text;
        CID.text = hashText.text;
    }
}
