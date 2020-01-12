﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-12-13
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework;
using IFramework.Moudles;
using IFramework.Moudles.Coroutine;
using IFramework.Moudles.NodeAction;
using System;

namespace IFramework_Demo
{

    public class CoroutimeActionExample:UnityEngine.MonoBehaviour
	{
        private void Start()
        {
            Framework.Init();
            Framework.moudles.Coroutine = FrameworkMoudle.CreatInstance<CoroutineMoudle>();

           this.Sequence()
                .Repeat((r) => {
                    r.Sequence((s) =>
                    {
                        s.TimeSpan(new TimeSpan(0, 0, 5), false)
                         .Event(() => { Log.L("GG"); }, false)
                         .OnCompelete(() => { Log.L(1231); });
                    }, false)
                    ;
                },2,false)
                .TimeSpan(new TimeSpan(0, 0, 5),false)
                .OnCompelete((ss) => { /*ss.Reset();*/ })
                .OnDispose((ss) => { Log.L("dispose"); })
                .Run(Framework.moudles.Coroutine);
        }
        private void Update()
        {
            Framework.Update();
        }
        private void OnDestroy()
        {
            Framework.Dispose();
        }
    }
}
