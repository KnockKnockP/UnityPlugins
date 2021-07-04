using System;

namespace EnumLinker {
    /// <summary>
    /// This attribute is needed for linking an enum value to a class.<br />
    /// This can only be used to classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class EnumLinkerAttribute : Attribute {
        internal Type EnumType {
            get;
        }

        internal Enum EnumValue {
            get;
        }

        /// <summary>
        /// This constructor will be used to store data needed for linking.
        /// </summary>
        /// <param name="enumType">The target enum type.</param>
        /// <param name="enumValue">The value of an enum type in string.</param>
        /// <exception cref="ArgumentException">When the non-enum type or <paramref name="enumValue"/> is not found on the specified enum type, it will throw an exception.</exception>
        public EnumLinkerAttribute(Type enumType, string enumValue) {
            if (enumType.IsEnum == false) {
                throw new ArgumentException($"{nameof(enumType)} must be an enum.");
            }

            if (Enum.IsDefined(enumType, enumValue) == false) {
                throw new ArgumentException($"{enumValue} does not exist in the specified enum");
            }

            EnumType = enumType;
            EnumValue = (Enum)(Enum.Parse(enumType,
                                          enumValue));
            return;
        }
    }
}