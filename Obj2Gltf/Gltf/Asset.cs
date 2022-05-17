﻿using System;
using Newtonsoft.Json;

namespace SilentWave.Obj2Gltf.Gltf
{
    /// <summary>
    /// Metadata about the glTF asset.
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// Tool that generated this glTF model.
        /// </summary>
        [JsonProperty("generator")]
        public String Generator { get; set; }
        /// <summary>
        /// The glTF version of this asset.
        /// </summary>
        [JsonProperty("version")]
        public String Version { get; set; }
    }
}
