/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class Sprite : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal size
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "size"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "size",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public string name
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "name"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "name",
                    value
                );
            }
        }

        private Vector3 __position;
        public Vector3 position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInteropt.GetClass<Vector3>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private Color4 __color;
        public Color4 color
        {
            get
            {
            if(__color == null)
            {
                __color = EventHorizonBlazorInteropt.GetClass<Color4>(
                    this.___guid,
                    "color",
                    (entity) =>
                    {
                        return new Color4() { ___guid = entity.___guid };
                    }
                );
            }
            return __color;
            }
            set
            {
__color = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "color",
                    value
                );
            }
        }

        
        public decimal width
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "width"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "width",
                    value
                );
            }
        }

        
        public decimal height
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "height"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "height",
                    value
                );
            }
        }

        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal cellIndex
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "cellIndex"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cellIndex",
                    value
                );
            }
        }

        
        public string cellRef
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "cellRef"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cellRef",
                    value
                );
            }
        }

        
        public decimal invertU
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "invertU"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertU",
                    value
                );
            }
        }

        
        public decimal invertV
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "invertV"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "invertV",
                    value
                );
            }
        }

        
        public bool disposeWhenFinishedAnimating
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disposeWhenFinishedAnimating"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disposeWhenFinishedAnimating",
                    value
                );
            }
        }

        
        public Animation[] animations
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Animation>(
                    this.___guid,
                    "animations",
                    (entity) =>
                    {
                        return new Animation() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animations",
                    value
                );
            }
        }

        
        public bool isPickable
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isPickable"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isPickable",
                    value
                );
            }
        }

        private ActionManager __actionManager;
        public ActionManager actionManager
        {
            get
            {
            if(__actionManager == null)
            {
                __actionManager = EventHorizonBlazorInteropt.GetClass<ActionManager>(
                    this.___guid,
                    "actionManager",
                    (entity) =>
                    {
                        return new ActionManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __actionManager;
            }
            set
            {
__actionManager = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "actionManager",
                    value
                );
            }
        }

        
        public bool isVisible
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isVisible"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isVisible",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Sprite() : base() { } 

        public Sprite(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Sprite(
            string name, ISpriteManagerCachedEntity manager
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "Sprite" },
                name, manager
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region playAnimation TODO: Get Comments as metadata identification
        private bool _isPlayAnimationEnabled = false;
        private readonly IDictionary<string, Func<Task>> _playAnimationActionMap = new Dictionary<string, Func<Task>>();

        public string playAnimation(
            Func<Task> callback
        )
        {
            SetupPlayAnimationLoop();

            var handle = Guid.NewGuid().ToString();
            _playAnimationActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupPlayAnimationLoop()
        {
            if (_isPlayAnimationEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "playAnimation",
                "CallPlayAnimationActions",
                _invokableReference
            );
            _isPlayAnimationEnabled = true;
        }

        [JSInvokable]
        public async Task CallPlayAnimationActions()
        {
            foreach (var action in _playAnimationActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void stopAnimation()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "stopAnimation" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }
        #endregion
    }
}