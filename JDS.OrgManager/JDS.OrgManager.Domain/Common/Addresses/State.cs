// Copyright �2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using JDS.OrgManager.Domain.Models;
using System;
using System.Collections.Generic;

namespace JDS.OrgManager.Domain.Common.Addresses
{
    public class State : ValueObject
    {
        #region Public Properties + Indexers

        public string Abbreviation { get; }

        public string Name { get; }

        #endregion

        #region Public Constructors

        public State(string abbreviation, string name = null)
        {
            Abbreviation = abbreviation ?? throw new ArgumentNullException(nameof(abbreviation));
            Name = name ?? "";
        }

        #endregion

        #region Public Methods

        public static explicit operator State(string value) => new State(value);

        public static implicit operator string(State state) => state.Abbreviation;

        public override string ToString() => Abbreviation;

        #endregion

        #region Protected Methods

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Abbreviation;
        }

        #endregion
    }
}