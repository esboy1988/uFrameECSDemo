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
    
    
    [uFrame.Attributes.ActionTitle("Add Gun Component")]
    public class AddGunAction : uFrame.Actions.UFAction {
        
        [uFrame.Attributes.In()]
        public uFrame.ECS.EcsComponent Beside;
        
        [uFrame.Attributes.In()]
        public Single FireRate;
        
        [uFrame.Attributes.In()]
        public Single NextFire;
        
        [uFrame.Attributes.In()]
        public String ProjectilePrefab;
        
        [uFrame.Attributes.In()]
        public GunState State;
        
        public override void Execute() {
            Beside.gameObject.AddComponent<Gun>();
        }
    }
}
