﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MagiCloud.Core;

namespace MagiCloud.KGUI
{
    /// <summary>
    /// KGUI_Canvas
    /// </summary>
    [ExecuteInEditMode]
    public class KGUI_Canvas : MonoBehaviour
    {
        private Canvas canvas;

        private MBehaviour behaviour;

        private void Awake()
        {
            behaviour = new MBehaviour(ExecutionPriority.High, -800);
            behaviour.OnAwake(() =>
            {
                canvas = GetComponent<Canvas>();
                canvas.renderMode = RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = MUtility.UICamera;

            });

            MBehaviourController.AddBehaviour(behaviour);
        }

        private void OnDestroy()
        {
            if (behaviour != null)
                behaviour.OnExcuteDestroy();
        }
    }
}

