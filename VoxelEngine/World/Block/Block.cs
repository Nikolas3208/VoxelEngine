using OpenTK.Mathematics;
using System;

namespace VoxelEngine.World.Block
{
    public class Block : Box
    {
        public Block(Vector3 blockSize, int blockType, int blockId) : base(blockSize, blockType, blockId)
        {

        }
    }
}
