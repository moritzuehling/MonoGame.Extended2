﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace MonoGame.Extended.VideoPlayback.Extensions {
    /// <summary>
    /// This static class contains extension methods for <see cref="SortedList{TKey,TValue}"/> to provide a queue-like API (enqueue, dequeue).
    /// </summary>
    internal static class SortedListExtensions {

        /// <summary>
        /// Enqueue a value to the <see cref="SortedList{TKey,TValue}"/> according to its key.
        /// </summary>
        /// <typeparam name="TKey">Type of the keys in this <see cref="SortedList{TKey,TValue}"/>.</typeparam>
        /// <typeparam name="TValue">Type of the values in this <see cref="SortedList{TKey,TValue}"/>.</typeparam>
        /// <param name="list">The <see cref="SortedList{TKey,TValue}"/> to enqueue.</param>
        /// <param name="key">The key of the value to be enqueued.</param>
        /// <param name="value">The value to be enqueued.</param>
        internal static void Enqueue<TKey, TValue>([NotNull] this SortedList<TKey, TValue> list, TKey key, TValue value) {
            list.Add(key, value);
        }

        /// <summary>
        /// Dequeues a value from the <see cref="SortedList{TKey,TValue}"/> and returns the value.
        /// </summary>
        /// <typeparam name="TKey">Type of the keys in this <see cref="SortedList{TKey,TValue}"/>.</typeparam>
        /// <typeparam name="TValue">Type of the values in this <see cref="SortedList{TKey,TValue}"/>.</typeparam>
        /// <param name="list">The <see cref="SortedList{TKey,TValue}"/> to dequeue.</param>
        /// <returns>Dequeued value.</returns>
        internal static TValue Dequeue<TKey, TValue>([NotNull] this SortedList<TKey, TValue> list) {
            var value = list.Values[0];

            list.RemoveAt(0);

            return value;
        }

        /// <summary>
        /// Peeks the key of the first value in the <see cref="SortedList{TKey,TValue}"/>.
        /// </summary>
        /// <typeparam name="TKey">Type of the keys in this <see cref="SortedList{TKey,TValue}"/>/</typeparam>
        /// <typeparam name="TValue">Type of the values in this <see cref="SortedList{TKey,TValue}"/>.</typeparam>
        /// <param name="list">The <see cref="SortedList{TKey,TValue}"/> to peek.</param>
        /// <returns>The key of the first value in this <see cref="SortedList{TKey,TValue}"/>.</returns>
        internal static TKey PeekFirstKey<TKey, TValue>([NotNull] this SortedList<TKey, TValue> list) {
            return list.Keys[0];
        }

    }
}
