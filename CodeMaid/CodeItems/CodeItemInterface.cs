#region CodeMaid is Copyright 2007-2011 Steve Cadwallader.

// CodeMaid is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License version 3
// as published by the Free Software Foundation.
//
// CodeMaid is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details <http://www.gnu.org/licenses/>.

#endregion CodeMaid is Copyright 2007-2011 Steve Cadwallader.

using EnvDTE;
using EnvDTE80;

namespace SteveCadwallader.CodeMaid.CodeItems
{
    /// <summary>
    /// The representation of a code interface.
    /// </summary>
    public class CodeItemInterface : BaseCodeItemElementParent
    {
        /// <summary>
        /// Gets or sets the underlying VSX CodeInterface.
        /// </summary>
        public CodeInterface2 CodeInterface { get; set; }

        /// <summary>
        /// Gets the kind.
        /// </summary>
        public override KindCodeItem Kind
        {
            get { return KindCodeItem.Interface; }
        }

        /// <summary>
        /// Gets the access level.
        /// </summary>
        public override vsCMAccess Access
        {
            get { return CodeInterface != null ? CodeInterface.Access : vsCMAccess.vsCMAccessDefault; }
        }

        /// <summary>
        /// Gets the doc comment.
        /// </summary>
        public override string DocComment
        {
            get { return CodeInterface != null ? CodeInterface.DocComment : null; }
        }

        /// <summary>
        /// Gets the type string.
        /// </summary>
        public override string TypeString
        {
            get { return "interface"; }
        }

        /// <summary>
        /// Gets the namespace.
        /// </summary>
        public override string Namespace
        {
            get { return CodeInterface != null ? CodeInterface.Namespace.Name : null; }
        }
    }
}