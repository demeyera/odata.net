//   Copyright 2011 Microsoft Corporation
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

namespace Microsoft.Data.OData.Query.SemanticAst
{
    /// <summary>
    /// Class to represent the selection of a specific path.
    /// </summary>
    public sealed class PathSelectItem : SelectItem
    {
        /// <summary>
        /// The selected path.
        /// </summary>
        private readonly ODataSelectPath selectedPath;

        /// <summary>
        /// Constructs a <see cref="SelectItem"/> to indicate that a specific path is selected.
        /// </summary>
        /// <param name="selectedPath">The selected path.</param>
        /// <exception cref="System.ArgumentNullException">Throws if the input selectedPath is null.</exception>
        public PathSelectItem(ODataSelectPath selectedPath)
        {
            ExceptionUtils.CheckArgumentNotNull(selectedPath, "selectedPath");
            this.selectedPath = selectedPath;
        }

        /// <summary>
        /// Gets the selected path.
        /// </summary>
        public ODataSelectPath SelectedPath
        {
            get { return this.selectedPath; }
        }
    }
}