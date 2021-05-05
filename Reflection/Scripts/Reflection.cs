using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityPlugins {
    public struct Reflection {
        public static IEnumerable<Type> FindAllClassesImplementing<T>() {
            return AppDomain.CurrentDomain.GetAssemblies()
                                          .SelectMany(s => s.GetTypes())
                                          .Where(p => (p != typeof(T)) && (typeof(T).IsAssignableFrom(p)));
        }
    }
}