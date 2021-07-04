using System;
using System.Collections.Generic;

namespace EnumLinker {
    public static class EnumLinker {
        internal static readonly IList<Action> updateLinkMethods = new List<Action>();

        public static void UpdateAllLinks() {
            foreach (Action updateLinkMethod in updateLinkMethods) {
                updateLinkMethod();
            }
            return;
        }
    }
}