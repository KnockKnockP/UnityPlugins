using System.Linq;

namespace UnityPlugins.Extension {
    /// <summary>
    ///     A class that contains <see cref="string" /> extension methods.
    /// </summary>
    public static class StringExtension {
        /// <summary>
        ///     Removes characters that is included in <paramref name="charactersToRemove" /> from <paramref name="original" /> <see cref="string" />.
        /// </summary>
        /// <param name="original">Original <see cref="string" />.</param>
        /// <param name="charactersToRemove">A list of characters to remove from <see cref="original" />.</param>
        /// <returns>
        ///     Returns a new <see cref="string" /> that does not contain any characters from <paramref name="charactersToRemove" />.
        /// </returns>
        public static string RemoveCharacters(this string original, params char[] charactersToRemove) {
            string newString = string.Empty;
            foreach (char _char in original) {
                if (charactersToRemove.Contains(_char) == false) {
                    newString += _char;
                }
            }
            return newString;
        }

        /// <summary>
        ///     Removes characters that is included in <paramref name="charactersToRemove" /> string from <paramref name="original" /> <see cref="string" />.
        /// </summary>
        /// <param name="original">Original <see cref="string" />.</param>
        /// <param name="charactersToRemove">A string that contains characters to remove from <see cref="original" />.</param>
        /// <returns>
        ///     Returns a new <see cref="string" /> that does not contain any characters from <paramref name="charactersToRemove" />.
        /// </returns>
        public static string RemoveCharacters(this string original, string charactersToRemove) {
            string newString = string.Empty;
            foreach (char _char in original) {
                if (charactersToRemove.Contains(_char.ToString()) == false) {
                    newString += _char;
                }
            }
            return newString;
        }

        /// <summary>
        ///     Trims out the <paramref name="trimString" /> at the start of the <paramref name="target" /> <see cref="string" />.
        /// </summary>
        /// <param name="target">An original <see cref="string" /> to trim.</param>
        /// <param name="trimString">A <see cref="string" /> to trim out.</param>
        /// <returns>
        ///     Returns a new <see cref="string" /> that does not contain the <see cref="string" /> value of <paramref name="trimString" /> at the start of the <see cref="string" />.
        /// </returns>
        public static string TrimStart(this string target, string trimString) {
            if (string.IsNullOrEmpty(trimString) == true) {
                return target;
            }

            string result = target;
            while (result.StartsWith(trimString) == true) {
                result = result.Substring(trimString.Length);
            }

            return result;
        }

        /// <summary>
        ///     Trims out the <paramref name="trimString" /> at the end of the <paramref name="target" /> <see cref="string" />.
        /// </summary>
        /// <param name="target">An original <see cref="string" /> to trim.</param>
        /// <param name="trimString">A <see cref="string" /> to trim out.</param>
        /// <returns>
        ///     Returns a new <see cref="string" /> that does not contain the string value of <paramref name="trimString" /> at the end of the <see cref="string" />.
        /// </returns>
        public static string TrimEnd(this string target, string trimString) {
            if (string.IsNullOrEmpty(trimString) == true) {
                return target;
            }

            string result = target;
            while (result.EndsWith(trimString) == true) {
                result = result.Substring(0, (result.Length - trimString.Length));
            }

            return result;
        }
    }
}