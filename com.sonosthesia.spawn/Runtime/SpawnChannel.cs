using Sonosthesia.Flow;
using Sonosthesia.Utils;
using UnityEngine;

namespace Sonosthesia.Spawn
{
    public readonly struct SpawnPayload
    {
        public readonly Trans Trans;
        public readonly float Size;
        public readonly float Lifetime;
        public readonly Color Color;
        public readonly Vector3 Velocity;
        public readonly Vector3 AngularVelocity;

        public SpawnPayload(Trans trans, float size, float lifetime, Color color, Vector3 velocity, Vector3 angularVelocity)
        {
            Trans = trans;
            Size = size;
            Lifetime = lifetime;
            Color = color;
            Velocity = velocity;
            AngularVelocity = angularVelocity;
        }

        public override string ToString()
        {
            return $"{nameof(SpawnPayload)} {nameof(Trans)} {Trans} {nameof(Size)} {Size} {nameof(Color)} {Color}";
        }
    }
    
    public class SpawnChannel : DynamicChannel<SpawnPayload>
    {
        
    }
}