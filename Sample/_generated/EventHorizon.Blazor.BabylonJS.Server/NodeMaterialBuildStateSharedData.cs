/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
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
        
        public async ValueTask<string[]> get_temps()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "temps"
                );
        }
        public ValueTask set_temps(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "temps",
                    value
                );
        }

        
        public async ValueTask<string[]> get_varyings()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "varyings"
                );
        }
        public ValueTask set_varyings(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "varyings",
                    value
                );
        }

        
        public async ValueTask<string> get_varyingDeclaration()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "varyingDeclaration"
                );
        }
        public ValueTask set_varyingDeclaration(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "varyingDeclaration",
                    value
                );
        }

        
        public async ValueTask<InputBlock[]> get_inputBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<InputBlock>(
                    this.___guid,
                    "inputBlocks",
                    (entity) =>
                    {
                        return new InputBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_inputBlocks(InputBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputBlocks",
                    value
                );
        }

        
        public async ValueTask<TextureBlock[]> get_textureBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<TextureBlock>(
                    this.___guid,
                    "textureBlocks",
                    (entity) =>
                    {
                        return new TextureBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_textureBlocks(TextureBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "textureBlocks",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_bindableBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "bindableBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_bindableBlocks(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "bindableBlocks",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_blocksWithFallbacks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "blocksWithFallbacks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_blocksWithFallbacks(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blocksWithFallbacks",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_blocksWithDefines()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "blocksWithDefines",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_blocksWithDefines(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blocksWithDefines",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_repeatableContentBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "repeatableContentBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_repeatableContentBlocks(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "repeatableContentBlocks",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_dynamicUniformBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "dynamicUniformBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_dynamicUniformBlocks(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dynamicUniformBlocks",
                    value
                );
        }

        
        public async ValueTask<NodeMaterialBlock[]> get_blockingBlocks()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<NodeMaterialBlock>(
                    this.___guid,
                    "blockingBlocks",
                    (entity) =>
                    {
                        return new NodeMaterialBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_blockingBlocks(NodeMaterialBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blockingBlocks",
                    value
                );
        }

        
        public async ValueTask<InputBlock[]> get_animatedInputs()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<InputBlock>(
                    this.___guid,
                    "animatedInputs",
                    (entity) =>
                    {
                        return new InputBlock() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animatedInputs(InputBlock[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animatedInputs",
                    value
                );
        }

        
        public async ValueTask<decimal> get_buildId()
        {
            return await EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "buildId"
                );
        }
        public ValueTask set_buildId(decimal value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "buildId",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_variableNames()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "variableNames",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_variableNames(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "variableNames",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_defineNames()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "defineNames",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_defineNames(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defineNames",
                    value
                );
        }

        
        public async ValueTask<bool> get_emitComments()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emitComments"
                );
        }
        public ValueTask set_emitComments(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "emitComments",
                    value
                );
        }

        
        public async ValueTask<bool> get_verbose()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "verbose"
                );
        }
        public ValueTask set_verbose(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "verbose",
                    value
                );
        }

        private Scene __scene;
        public async ValueTask<Scene> get_scene()
        {
            if(__scene == null)
            {
                __scene = await EventHorizonBlazorInterop.GetClass<Scene>(
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
        public ValueTask set_scene(Scene value)
        {
__scene = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_hints()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "hints",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_hints(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "hints",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_checks()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "checks",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_checks(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "checks",
                    value
                );
        }

        
        public async ValueTask<bool> get_allowEmptyVertexProgram()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "allowEmptyVertexProgram"
                );
        }
        public ValueTask set_allowEmptyVertexProgram(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "allowEmptyVertexProgram",
                    value
                );
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
        public async ValueTask emitErrors()
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "emitErrors" }
                }
            );
        }
        #endregion
    }
}