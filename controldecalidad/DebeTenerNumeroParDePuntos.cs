using System;
using System.Collections.Generic;
using Digi21.DigiNG.DigiTab;
using Digi21.DigiNG.Entities;

namespace controldecalidad
{
    public class DebeTenerNumeroParDePuntos : ITrigger
    {
        public Entity AnalyzeEntity(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes, bool addingEntity)
        {
            if (!(entity is ReadOnlyLine))
                return entity;

            var linea = entity as ReadOnlyLine;

            if (linea.Points.Count % 2 != 0)
                throw new AggregateException(new GeometryException("Solo se admiten líneas con un número par de puntos"));

            return entity;
        }
    }
}
