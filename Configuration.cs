﻿using Dalamud.Configuration;
using Dalamud.Plugin;
using Newtonsoft.Json;

namespace Cammy
{
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; }

        public bool AutoLoadCameraPreset = false;
        public CameraEditor.CameraPreset CameraPreset = new();

        [JsonIgnore] private DalamudPluginInterface pluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.pluginInterface.SavePluginConfig(this);
        }
    }
}
