// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    [UnityEditor.InitializeOnLoadAttribute()]
    [uFrame.Attributes.uFrameIdentifier("dca25034-7bd7-4a39-94d5-f23554ec29f0")]
    public class DemoEditorExtensions {
        
        [UnityEditor.MenuItem("GameObject/Create Demo Kernel", false, 0)]
        public static void AddKernel() {
            Invert.uFrame.ECS.Templates.EcsEditorExtensionTemplate.AddEcsKernelWith<uFrameECSDemo.DemoLoader>();
        }
    }
}
