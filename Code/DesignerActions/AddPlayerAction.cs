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
    using UnityEngine;
    using uFrame.Actions;
    
    
    [uFrame.Attributes.ActionTitle("Add Player Component")]
    public class AddPlayerAction : uFrame.Actions.UFAction {
        
        [uFrame.Attributes.In()]
        public uFrame.ECS.EcsComponent Beside;
        
        public override void Execute() {
            Beside.gameObject.AddComponent<Player>();
        }
    }
}
