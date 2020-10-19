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
    /// <para>A user or group</para>
    /// </summary>
    public class ParticipantLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ParticipantLogInfo> Encoder = new ParticipantLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ParticipantLogInfo> Decoder = new ParticipantLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ParticipantLogInfo" />
        /// class.</para>
        /// </summary>
        public ParticipantLogInfo()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Group</para>
        /// </summary>
        public bool IsGroup
        {
            get
            {
                return this is Group;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Group, or <c>null</c>.</para>
        /// </summary>
        public Group AsGroup
        {
            get
            {
                return this as Group;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is User</para>
        /// </summary>
        public bool IsUser
        {
            get
            {
                return this is User;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a User, or <c>null</c>.</para>
        /// </summary>
        public User AsUser
        {
            get
            {
                return this as User;
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
        /// <para>Encoder for  <see cref="ParticipantLogInfo" />.</para>
        /// </summary>
        private class ParticipantLogInfoEncoder : enc.StructEncoder<ParticipantLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ParticipantLogInfo value, enc.IJsonWriter writer)
            {
                if (value is Group)
                {
                    WriteProperty(".tag", "group", writer, enc.StringEncoder.Instance);
                    Group.Encoder.EncodeFields((Group)value, writer);
                    return;
                }
                if (value is User)
                {
                    WriteProperty(".tag", "user", writer, enc.StringEncoder.Instance);
                    User.Encoder.EncodeFields((User)value, writer);
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
        /// <para>Decoder for  <see cref="ParticipantLogInfo" />.</para>
        /// </summary>
        private class ParticipantLogInfoDecoder : enc.UnionDecoder<ParticipantLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ParticipantLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ParticipantLogInfo Create()
            {
                return new ParticipantLogInfo();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ParticipantLogInfo Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "group":
                        return Group.Decoder.DecodeFields(reader);
                    case "user":
                        return User.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Group details.</para>
        /// </summary>
        public sealed class Group : ParticipantLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Group> Encoder = new GroupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Group> Decoder = new GroupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Group" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Group(GroupLogInfo value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Group" /> class.</para>
            /// </summary>
            private Group()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public GroupLogInfo Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Group" />.</para>
            /// </summary>
            private class GroupEncoder : enc.StructEncoder<Group>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Group value, enc.IJsonWriter writer)
                {
                    WriteProperty("group", value.Value, writer, global::Dropbox.Api.TeamLog.GroupLogInfo.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Group" />.</para>
            /// </summary>
            private class GroupDecoder : enc.StructDecoder<Group>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Group" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Group Create()
                {
                    return new Group();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Group DecodeFields(enc.IJsonReader reader)
                {
                    return new Group(global::Dropbox.Api.TeamLog.GroupLogInfo.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>A user with a Dropbox account.</para>
        /// </summary>
        public sealed class User : ParticipantLogInfo
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<User> Encoder = new UserEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<User> Decoder = new UserDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="User" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public User(UserLogInfo value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="User" /> class.</para>
            /// </summary>
            private User()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public UserLogInfo Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="User" />.</para>
            /// </summary>
            private class UserEncoder : enc.StructEncoder<User>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(User value, enc.IJsonWriter writer)
                {
                    WriteProperty("user", value.Value, writer, global::Dropbox.Api.TeamLog.UserLogInfo.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="User" />.</para>
            /// </summary>
            private class UserDecoder : enc.StructDecoder<User>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="User" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override User Create()
                {
                    return new User();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(User value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "user":
                            value.Value = global::Dropbox.Api.TeamLog.UserLogInfo.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ParticipantLogInfo
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
