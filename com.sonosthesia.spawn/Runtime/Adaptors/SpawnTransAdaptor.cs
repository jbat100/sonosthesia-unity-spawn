using Sonosthesia.Flow;
using Sonosthesia.Utils;

namespace Sonosthesia.Spawn
{
    public class SpawnTransAdaptor : SimpleAdaptor<SpawnPayload, Trans>
    {
        protected override Trans Map(SpawnPayload source) => source.Trans;
    }
}