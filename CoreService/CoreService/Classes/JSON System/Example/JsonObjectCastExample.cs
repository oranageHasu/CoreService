using Newtonsoft.Json.Linq;
using System;

namespace CoreService.Classes.JSON_System.Example
{
    public class TopLevelEntity
    {
        protected int TopLevelEntityId { get; set; } = -1;
    }

    public class EntityA : TopLevelEntity
    {
        protected int EntityAId { get; set; } = -1;
    }

    public class EntityB : TopLevelEntity
    {
        protected int EntityBId { get; set; } = -1;
    }

    public class JsonObjectCastExample : JsonCreation<TopLevelEntity>
    {
        protected override TopLevelEntity Create(Type objectType, JObject jObject)
        {
            if (jObject == null) throw new ArgumentNullException("jObject");

            if (jObject["EntityAId"] != null)
            {
                return new EntityA();
            }
            else if (jObject["EntityBId"] != null)
            {
                return new EntityB();
            }
            else
            {
                return new TopLevelEntity();
            }
        }
    }
}
