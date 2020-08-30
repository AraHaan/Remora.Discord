//
//  JsonArrayMatcherBuilder.cs
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
using System.Collections.Generic;
using System.Text.Json;

namespace Remora.Discord.Rest.Tests.Json
{
    /// <summary>
    /// Builds instances of the <see cref="JsonArrayMatcher"/> class.
    /// </summary>
    public class JsonArrayMatcherBuilder
    {
        private readonly List<Func<JsonElement.ArrayEnumerator, bool>> _matchers
            = new List<Func<JsonElement.ArrayEnumerator, bool>>();

        /// <summary>
        /// Builds the array matcher.
        /// </summary>
        /// <returns>The built array matcher.</returns>
        public JsonArrayMatcher Build()
        {
            return new JsonArrayMatcher(_matchers);
        }
    }
}
