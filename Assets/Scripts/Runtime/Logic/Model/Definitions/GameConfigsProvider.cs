﻿using Zenject;
using UnityEngine;
using Scripts.AssetManagement;
using Cysharp.Threading.Tasks;

namespace Scripts.Model.Definitions
{
    public sealed class GameConfigsProvider
    {
        private ICoreGameConfigs coreGameConfigs;

        [Header("Injected")]
        private readonly IAssetProvider assetProvider;

        [Inject]
        public GameConfigsProvider(IAssetProvider assetProvider)
        {
            this.assetProvider = assetProvider;
        }

        public async UniTask Initialize() =>
            coreGameConfigs = await assetProvider.Load<CoreGameConfigs>("ConfigsInstance");

        public ICoreGameConfigs CoreGameConfigs => coreGameConfigs;
    }
}