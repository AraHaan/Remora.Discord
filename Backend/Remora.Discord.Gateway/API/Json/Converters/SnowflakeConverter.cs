//
//  SnowflakeConverter.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using Newtonsoft.Json;
using Remora.Discord.Core;

namespace Remora.Discord.Gateway.API.Json.Converters
{
    /// <inheritdoc />
    public class SnowflakeConverter : JsonConverter<Snowflake>
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, Snowflake value, JsonSerializer serializer)
        {
            writer.WriteValue(value.Value.ToString());
        }

        /// <inheritdoc />
        public override Snowflake ReadJson
        (
            JsonReader reader,
            Type objectType,
            Snowflake existingValue,
            bool hasExistingValue,
            JsonSerializer serializer
        )
        {
            var rawValue = reader.ReadAsString();
            if (rawValue is null)
            {
                throw new JsonException();
            }

            if (!Snowflake.TryParse(rawValue, out var snowflake))
            {
                throw new JsonException();
            }

            return snowflake.Value;
        }
    }
}
