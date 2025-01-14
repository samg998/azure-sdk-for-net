// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// An abstract representation of a response format configuration usable by Chat Completions. Can be used to enable JSON
    /// mode.
    /// Please note <see cref="ChatCompletionsResponseFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes..
    /// </summary>
    public abstract partial class ChatCompletionsResponseFormat
    {
        /// <summary> Initializes a new instance of <see cref="ChatCompletionsResponseFormat"/>. </summary>
        protected ChatCompletionsResponseFormat()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsResponseFormat"/>. </summary>
        /// <param name="type"> The discriminated type for the response format. </param>
        internal ChatCompletionsResponseFormat(string type)
        {
            Type = type;
        }

        /// <summary> The discriminated type for the response format. </summary>
        internal string Type { get; set; }
    }
}
