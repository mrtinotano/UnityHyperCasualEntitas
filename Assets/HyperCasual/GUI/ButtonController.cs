using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HyperCasual.GUI
{
    public abstract class ButtonController : MonoBehaviour
    {
        protected abstract void OnButtonClick();

        protected virtual void Awake()
        {
            GetComponent<Button>().onClick.AddListener(() => OnButtonClick());
        }
    }
}
