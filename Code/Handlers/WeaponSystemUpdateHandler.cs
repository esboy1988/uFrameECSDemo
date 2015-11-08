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
    using uFrame.Kernel;
    using uFrame.ECS;
    using UnityEngine;
    
    
    public class WeaponSystemUpdateHandler {
        
        public ShootingGuns Group;
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private float ActionNode4_Result = default( System.Single );
        
        private float ActionNode6_a = default( System.Single );
        
        private float ActionNode6_b = default( System.Single );
        
        private bool ActionNode6_Result = default( System.Boolean );
        
        private float ActionNode2_a = default( System.Single );
        
        private float ActionNode2_b = default( System.Single );
        
        private float ActionNode2_Result = default( System.Single );
        
        private UnityEngine.GameObject ActionNode15_gameObject = default( UnityEngine.GameObject );
        
        private UnityEngine.Vector3 ActionNode15_position = default( UnityEngine.Vector3 );
        
        private UnityEngine.Vector3 ActionNode15_rotation = default( UnityEngine.Vector3 );
        
        private UnityEngine.GameObject ActionNode15_Result = default( UnityEngine.GameObject );
        
        private UnityEngine.GameObject ActionNode1_gameObject = default( UnityEngine.GameObject );
        
        private float ActionNode1_time = default( System.Single );
        
        private float FloatNode27 = 3F;
        
        public uFrame.ECS.ISystemUpdate Event {
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
        
        public virtual void Execute() {
            // ActionNode
            // Visit uFrame.Actions.TimeLibrary.GetTime
            ActionNode4_Result = uFrame.Actions.TimeLibrary.GetTime();
            ActionNode6_a = ActionNode4_Result;
            ActionNode6_b = Group.Gun.NextFire;
            // ActionNode
            // Visit uFrame.Actions.Comparisons.GreaterThan
            ActionNode6_Result = uFrame.Actions.Comparisons.GreaterThan(ActionNode6_a, ActionNode6_b, ActionNode6_yes, ActionNode6_no);
        }
        
        private void ActionNode6_yes() {
            ActionNode2_a = ActionNode4_Result;
            ActionNode2_b = Group.Gun.FireRate;
            // ActionNode
            // Visit uFrame.Actions.FloatLibrary.Add
            ActionNode2_Result = uFrame.Actions.FloatLibrary.Add(ActionNode2_a, ActionNode2_b);
            // SetVariableNode
            Group.Gun.NextFire = (System.Single)ActionNode2_Result;
            ActionNode15_gameObject = Group.Gun.ProjectilePrefab;
            ActionNode15_position = Group.Entity.transform.position;
            // ActionNode
            // Visit uFrame.Actions.GameObjects.Instantiate
            ActionNode15_Result = uFrame.Actions.GameObjects.Instantiate(ActionNode15_gameObject, ActionNode15_position, ActionNode15_rotation);
            ActionNode1_gameObject = ActionNode15_Result.gameObject;
            ActionNode1_time = FloatNode27;
            // ActionNode
            // Visit uFrame.Actions.DestroyLibrary.DestroyGameObject
            uFrame.Actions.DestroyLibrary.DestroyGameObject(ActionNode1_gameObject, ActionNode1_time);
        }
        
        private void ActionNode6_no() {
        }
    }
}
