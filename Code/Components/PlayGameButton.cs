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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(13)]
    [uFrame.Attributes.uFrameIdentifier("bf206805-1753-4312-b96a-cd6dba9d62e5")]
    public partial class PlayGameButton : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private GameObject[] _InstantiateItems;
        
        private ReactiveCollection<GameObject> _InstantiateItemsReactive;
        
        public override int ComponentId {
            get {
                return 13;
            }
        }
        
        public ReactiveCollection<GameObject> InstantiateItems {
            get {
                if (_InstantiateItemsReactive == null) {
                    _InstantiateItemsReactive = new ReactiveCollection<GameObject>(_InstantiateItems ?? new GameObject[] { });
                }
                return _InstantiateItemsReactive;
            }
        }
    }
}
