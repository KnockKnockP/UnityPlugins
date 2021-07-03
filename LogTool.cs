using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityPlugins {
    /// <summary>
    ///     A class that contains Unity logging tools.
    /// </summary>
    public static class LogTool {
        /// <summary>
        ///     Logs all <typeparamref name="T" /> enum values.
        /// </summary>
        /// <typeparam name="T">An enum type.</typeparam>
        public static void LogEnums<T>() => LogEnums(typeof(T));

        /// <summary>
        ///     Logs all <paramref name="enumType" /> enum values.
        /// </summary>
        /// <param name="enumType">An enum type.</param>
        public static void LogEnums(Type enumType) {
            foreach (string enumName in Enum.GetNames(enumType)) {
                Debug.Log(enumName);
            }
            return;
        }

        /// <summary>
        ///     Logs an exception alongside <paramref name="message" />.
        /// </summary>
        /// <param name="exception">An <see cref="Exception" /> to log.</param>
        /// <param name="message">An extra message.</param>
        /// <param name="debugLogMethod">
        ///     A method used for logging a message.
        ///     <example>
        ///         <see cref="Debug.Log(object)" /> <br />
        ///         <see cref="Debug.LogWarning(object)" /> <br />
        ///         <see cref="Debug.LogError(object)" /> <br />
        ///     </example>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void PrintException(Exception exception,
                                          string message,
                                          Action<object> debugLogMethod) {
            string printMessage = string.Empty;
            if (string.IsNullOrEmpty(message) == false) {
                printMessage = $"{message}\r\n";
            }
            printMessage += ($"{exception.Message}\r\n" + StackTraceUtility.ExtractStringFromException(exception));
            debugLogMethod(printMessage);
            return;
        }
    }
}