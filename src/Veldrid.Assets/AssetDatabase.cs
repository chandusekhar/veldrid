﻿using System.IO;

namespace Veldrid.Assets
{
    public interface AssetDatabase
    {
        T LoadAsset<T>(AssetID assetID);
        T LoadAsset<T>(AssetRef<T> assetRef);
        Stream OpenAssetStream(AssetID assetID);

        void SaveDefinition<T>(T obj, string name);
    }
}
