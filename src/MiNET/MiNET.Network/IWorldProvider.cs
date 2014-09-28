﻿using Craft.Net.Common;

namespace MiNET.Network
{
	public interface IWorldProvider
	{
		bool IsCaching { get; }
		void Initialize();
		ChunkColumn GenerateChunkColumn(Coordinates2D chunkCoordinates);
	}
}
