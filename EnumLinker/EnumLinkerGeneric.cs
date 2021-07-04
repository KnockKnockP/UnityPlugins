using System;
using System.Collections.Generic;
using System.Reflection;

namespace EnumLinker {
    /// <summary>
    /// This static class will find and link all the enum values to a class that implements <typeparamref name="TInterface"/>.
    /// </summary>
    /// <typeparam name="TEnum"><typeparamref name="TEnum"/> must be a type of an enum.</typeparam>
    /// <typeparam name="TInterface"><typeparamref name="TInterface"/> must be an interface type.<br />
    /// It is used to return a class associated to an enum value.</typeparam>
    public static class EnumLinker<TEnum, TInterface>
        where TEnum : Enum
        where TInterface : class {
        private static readonly Dictionary<Enum, TInterface> enumToClass = new Dictionary<Enum, TInterface>();
        
        static EnumLinker() {
            if (EnumLinker.updateLinkMethods.Contains(UpdateLink) == false) {
                EnumLinker.updateLinkMethods.Add(UpdateLink);
            }

            if (enumToClass.Count == 0) {
                UpdateLink();
            }
            return;
        }

        /// <summary>
        /// Updates a link.
        /// </summary>
        public static void UpdateLink() {
            enumToClass.Clear();

            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (Type type in assembly.GetTypes()) {
                    object[] attributes = type.GetCustomAttributes(typeof(EnumLinkerAttribute), true);
                    if (attributes.Length == 0) {
                        continue;
                    }

                    foreach (object attribute in attributes) {
                        EnumLinkerAttribute enumLinkerAttribute = (EnumLinkerAttribute)(attribute);
                        if (enumLinkerAttribute.EnumType != typeof(TEnum)) {
                            continue;
                        }

                        enumToClass.Add(enumLinkerAttribute.EnumValue, (TInterface)(Activator.CreateInstance(type)));
                    }
                }
            }
            return;
        }

        /// <summary>
        /// When there are no linked types, it will automatically try to link enums. <br />
        /// See <see cref="UpdateLink"/>.
        /// </summary>
        /// <param name="enumValue">An enum value to search for.</param>
        /// <returns>A class linked to <paramref name="enumValue"/>.</returns>
        public static TInterface GetInterface(Enum enumValue) {
            if (enumToClass.Count == 0) {
                UpdateLink();
            }

            return enumToClass[enumValue];
        }
    }
}