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
    using uFrame.Actions;
    using UnityEngine;
    
    
    [uFrame.Attributes.ActionTitle("Publish PlayGame")]
    public class PublishPlayGameAction : uFrame.Actions.UFAction {
        
        public override void Execute() {
            var evt = new PlayGame();
            System.Publish(evt);
        }
    }
}
