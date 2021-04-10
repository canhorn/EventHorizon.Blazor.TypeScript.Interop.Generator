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

    
    
    [JsonConverter(typeof(CachedEntityConverter<NodeMaterialBuildState>))]
    public class NodeMaterialBuildState : CachedEntityObject
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
        
        public async ValueTask<bool> get_supportUniformBuffers()
        {
            return await EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "supportUniformBuffers"
                );
        }
        public ValueTask set_supportUniformBuffers(bool value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "supportUniformBuffers",
                    value
                );
        }

        
        public async ValueTask<string[]> get_attributes()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "attributes"
                );
        }
        public ValueTask set_attributes(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attributes",
                    value
                );
        }

        
        public async ValueTask<string[]> get_uniforms()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "uniforms"
                );
        }
        public ValueTask set_uniforms(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "uniforms",
                    value
                );
        }

        
        public async ValueTask<string[]> get_constants()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "constants"
                );
        }
        public ValueTask set_constants(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "constants",
                    value
                );
        }

        
        public async ValueTask<string[]> get_samplers()
        {
            return await EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "samplers"
                );
        }
        public ValueTask set_samplers(string[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "samplers",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_functions()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "functions",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_functions(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "functions",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_extensions()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "extensions",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_extensions(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "extensions",
                    value
                );
        }

        
        public async ValueTask<int> get_target()
        {
            return await EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "target"
                );
        }
        public ValueTask set_target(int value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "target",
                    value
                );
        }

        
        public async ValueTask<CachedEntity> get_counters()
        {
            return await EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "counters",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_counters(CachedEntity value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "counters",
                    value
                );
        }

        private NodeMaterialBuildStateSharedData __sharedData;
        public async ValueTask<NodeMaterialBuildStateSharedData> get_sharedData()
        {
            if(__sharedData == null)
            {
                __sharedData = await EventHorizonBlazorInterop.GetClass<NodeMaterialBuildStateSharedData>(
                    this.___guid,
                    "sharedData",
                    (entity) =>
                    {
                        return new NodeMaterialBuildStateSharedData() { ___guid = entity.___guid };
                    }
                );
            }
            return __sharedData;
        }
        public ValueTask set_sharedData(NodeMaterialBuildStateSharedData value)
        {
__sharedData = null;
                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sharedData",
                    value
                );
        }

        
        public async ValueTask<string> get_compilationString()
        {
            return await EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "compilationString"
                );
        }
        public ValueTask set_compilationString(string value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "compilationString",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public NodeMaterialBuildState() : base() { } 

        public NodeMaterialBuildState(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods
        public async ValueTask finalize(NodeMaterialBuildState state)
        {
            await EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "finalize" }, state
                }
            );
        }
        #endregion
    }
}