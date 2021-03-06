﻿using System;
using System.Collections.Generic;
using Digi21.DigiNG.DigiTab;
using Digi21.DigiNG.Entities;

namespace controldecalidad
{
    public class DebeSerPunto : ITrigger
    {
        public Entity AnalyzeEntity(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes, bool addingEntity)
        {
            if( entity is ReadOnlyPoint )
                return entity;

            throw new AggregateException(new GeometryException("Esta geometría debería ser de tipo punto"));
        }
    }
}
