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
    using uFrame.Kernel;
    
    
    public class PlayGameButtonClickedHandler {
        
        public PlayGameButton Group;
        
        private uFrame.ECS.PointerClickDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private object ActionNode12_message = default( System.Object );
        
        private string StringNode14 = "1";
        
        private object ActionNode13_message = default( System.Object );
        
        private string StringNode15 = "2";
        
        public uFrame.ECS.PointerClickDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode12_message = StringNode14;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            while (this.DebugInfo("12fae0e0-3723-4d36-9b84-c418fd17e038","945b968d-9e83-4fe5-a773-6422ee7e700f", this) == 1) yield return null;
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode12_message);
            ActionNode13_message = StringNode15;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            while (this.DebugInfo("945b968d-9e83-4fe5-a773-6422ee7e700f","cf6d7d04-40d6-4a3f-94d5-dc65ed1719b9", this) == 1) yield return null;
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode13_message);
            // HANDLER: PlayGameButtonClicked
            yield break;
        }
    }
}
