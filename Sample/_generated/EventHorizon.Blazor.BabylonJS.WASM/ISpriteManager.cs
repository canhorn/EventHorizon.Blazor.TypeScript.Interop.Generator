/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface ISpriteManager { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ISpriteManagerCachedEntity : CachedEntityObject, IDisposable, ISpriteManager
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public decimal layerMask
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "layerMask"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "layerMask",
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

        
        public decimal renderingGroupId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "renderingGroupId"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderingGroupId",
                    value
                );
            }
        }

        
        public Sprite[] sprites
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Sprite>(
                    this.___guid,
                    "sprites",
                    (entity) =>
                    {
                        return new Sprite(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "sprites",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ISpriteManagerCachedEntity() : base() { }

        public ISpriteManagerCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        #region intersects TODO: Get Comments as metadata identification
        private bool _isIntersectsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _intersectsActionMap = new Dictionary<string, Func<Task>>();

        public string intersects(
            Func<Task> callback
        )
        {
            SetupIntersectsLoop();

            var handle = Guid.NewGuid().ToString();
            _intersectsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupIntersectsLoop()
        {
            if (_isIntersectsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "intersects",
                "CallIntersectsActions",
                _invokableReference
            );
            _isIntersectsEnabled = true;
        }

        [JSInvokable]
        public async Task CallIntersectsActions()
        {
            foreach (var action in _intersectsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region multiIntersects TODO: Get Comments as metadata identification
        private bool _isMultiIntersectsEnabled = false;
        private readonly IDictionary<string, Func<Task>> _multiIntersectsActionMap = new Dictionary<string, Func<Task>>();

        public string multiIntersects(
            Func<Task> callback
        )
        {
            SetupMultiIntersectsLoop();

            var handle = Guid.NewGuid().ToString();
            _multiIntersectsActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupMultiIntersectsLoop()
        {
            if (_isMultiIntersectsEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "multiIntersects",
                "CallMultiIntersectsActions",
                _invokableReference
            );
            _isMultiIntersectsEnabled = true;
        }

        [JSInvokable]
        public async Task CallMultiIntersectsActions()
        {
            foreach (var action in _multiIntersectsActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void render()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "render" }
                }
            );
        }
        #endregion
    }
}