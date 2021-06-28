/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterialBuildStateSharedData>))]
    public class NodeMaterialBuildStateSharedData : CachedEntityObject
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
        
        public string[] temps
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "temps"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "temps",
                    value
                );
            }
        }

        
        public string[] varyings
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "varyings"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "varyings",
                    value
                );
            }
        }

        
        public string varyingDeclaration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "varyingDeclaration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "varyingDeclaration",
                    value
                );
            }
        }

        
        public InputBlock[] inputBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<InputBlock>(
                    this.___guid,
                    "inputBlocks",
                    (entity) =>
                    {
                        return new InputBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputBlocks",
                    value
                );
            }
        }

        
        public TextureBlock[] textureBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<TextureBlock>(
                    this.___guid,
                    "textureBlocks",
                    (entity) =>
                    {
                        return new TextureBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureBlocks",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] bindableBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "bindableBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindableBlocks",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] blocksWithFallbacks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "blocksWithFallbacks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blocksWithFallbacks",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] blocksWithDefines
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "blocksWithDefines",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blocksWithDefines",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] repeatableContentBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "repeatableContentBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeatableContentBlocks",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] dynamicUniformBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "dynamicUniformBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamicUniformBlocks",
                    value
                );
            }
        }

        
        public NodeMaterialBlock[] blockingBlocks
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "blockingBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blockingBlocks",
                    value
                );
            }
        }

        
        public InputBlock[] animatedInputs
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<InputBlock>(
                    this.___guid,
                    "animatedInputs",
                    (entity) =>
                    {
                        return new InputBlock() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animatedInputs",
                    value
                );
            }
        }

        
        public decimal buildId
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buildId"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buildId",
                    value
                );
            }
        }

        
        public CachedEntity variableNames
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "variableNames",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "variableNames",
                    value
                );
            }
        }

        
        public CachedEntity defineNames
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "defineNames",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defineNames",
                    value
                );
            }
        }

        
        public bool emitComments
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emitComments"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitComments",
                    value
                );
            }
        }

        
        public bool verbose
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "verbose"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verbose",
                    value
                );
            }
        }

        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        
        public CachedEntity hints
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "hints",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hints",
                    value
                );
            }
        }

        
        public CachedEntity checks
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "checks",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checks",
                    value
                );
            }
        }

        
        public bool allowEmptyVertexProgram
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowEmptyVertexProgram"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowEmptyVertexProgram",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public NodeMaterialBuildStateSharedData() : base() { }

        public NodeMaterialBuildStateSharedData(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public void emitErrors()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "emitErrors" }
                }
            );
        }
        #endregion
    }
}