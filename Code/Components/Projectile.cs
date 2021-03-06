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
    
    
    [uFrame.Attributes.ComponentId(218)]
    [uFrame.Attributes.uFrameIdentifier("94f65036-c558-4329-9688-353472d6bba9")]
    public partial class Projectile : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Vector3 _Direction;
        
        [UnityEngine.SerializeField()]
        private Single _Speed;
        
        private Subject<PropertyChangedEvent<Vector3>> _DirectionObservable;
        
        private PropertyChangedEvent<Vector3> _DirectionEvent;
        
        private Subject<PropertyChangedEvent<Single>> _SpeedObservable;
        
        private PropertyChangedEvent<Single> _SpeedEvent;
        
        public override int ComponentId {
            get {
                return 218;
            }
        }
        
        public IObservable<PropertyChangedEvent<Vector3>> DirectionObservable {
            get {
                return _DirectionObservable ?? (_DirectionObservable = new Subject<PropertyChangedEvent<Vector3>>());
            }
        }
        
        public IObservable<PropertyChangedEvent<Single>> SpeedObservable {
            get {
                return _SpeedObservable ?? (_SpeedObservable = new Subject<PropertyChangedEvent<Single>>());
            }
        }
        
        public Vector3 Direction {
            get {
                return _Direction;
            }
            set {
                SetDirection(value);
            }
        }
        
        public Single Speed {
            get {
                return _Speed;
            }
            set {
                SetSpeed(value);
            }
        }
        
        public virtual void SetDirection(Vector3 value) {
            SetProperty(ref _Direction, value, ref _DirectionEvent, _DirectionObservable);
        }
        
        public virtual void SetSpeed(Single value) {
            SetProperty(ref _Speed, value, ref _SpeedEvent, _SpeedObservable);
        }
    }
}
