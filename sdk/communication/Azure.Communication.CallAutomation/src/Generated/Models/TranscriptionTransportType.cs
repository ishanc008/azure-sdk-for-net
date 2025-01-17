// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The type of transport to be used for live transcription, eg. Websocket. </summary>
    public readonly partial struct TranscriptionTransportType : IEquatable<TranscriptionTransportType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TranscriptionTransportType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TranscriptionTransportType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebsocketValue = "websocket";

        /// <summary> websocket. </summary>
        public static TranscriptionTransportType Websocket { get; } = new TranscriptionTransportType(WebsocketValue);
        /// <summary> Determines if two <see cref="TranscriptionTransportType"/> values are the same. </summary>
        public static bool operator ==(TranscriptionTransportType left, TranscriptionTransportType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TranscriptionTransportType"/> values are not the same. </summary>
        public static bool operator !=(TranscriptionTransportType left, TranscriptionTransportType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TranscriptionTransportType"/>. </summary>
        public static implicit operator TranscriptionTransportType(string value) => new TranscriptionTransportType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TranscriptionTransportType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TranscriptionTransportType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
