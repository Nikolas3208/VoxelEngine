using OpenTK.Mathematics;
using System;

namespace VoxelEngine.World.Block
{
    public class Box
    {
        public static int BlockID { get; set; }

        public static int BlockType { get; set; }

        public static Vector3 BlockSize { get; set; }

        public static Vector3 BlockPos { get; set; }

        public Box(Vector3 blockSize, int blockType, int blockId)
        {
            BlockType = blockType;
            BlockID = blockId;
            BlockSize = blockSize;
        }
    }
}
