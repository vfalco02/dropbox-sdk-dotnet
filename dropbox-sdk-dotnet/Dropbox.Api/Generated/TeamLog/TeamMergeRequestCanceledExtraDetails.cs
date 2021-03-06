// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Team merge request cancellation details</para>
    /// </summary>
    public class TeamMergeRequestCanceledExtraDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMergeRequestCanceledExtraDetails> Encoder = new TeamMergeRequestCanceledExtraDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMergeRequestCanceledExtraDetails> Decoder = new TeamMergeRequestCanceledExtraDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="TeamMergeRequestCanceledExtraDetails" /> class.</para>
        /// </summary>
        public TeamMergeRequestCanceledExtraDetails()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PrimaryTeam</para>
        /// </summary>
        public bool IsPrimaryTeam
        {
            get
            {
                return this is PrimaryTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PrimaryTeam, or <c>null</c>.</para>
        /// </summary>
        public PrimaryTeam AsPrimaryTeam
        {
            get
            {
                return this as PrimaryTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is SecondaryTeam</para>
        /// </summary>
        public bool IsSecondaryTeam
        {
            get
            {
                return this is SecondaryTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SecondaryTeam, or <c>null</c>.</para>
        /// </summary>
        public SecondaryTeam AsSecondaryTeam
        {
            get
            {
                return this as SecondaryTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMergeRequestCanceledExtraDetails" />.</para>
        /// </summary>
        private class TeamMergeRequestCanceledExtraDetailsEncoder : enc.StructEncoder<TeamMergeRequestCanceledExtraDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMergeRequestCanceledExtraDetails value, enc.IJsonWriter writer)
            {
                if (value is PrimaryTeam)
                {
                    WriteProperty(".tag", "primary_team", writer, enc.StringEncoder.Instance);
                    PrimaryTeam.Encoder.EncodeFields((PrimaryTeam)value, writer);
                    return;
                }
                if (value is SecondaryTeam)
                {
                    WriteProperty(".tag", "secondary_team", writer, enc.StringEncoder.Instance);
                    SecondaryTeam.Encoder.EncodeFields((SecondaryTeam)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMergeRequestCanceledExtraDetails" />.</para>
        /// </summary>
        private class TeamMergeRequestCanceledExtraDetailsDecoder : enc.UnionDecoder<TeamMergeRequestCanceledExtraDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="TeamMergeRequestCanceledExtraDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMergeRequestCanceledExtraDetails Create()
            {
                return new TeamMergeRequestCanceledExtraDetails();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TeamMergeRequestCanceledExtraDetails Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "primary_team":
                        return PrimaryTeam.Decoder.DecodeFields(reader);
                    case "secondary_team":
                        return SecondaryTeam.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Team merge request cancellation details shown to the primary team.</para>
        /// </summary>
        public sealed class PrimaryTeam : TeamMergeRequestCanceledExtraDetails
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PrimaryTeam> Encoder = new PrimaryTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PrimaryTeam> Decoder = new PrimaryTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PrimaryTeam" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public PrimaryTeam(PrimaryTeamRequestCanceledDetails value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PrimaryTeam" />
            /// class.</para>
            /// </summary>
            private PrimaryTeam()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public PrimaryTeamRequestCanceledDetails Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PrimaryTeam" />.</para>
            /// </summary>
            private class PrimaryTeamEncoder : enc.StructEncoder<PrimaryTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PrimaryTeam value, enc.IJsonWriter writer)
                {
                    WriteProperty("primary_team", value.Value, writer, global::Dropbox.Api.TeamLog.PrimaryTeamRequestCanceledDetails.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PrimaryTeam" />.</para>
            /// </summary>
            private class PrimaryTeamDecoder : enc.StructDecoder<PrimaryTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PrimaryTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PrimaryTeam Create()
                {
                    return new PrimaryTeam();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override PrimaryTeam DecodeFields(enc.IJsonReader reader)
                {
                    return new PrimaryTeam(global::Dropbox.Api.TeamLog.PrimaryTeamRequestCanceledDetails.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Team merge request cancellation details shown to the secondary team.</para>
        /// </summary>
        public sealed class SecondaryTeam : TeamMergeRequestCanceledExtraDetails
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<SecondaryTeam> Encoder = new SecondaryTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<SecondaryTeam> Decoder = new SecondaryTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SecondaryTeam" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public SecondaryTeam(SecondaryTeamRequestCanceledDetails value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SecondaryTeam" />
            /// class.</para>
            /// </summary>
            private SecondaryTeam()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SecondaryTeamRequestCanceledDetails Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="SecondaryTeam" />.</para>
            /// </summary>
            private class SecondaryTeamEncoder : enc.StructEncoder<SecondaryTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(SecondaryTeam value, enc.IJsonWriter writer)
                {
                    WriteProperty("secondary_team", value.Value, writer, global::Dropbox.Api.TeamLog.SecondaryTeamRequestCanceledDetails.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="SecondaryTeam" />.</para>
            /// </summary>
            private class SecondaryTeamDecoder : enc.StructDecoder<SecondaryTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="SecondaryTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override SecondaryTeam Create()
                {
                    return new SecondaryTeam();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override SecondaryTeam DecodeFields(enc.IJsonReader reader)
                {
                    return new SecondaryTeam(global::Dropbox.Api.TeamLog.SecondaryTeamRequestCanceledDetails.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TeamMergeRequestCanceledExtraDetails
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
