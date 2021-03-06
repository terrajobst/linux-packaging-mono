// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Data.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Data.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Data.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Data.DataSetExtensions, PublicKey=00000000000000000400000000000000")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Design, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Web, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Microsoft.SqlServer.Server
{
    [System.SerializableAttribute]
    public enum DataAccessKind
    {
        None = 0,
        Read = 1,
    }
    public enum Format
    {
        Native = 1,
        Unknown = 0,
        UserDefined = 2,
    }
    public partial interface IBinarySerialize
    {
        void Read(System.IO.BinaryReader r);
        void Write(System.IO.BinaryWriter w);
    }
    [System.SerializableAttribute]
    public sealed partial class InvalidUdtException : System.SystemException
    {
        internal InvalidUdtException() { }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class SqlContext
    {
        internal SqlContext() { }
        public static bool IsAvailable { get { throw null; } }
        public static Microsoft.SqlServer.Server.SqlPipe Pipe { get { throw null; } }
        public static Microsoft.SqlServer.Server.SqlTriggerContext TriggerContext { get { throw null; } }
        public static System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
    }
    public partial class SqlDataRecord : System.Data.IDataRecord
    {
        public SqlDataRecord(params Microsoft.SqlServer.Server.SqlMetaData[] metaData) { }
        public virtual int FieldCount { get { throw null; } }
        public virtual object this[int ordinal] { get { throw null; } }
        public virtual object this[string name] { get { throw null; } }
        public virtual bool GetBoolean(int ordinal) { throw null; }
        public virtual byte GetByte(int ordinal) { throw null; }
        public virtual long GetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length) { throw null; }
        public virtual char GetChar(int ordinal) { throw null; }
        public virtual long GetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length) { throw null; }
        public virtual string GetDataTypeName(int ordinal) { throw null; }
        public virtual System.DateTime GetDateTime(int ordinal) { throw null; }
        public virtual System.DateTimeOffset GetDateTimeOffset(int ordinal) { throw null; }
        public virtual decimal GetDecimal(int ordinal) { throw null; }
        public virtual double GetDouble(int ordinal) { throw null; }
        public virtual System.Type GetFieldType(int ordinal) { throw null; }
        public virtual float GetFloat(int ordinal) { throw null; }
        public virtual System.Guid GetGuid(int ordinal) { throw null; }
        public virtual short GetInt16(int ordinal) { throw null; }
        public virtual int GetInt32(int ordinal) { throw null; }
        public virtual long GetInt64(int ordinal) { throw null; }
        public virtual string GetName(int ordinal) { throw null; }
        public virtual int GetOrdinal(string name) { throw null; }
        public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int ordinal) { throw null; }
        public virtual System.Type GetSqlFieldType(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int ordinal) { throw null; }
        public virtual Microsoft.SqlServer.Server.SqlMetaData GetSqlMetaData(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int ordinal) { throw null; }
        public virtual System.Data.SqlTypes.SqlString GetSqlString(int ordinal) { throw null; }
        public virtual object GetSqlValue(int ordinal) { throw null; }
        public virtual int GetSqlValues(object[] values) { throw null; }
        public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int ordinal) { throw null; }
        public virtual string GetString(int ordinal) { throw null; }
        public virtual System.TimeSpan GetTimeSpan(int ordinal) { throw null; }
        public virtual object GetValue(int ordinal) { throw null; }
        public virtual int GetValues(object[] values) { throw null; }
        public virtual bool IsDBNull(int ordinal) { throw null; }
        public virtual void SetBoolean(int ordinal, bool value) { }
        public virtual void SetByte(int ordinal, byte value) { }
        public virtual void SetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length) { }
        public virtual void SetChar(int ordinal, char value) { }
        public virtual void SetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length) { }
        public virtual void SetDateTime(int ordinal, System.DateTime value) { }
        public virtual void SetDateTimeOffset(int ordinal, System.DateTimeOffset value) { }
        public virtual void SetDBNull(int ordinal) { }
        public virtual void SetDecimal(int ordinal, decimal value) { }
        public virtual void SetDouble(int ordinal, double value) { }
        public virtual void SetFloat(int ordinal, float value) { }
        public virtual void SetGuid(int ordinal, System.Guid value) { }
        public virtual void SetInt16(int ordinal, short value) { }
        public virtual void SetInt32(int ordinal, int value) { }
        public virtual void SetInt64(int ordinal, long value) { }
        public virtual void SetSqlBinary(int ordinal, System.Data.SqlTypes.SqlBinary value) { }
        public virtual void SetSqlBoolean(int ordinal, System.Data.SqlTypes.SqlBoolean value) { }
        public virtual void SetSqlByte(int ordinal, System.Data.SqlTypes.SqlByte value) { }
        public virtual void SetSqlBytes(int ordinal, System.Data.SqlTypes.SqlBytes value) { }
        public virtual void SetSqlChars(int ordinal, System.Data.SqlTypes.SqlChars value) { }
        public virtual void SetSqlDateTime(int ordinal, System.Data.SqlTypes.SqlDateTime value) { }
        public virtual void SetSqlDecimal(int ordinal, System.Data.SqlTypes.SqlDecimal value) { }
        public virtual void SetSqlDouble(int ordinal, System.Data.SqlTypes.SqlDouble value) { }
        public virtual void SetSqlGuid(int ordinal, System.Data.SqlTypes.SqlGuid value) { }
        public virtual void SetSqlInt16(int ordinal, System.Data.SqlTypes.SqlInt16 value) { }
        public virtual void SetSqlInt32(int ordinal, System.Data.SqlTypes.SqlInt32 value) { }
        public virtual void SetSqlInt64(int ordinal, System.Data.SqlTypes.SqlInt64 value) { }
        public virtual void SetSqlMoney(int ordinal, System.Data.SqlTypes.SqlMoney value) { }
        public virtual void SetSqlSingle(int ordinal, System.Data.SqlTypes.SqlSingle value) { }
        public virtual void SetSqlString(int ordinal, System.Data.SqlTypes.SqlString value) { }
        public virtual void SetSqlXml(int ordinal, System.Data.SqlTypes.SqlXml value) { }
        public virtual void SetString(int ordinal, string value) { }
        public virtual void SetTimeSpan(int ordinal, System.TimeSpan value) { }
        public virtual void SetValue(int ordinal, object value) { }
        public virtual int SetValues(params object[] values) { throw null; }
        System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false, Inherited=false)]
    public partial class SqlFacetAttribute : System.Attribute
    {
        public SqlFacetAttribute() { }
        public bool IsFixedLength { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
        public int MaxSize { get { throw null; } set { } }
        public int Precision { get { throw null; } set { } }
        public int Scale { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    [System.SerializableAttribute]
    public partial class SqlFunctionAttribute : System.Attribute
    {
        public SqlFunctionAttribute() { }
        public Microsoft.SqlServer.Server.DataAccessKind DataAccess { get { throw null; } set { } }
        public string FillRowMethodName { get { throw null; } set { } }
        public bool IsDeterministic { get { throw null; } set { } }
        public bool IsPrecise { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Microsoft.SqlServer.Server.SystemDataAccessKind SystemDataAccess { get { throw null; } set { } }
        public string TableDefinition { get { throw null; } set { } }
    }
    public sealed partial class SqlMetaData
    {
        public SqlMetaData(string name, System.Data.SqlDbType dbType) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.Type userDefinedType) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long localeId, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.Type userDefinedType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        [System.MonoTODOAttribute]
        public SqlMetaData(string name, System.Data.SqlDbType dbType, System.Type userDefinedType) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, System.Type userDefinedType, string serverTypeName) { }
        public SqlMetaData(string name, System.Data.SqlDbType dbType, System.Type userDefinedType, string serverTypeName, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
        public System.Data.SqlTypes.SqlCompareOptions CompareOptions { get { throw null; } }
        public System.Data.DbType DbType { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsUniqueKey { get { throw null; } }
        public long LocaleId { get { throw null; } }
        public static long Max { get { throw null; } }
        public long MaxLength { get { throw null; } }
        public string Name { get { throw null; } }
        public byte Precision { get { throw null; } }
        public byte Scale { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Data.SqlClient.SortOrder SortOrder { get { throw null; } }
        [System.MonoTODOAttribute]
        public int SortOrdinal { get { throw null; } }
        public System.Data.SqlDbType SqlDbType { get { throw null; } }
        public System.Type Type { get { throw null; } }
        [System.MonoTODOAttribute]
        public string TypeName { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool UseServerDefault { get { throw null; } }
        public string XmlSchemaCollectionDatabase { get { throw null; } }
        public string XmlSchemaCollectionName { get { throw null; } }
        public string XmlSchemaCollectionOwningSchema { get { throw null; } }
        public bool Adjust(bool value) { throw null; }
        public byte Adjust(byte value) { throw null; }
        public byte[] Adjust(byte[] value) { throw null; }
        public char Adjust(char value) { throw null; }
        public char[] Adjust(char[] value) { throw null; }
        public System.Data.SqlTypes.SqlBinary Adjust(System.Data.SqlTypes.SqlBinary value) { throw null; }
        public System.Data.SqlTypes.SqlBoolean Adjust(System.Data.SqlTypes.SqlBoolean value) { throw null; }
        public System.Data.SqlTypes.SqlByte Adjust(System.Data.SqlTypes.SqlByte value) { throw null; }
        public System.Data.SqlTypes.SqlBytes Adjust(System.Data.SqlTypes.SqlBytes value) { throw null; }
        public System.Data.SqlTypes.SqlChars Adjust(System.Data.SqlTypes.SqlChars value) { throw null; }
        public System.Data.SqlTypes.SqlDateTime Adjust(System.Data.SqlTypes.SqlDateTime value) { throw null; }
        public System.Data.SqlTypes.SqlDecimal Adjust(System.Data.SqlTypes.SqlDecimal value) { throw null; }
        public System.Data.SqlTypes.SqlDouble Adjust(System.Data.SqlTypes.SqlDouble value) { throw null; }
        public System.Data.SqlTypes.SqlGuid Adjust(System.Data.SqlTypes.SqlGuid value) { throw null; }
        public System.Data.SqlTypes.SqlInt16 Adjust(System.Data.SqlTypes.SqlInt16 value) { throw null; }
        public System.Data.SqlTypes.SqlInt32 Adjust(System.Data.SqlTypes.SqlInt32 value) { throw null; }
        public System.Data.SqlTypes.SqlInt64 Adjust(System.Data.SqlTypes.SqlInt64 value) { throw null; }
        public System.Data.SqlTypes.SqlMoney Adjust(System.Data.SqlTypes.SqlMoney value) { throw null; }
        public System.Data.SqlTypes.SqlSingle Adjust(System.Data.SqlTypes.SqlSingle value) { throw null; }
        public System.Data.SqlTypes.SqlString Adjust(System.Data.SqlTypes.SqlString value) { throw null; }
        [System.MonoTODOAttribute]
        public System.Data.SqlTypes.SqlXml Adjust(System.Data.SqlTypes.SqlXml value) { throw null; }
        public System.DateTime Adjust(System.DateTime value) { throw null; }
        public System.DateTimeOffset Adjust(System.DateTimeOffset value) { throw null; }
        public decimal Adjust(decimal value) { throw null; }
        public double Adjust(double value) { throw null; }
        public System.Guid Adjust(System.Guid value) { throw null; }
        public short Adjust(short value) { throw null; }
        public int Adjust(int value) { throw null; }
        public long Adjust(long value) { throw null; }
        public object Adjust(object value) { throw null; }
        public float Adjust(float value) { throw null; }
        public string Adjust(string value) { throw null; }
        public System.TimeSpan Adjust(System.TimeSpan value) { throw null; }
        public static Microsoft.SqlServer.Server.SqlMetaData InferFromValue(object value, string name) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class SqlMethodAttribute : Microsoft.SqlServer.Server.SqlFunctionAttribute
    {
        public SqlMethodAttribute() { }
        public bool InvokeIfReceiverIsNull { get { throw null; } set { } }
        public bool IsMutator { get { throw null; } set { } }
        public bool OnNullCall { get { throw null; } set { } }
    }
    public sealed partial class SqlPipe
    {
        internal SqlPipe() { }
        public bool IsSendingResults { get { throw null; } }
        public void ExecuteAndSend(System.Data.SqlClient.SqlCommand command) { }
        public void Send(Microsoft.SqlServer.Server.SqlDataRecord record) { }
        public void Send(System.Data.SqlClient.SqlDataReader reader) { }
        public void Send(string message) { }
        public void SendResultsEnd() { }
        public void SendResultsRow(Microsoft.SqlServer.Server.SqlDataRecord record) { }
        public void SendResultsStart(Microsoft.SqlServer.Server.SqlDataRecord record) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class SqlProcedureAttribute : System.Attribute
    {
        public SqlProcedureAttribute() { }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class SqlTriggerAttribute : System.Attribute
    {
        public SqlTriggerAttribute() { }
        public string Event { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Target { get { throw null; } set { } }
    }
    public sealed partial class SqlTriggerContext
    {
        internal SqlTriggerContext() { }
        public int ColumnCount { get { throw null; } }
        public System.Data.SqlTypes.SqlXml EventData { get { throw null; } }
        public Microsoft.SqlServer.Server.TriggerAction TriggerAction { get { throw null; } }
        public bool IsUpdatedColumn(int columnOrdinal) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12), AllowMultiple=false, Inherited=false)]
    public sealed partial class SqlUserDefinedAggregateAttribute : System.Attribute
    {
        public const int MaxByteSizeValue = 8000;
        public SqlUserDefinedAggregateAttribute(Microsoft.SqlServer.Server.Format format) { }
        public Microsoft.SqlServer.Server.Format Format { get { throw null; } }
        public bool IsInvariantToDuplicates { get { throw null; } set { } }
        public bool IsInvariantToNulls { get { throw null; } set { } }
        public bool IsInvariantToOrder { get { throw null; } set { } }
        public bool IsNullIfEmpty { get { throw null; } set { } }
        public int MaxByteSize { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12), AllowMultiple=false, Inherited=true)]
    public sealed partial class SqlUserDefinedTypeAttribute : System.Attribute
    {
        public SqlUserDefinedTypeAttribute(Microsoft.SqlServer.Server.Format format) { }
        public Microsoft.SqlServer.Server.Format Format { get { throw null; } }
        public bool IsByteOrdered { get { throw null; } set { } }
        public bool IsFixedLength { get { throw null; } set { } }
        public int MaxByteSize { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ValidationMethodName { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public enum SystemDataAccessKind
    {
        None = 0,
        Read = 1,
    }
    public enum TriggerAction
    {
        AlterAppRole = 138,
        AlterAssembly = 102,
        AlterBinding = 175,
        AlterFunction = 62,
        AlterIndex = 25,
        AlterLogin = 145,
        AlterPartitionFunction = 192,
        AlterPartitionScheme = 195,
        AlterProcedure = 52,
        AlterQueue = 158,
        AlterRole = 135,
        AlterRoute = 165,
        AlterSchema = 142,
        AlterService = 162,
        AlterTable = 22,
        AlterTrigger = 72,
        AlterUser = 132,
        AlterView = 42,
        CreateAppRole = 137,
        CreateAssembly = 101,
        CreateBinding = 174,
        CreateContract = 154,
        CreateEventNotification = 74,
        CreateFunction = 61,
        CreateIndex = 24,
        CreateLogin = 144,
        CreateMsgType = 151,
        CreatePartitionFunction = 191,
        CreatePartitionScheme = 194,
        CreateProcedure = 51,
        CreateQueue = 157,
        CreateRole = 134,
        CreateRoute = 164,
        CreateSchema = 141,
        CreateSecurityExpression = 31,
        CreateService = 161,
        CreateSynonym = 34,
        CreateTable = 21,
        CreateTrigger = 71,
        CreateType = 91,
        CreateUser = 131,
        CreateView = 41,
        Delete = 3,
        DenyObject = 171,
        DenyStatement = 168,
        DropAppRole = 139,
        DropAssembly = 103,
        DropBinding = 176,
        DropContract = 156,
        DropEventNotification = 76,
        DropFunction = 63,
        DropIndex = 26,
        DropLogin = 146,
        DropMsgType = 153,
        DropPartitionFunction = 193,
        DropPartitionScheme = 196,
        DropProcedure = 53,
        DropQueue = 159,
        DropRole = 136,
        DropRoute = 166,
        DropSchema = 143,
        DropSecurityExpression = 33,
        DropService = 163,
        DropSynonym = 36,
        DropTable = 23,
        DropTrigger = 73,
        DropType = 93,
        DropUser = 133,
        DropView = 43,
        GrantObject = 170,
        GrantStatement = 167,
        Insert = 1,
        Invalid = 0,
        RevokeObject = 172,
        RevokeStatement = 169,
        Update = 2,
    }
}
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Data
{
    public enum AcceptRejectRule
    {
        Cascade = 1,
        None = 0,
    }
    [System.FlagsAttribute]
    public enum CommandBehavior
    {
        CloseConnection = 32,
        Default = 0,
        KeyInfo = 4,
        SchemaOnly = 2,
        SequentialAccess = 16,
        SingleResult = 1,
        SingleRow = 8,
    }
    public enum CommandType
    {
        StoredProcedure = 4,
        TableDirect = 512,
        Text = 1,
    }
    public enum ConflictOption
    {
        CompareAllSearchableValues = 1,
        CompareRowVersion = 2,
        OverwriteChanges = 3,
    }
    [System.FlagsAttribute]
    public enum ConnectionState
    {
        Broken = 16,
        Closed = 0,
        Connecting = 2,
        Executing = 4,
        Fetching = 8,
        Open = 1,
    }
    [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
    [System.ComponentModel.TypeConverterAttribute("System.Data.ConstraintConverter")]
    public abstract partial class Constraint
    {
        protected Constraint() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string ConstraintName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        public abstract System.Data.DataTable Table { get; }
        [System.CLSCompliantAttribute(false)]
        protected virtual System.Data.DataSet _DataSet { get { throw null; } }
        protected void CheckStateForProperty() { }
        protected internal void SetDataSet(System.Data.DataSet dataSet) { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    public sealed partial class ConstraintCollection : System.Data.InternalDataCollectionBase
    {
        internal ConstraintCollection() { }
        public System.Data.Constraint this[int index] { get { throw null; } }
        public System.Data.Constraint this[string name] { get { throw null; } }
        protected override System.Collections.ArrayList List { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public void Add(System.Data.Constraint constraint) { }
        public System.Data.Constraint Add(string name, System.Data.DataColumn column, bool primaryKey) { throw null; }
        public System.Data.Constraint Add(string name, System.Data.DataColumn primaryKeyColumn, System.Data.DataColumn foreignKeyColumn) { throw null; }
        public System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey) { throw null; }
        public System.Data.Constraint Add(string name, System.Data.DataColumn[] primaryKeyColumns, System.Data.DataColumn[] foreignKeyColumns) { throw null; }
        public void AddRange(System.Data.Constraint[] constraints) { }
        public bool CanRemove(System.Data.Constraint constraint) { throw null; }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.Constraint[] array, int index) { }
        public int IndexOf(System.Data.Constraint constraint) { throw null; }
        public int IndexOf(string constraintName) { throw null; }
        public void Remove(System.Data.Constraint constraint) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    [System.SerializableAttribute]
    public partial class ConstraintException : System.Data.DataException
    {
        public ConstraintException() { }
        protected ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ConstraintException(string s) { }
        public ConstraintException(string message, System.Exception innerException) { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("ColumnName")]
    [System.ComponentModel.DesignTimeVisibleAttribute(false)]
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class DataColumn : System.ComponentModel.MarshalByValueComponent
    {
        public DataColumn() { }
        public DataColumn(string columnName) { }
        public DataColumn(string columnName, System.Type dataType) { }
        public DataColumn(string columnName, System.Type dataType, string expr) { }
        public DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type) { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowDBNull { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool AutoIncrement { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((long)0)]
        public long AutoIncrementSeed { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((long)1)]
        public long AutoIncrementStep { get { throw null; } set { } }
        public string Caption { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.MappingType)(1))]
        public virtual System.Data.MappingType ColumnMapping { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string ColumnName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(typeof(string))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.ColumnTypeConverter")]
        public System.Type DataType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.DataSetDateTime)(3))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public System.Data.DataSetDateTime DateTimeMode { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.Data.DefaultValueTypeConverter")]
        public object DefaultValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string Expression { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int MaxLength { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int Ordinal { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ReadOnly { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.DataTable Table { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public bool Unique { get { throw null; } set { } }
        protected internal void CheckNotAllowNull() { }
        protected void CheckUnique() { }
        protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected internal void RaisePropertyChanging(string name) { }
        public void SetOrdinal(int ordinal) { }
        public override string ToString() { throw null; }
    }
    public partial class DataColumnChangeEventArgs : System.EventArgs
    {
        public DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value) { }
        public System.Data.DataColumn Column { get { throw null; } }
        public object ProposedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Data.DataRow Row { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public delegate void DataColumnChangeEventHandler(object sender, System.Data.DataColumnChangeEventArgs e);
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    public sealed partial class DataColumnCollection : System.Data.InternalDataCollectionBase
    {
        internal DataColumnCollection() { }
        public System.Data.DataColumn this[int index] { get { throw null; } }
        public System.Data.DataColumn this[string name] { get { throw null; } }
        protected override System.Collections.ArrayList List { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public System.Data.DataColumn Add() { throw null; }
        public void Add(System.Data.DataColumn column) { }
        public System.Data.DataColumn Add(string columnName) { throw null; }
        public System.Data.DataColumn Add(string columnName, System.Type type) { throw null; }
        public System.Data.DataColumn Add(string columnName, System.Type type, string expression) { throw null; }
        public void AddRange(System.Data.DataColumn[] columns) { }
        public bool CanRemove(System.Data.DataColumn column) { throw null; }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.DataColumn[] array, int index) { }
        public int IndexOf(System.Data.DataColumn column) { throw null; }
        public int IndexOf(string columnName) { throw null; }
        public void Remove(System.Data.DataColumn column) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    [System.SerializableAttribute]
    public partial class DataException : System.SystemException
    {
        public DataException() { }
        protected DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DataException(string s) { }
        public DataException(string s, System.Exception innerException) { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("RelationName")]
    [System.ComponentModel.TypeConverterAttribute("System.Data.RelationshipConverter")]
    public partial class DataRelation
    {
        public DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
        public DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints) { }
        public DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        public DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }
        public virtual System.Data.DataColumn[] ChildColumns { get { throw null; } }
        public virtual System.Data.ForeignKeyConstraint ChildKeyConstraint { get { throw null; } }
        public virtual System.Data.DataTable ChildTable { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Data.DataSet DataSet { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public virtual bool Nested { get { throw null; } set { } }
        public virtual System.Data.DataColumn[] ParentColumns { get { throw null; } }
        public virtual System.Data.UniqueConstraint ParentKeyConstraint { get { throw null; } }
        public virtual System.Data.DataTable ParentTable { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string RelationName { get { throw null; } set { } }
        protected void CheckStateForProperty() { }
        protected internal void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected internal void RaisePropertyChanging(string name) { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    [System.ComponentModel.DefaultPropertyAttribute("Table")]
    public abstract partial class DataRelationCollection : System.Data.InternalDataCollectionBase
    {
        protected DataRelationCollection() { }
        public abstract System.Data.DataRelation this[int index] { get; }
        public abstract System.Data.DataRelation this[string name] { get; }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public virtual System.Data.DataRelation Add(System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { throw null; }
        public virtual System.Data.DataRelation Add(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { throw null; }
        public void Add(System.Data.DataRelation relation) { }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { throw null; }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints) { throw null; }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { throw null; }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints) { throw null; }
        protected virtual void AddCore(System.Data.DataRelation relation) { }
        public virtual void AddRange(System.Data.DataRelation[] relations) { }
        public virtual bool CanRemove(System.Data.DataRelation relation) { throw null; }
        public virtual void Clear() { }
        public virtual bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.DataRelation[] array, int index) { }
        protected abstract System.Data.DataSet GetDataSet();
        public virtual int IndexOf(System.Data.DataRelation relation) { throw null; }
        public virtual int IndexOf(string relationName) { throw null; }
        protected virtual void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        protected virtual void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        public void Remove(System.Data.DataRelation relation) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
        protected virtual void RemoveCore(System.Data.DataRelation relation) { }
    }
    public partial class DataRow
    {
        protected internal DataRow(System.Data.DataRowBuilder builder) { }
        public bool HasErrors { get { throw null; } }
        public object this[System.Data.DataColumn column] { get { throw null; } set { } }
        public object this[System.Data.DataColumn column, System.Data.DataRowVersion version] { get { throw null; } }
        public object this[int columnIndex] { get { throw null; } set { } }
        public object this[int columnIndex, System.Data.DataRowVersion version] { get { throw null; } }
        public object this[string columnName] { get { throw null; } set { } }
        public object this[string columnName, System.Data.DataRowVersion version] { get { throw null; } }
        public object[] ItemArray { get { throw null; } set { } }
        public string RowError { get { throw null; } set { } }
        public System.Data.DataRowState RowState { get { throw null; } }
        public System.Data.DataTable Table { get { throw null; } }
        public void AcceptChanges() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public void BeginEdit() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public void CancelEdit() { }
        public void ClearErrors() { }
        public void Delete() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public void EndEdit() { }
        public System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow[] GetChildRows(string relationName) { throw null; }
        public System.Data.DataRow[] GetChildRows(string relationName, System.Data.DataRowVersion version) { throw null; }
        public string GetColumnError(System.Data.DataColumn column) { throw null; }
        public string GetColumnError(int columnIndex) { throw null; }
        public string GetColumnError(string columnName) { throw null; }
        public System.Data.DataColumn[] GetColumnsInError() { throw null; }
        public System.Data.DataRow GetParentRow(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow GetParentRow(string relationName) { throw null; }
        public System.Data.DataRow GetParentRow(string relationName, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow[] GetParentRows(string relationName) { throw null; }
        public System.Data.DataRow[] GetParentRows(string relationName, System.Data.DataRowVersion version) { throw null; }
        public bool HasVersion(System.Data.DataRowVersion version) { throw null; }
        public bool IsNull(System.Data.DataColumn column) { throw null; }
        public bool IsNull(System.Data.DataColumn column, System.Data.DataRowVersion version) { throw null; }
        public bool IsNull(int columnIndex) { throw null; }
        public bool IsNull(string columnName) { throw null; }
        public void RejectChanges() { }
        public void SetAdded() { }
        public void SetColumnError(System.Data.DataColumn column, string error) { }
        public void SetColumnError(int columnIndex, string error) { }
        public void SetColumnError(string columnName, string error) { }
        public void SetModified() { }
        protected void SetNull(System.Data.DataColumn column) { }
        public void SetParentRow(System.Data.DataRow parentRow) { }
        public void SetParentRow(System.Data.DataRow parentRow, System.Data.DataRelation relation) { }
    }
    [System.FlagsAttribute]
    public enum DataRowAction
    {
        Add = 16,
        Change = 2,
        ChangeCurrentAndOriginal = 64,
        ChangeOriginal = 32,
        Commit = 8,
        Delete = 1,
        Nothing = 0,
        Rollback = 4,
    }
    public sealed partial class DataRowBuilder
    {
        internal DataRowBuilder() { }
    }
    public partial class DataRowChangeEventArgs : System.EventArgs
    {
        public DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action) { }
        public System.Data.DataRowAction Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Data.DataRow Row { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public delegate void DataRowChangeEventHandler(object sender, System.Data.DataRowChangeEventArgs e);
    public sealed partial class DataRowCollection : System.Data.InternalDataCollectionBase
    {
        internal DataRowCollection() { }
        public override int Count { get { throw null; } }
        public System.Data.DataRow this[int index] { get { throw null; } }
        public void Add(System.Data.DataRow row) { }
        public System.Data.DataRow Add(params object[] values) { throw null; }
        public void Clear() { }
        public bool Contains(object key) { throw null; }
        public bool Contains(object[] keys) { throw null; }
        public override void CopyTo(System.Array ar, int index) { }
        public void CopyTo(System.Data.DataRow[] array, int index) { }
        public System.Data.DataRow Find(object key) { throw null; }
        public System.Data.DataRow Find(object[] keys) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Data.DataRow row) { throw null; }
        public void InsertAt(System.Data.DataRow row, int pos) { }
        public void Remove(System.Data.DataRow row) { }
        public void RemoveAt(int index) { }
    }
    [System.FlagsAttribute]
    public enum DataRowState
    {
        Added = 4,
        Deleted = 8,
        Detached = 1,
        Modified = 16,
        Unchanged = 2,
    }
    public enum DataRowVersion
    {
        Current = 512,
        Default = 1536,
        Original = 256,
        Proposed = 1024,
    }
    public partial class DataRowView : System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.IDataErrorInfo, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged
    {
        internal DataRowView() { }
        public System.Data.DataView DataView { get { throw null; } }
        public bool IsEdit { get { throw null; } }
        public bool IsNew { get { throw null; } }
        public object this[int ndx] { get { throw null; } set { } }
        public object this[string property] { get { throw null; } set { } }
        public System.Data.DataRow Row { get { throw null; } }
        public System.Data.DataRowVersion RowVersion { get { throw null; } }
        string System.ComponentModel.IDataErrorInfo.Error { get { throw null; } }
        string System.ComponentModel.IDataErrorInfo.this[string colName] { get { throw null; } }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        public void BeginEdit() { }
        public void CancelEdit() { }
        public System.Data.DataView CreateChildView(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent) { throw null; }
        public System.Data.DataView CreateChildView(string relationName) { throw null; }
        public System.Data.DataView CreateChildView(string relationName, bool followParent) { throw null; }
        public void Delete() { }
        public void EndEdit() { }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { throw null; }
        System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("DataSetName")]
    [System.Xml.Serialization.XmlRootAttribute("DataSet")]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetDataSetSchema")]
    [System.SerializableAttribute]
    public partial class DataSet : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
    {
        public DataSet() { }
        protected DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema) { }
        public DataSet(string dataSetName) { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CaseSensitive { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataSetName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataViewManager DefaultViewManager { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool EnforceConstraints { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool HasErrors { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInitialized { get { throw null; } }
        public System.Globalization.CultureInfo Locale { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.DataRelationCollection Relations { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.SerializationFormat)(0))]
        public System.Data.SerializationFormat RemotingFormat { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public virtual System.Data.SchemaSerializationMode SchemaSerializationMode { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.DataTableCollection Tables { get { throw null; } }
        public event System.EventHandler Initialized { add { } remove { } }
        public event System.Data.MergeFailedEventHandler MergeFailed { add { } remove { } }
        public void AcceptChanges() { }
        public void BeginInit() { }
        public void Clear() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public virtual System.Data.DataSet Clone() { throw null; }
        public System.Data.DataSet Copy() { throw null; }
        public System.Data.DataTableReader CreateDataReader() { throw null; }
        public System.Data.DataTableReader CreateDataReader(params System.Data.DataTable[] dataTables) { throw null; }
        protected System.Data.SchemaSerializationMode DetermineSchemaSerializationMode(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { throw null; }
        protected System.Data.SchemaSerializationMode DetermineSchemaSerializationMode(System.Xml.XmlReader reader) { throw null; }
        public void EndInit() { }
        public System.Data.DataSet GetChanges() { throw null; }
        public System.Data.DataSet GetChanges(System.Data.DataRowState rowStates) { throw null; }
        public static System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual System.Xml.Schema.XmlSchema GetSchemaSerializable() { throw null; }
        protected void GetSerializationData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public string GetXml() { throw null; }
        public string GetXmlSchema() { throw null; }
        public bool HasChanges() { throw null; }
        public bool HasChanges(System.Data.DataRowState rowStates) { throw null; }
        public void InferXmlSchema(System.IO.Stream stream, string[] nsArray) { }
        public void InferXmlSchema(System.IO.TextReader reader, string[] nsArray) { }
        public void InferXmlSchema(string fileName, string[] nsArray) { }
        public void InferXmlSchema(System.Xml.XmlReader reader, string[] nsArray) { }
        protected virtual void InitializeDerivedDataSet() { }
        protected bool IsBinarySerialized(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { throw null; }
        public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, params System.Data.DataTable[] tables) { }
        public virtual void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, System.Data.FillErrorEventHandler errorHandler, params System.Data.DataTable[] tables) { }
        public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, params string[] tables) { }
        public void Merge(System.Data.DataRow[] rows) { }
        public void Merge(System.Data.DataRow[] rows, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        public void Merge(System.Data.DataSet dataSet) { }
        public void Merge(System.Data.DataSet dataSet, bool preserveChanges) { }
        public void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        public void Merge(System.Data.DataTable table) { }
        public void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected virtual void OnRemoveRelation(System.Data.DataRelation relation) { }
        protected internal virtual void OnRemoveTable(System.Data.DataTable table) { }
        protected internal void RaisePropertyChanging(string name) { }
        public System.Data.XmlReadMode ReadXml(System.IO.Stream stream) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.Stream stream, System.Data.XmlReadMode mode) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader, System.Data.XmlReadMode mode) { throw null; }
        public System.Data.XmlReadMode ReadXml(string fileName) { throw null; }
        public System.Data.XmlReadMode ReadXml(string fileName, System.Data.XmlReadMode mode) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode) { throw null; }
        public void ReadXmlSchema(System.IO.Stream stream) { }
        public void ReadXmlSchema(System.IO.TextReader reader) { }
        public void ReadXmlSchema(string fileName) { }
        public void ReadXmlSchema(System.Xml.XmlReader reader) { }
        protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) { }
        public virtual void RejectChanges() { }
        public virtual void Reset() { }
        protected virtual bool ShouldSerializeRelations() { throw null; }
        protected virtual bool ShouldSerializeTables() { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public void WriteXml(System.IO.Stream stream) { }
        public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.IO.TextWriter writer) { }
        public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXml(string fileName) { }
        public void WriteXml(string fileName, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.Xml.XmlWriter writer) { }
        public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXmlSchema(System.IO.Stream stream) { }
        public void WriteXmlSchema(System.IO.Stream stream, System.Converter<System.Type, string> multipleTargetConverter) { }
        public void WriteXmlSchema(System.IO.TextWriter writer) { }
        public void WriteXmlSchema(System.IO.TextWriter writer, System.Converter<System.Type, string> multipleTargetConverter) { }
        public void WriteXmlSchema(string fileName) { }
        public void WriteXmlSchema(string fileName, System.Converter<System.Type, string> multipleTargetConverter) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer, System.Converter<System.Type, string> multipleTargetConverter) { }
    }
    public enum DataSetDateTime
    {
        Local = 1,
        Unspecified = 2,
        UnspecifiedLocal = 3,
        Utc = 4,
    }
    public partial class DataSetSchemaImporterExtension : System.Xml.Serialization.Advanced.SchemaImporterExtension
    {
        public DataSetSchemaImporterExtension() { }
        public override string ImportSchemaType(string name, string schemaNamespace, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public override string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
    [System.ObsoleteAttribute("DataSysDescriptionAttribute has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial class DataSysDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        [System.ObsoleteAttribute("DataSysDescriptionAttribute has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public DataSysDescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
    [System.ComponentModel.DefaultEventAttribute("RowChanging")]
    [System.ComponentModel.DefaultPropertyAttribute("TableName")]
    [System.ComponentModel.DesignTimeVisibleAttribute(false)]
    [System.ComponentModel.ToolboxItemAttribute(false)]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetDataTableSchema")]
    [System.SerializableAttribute]
    public partial class DataTable : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
    {
        protected internal bool fInitInProgress;
        public DataTable() { }
        protected DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DataTable(string tableName) { }
        public DataTable(string tableName, string tableNamespace) { }
        public bool CaseSensitive { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.DataRelationCollection ChildRelations { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.DataColumnCollection Columns { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.ConstraintCollection Constraints { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.DataSet DataSet { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataView DefaultView { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DisplayExpression { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool HasErrors { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInitialized { get { throw null; } }
        public System.Globalization.CultureInfo Locale { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(50)]
        public int MinimumCapacity { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.DataRelationCollection ParentRelations { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.Data.PrimaryKeyTypeConverter")]
        public System.Data.DataColumn[] PrimaryKey { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.SerializationFormat)(0))]
        public System.Data.SerializationFormat RemotingFormat { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataRowCollection Rows { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string TableName { get { throw null; } set { } }
        public event System.Data.DataColumnChangeEventHandler ColumnChanged { add { } remove { } }
        public event System.Data.DataColumnChangeEventHandler ColumnChanging { add { } remove { } }
        public event System.EventHandler Initialized { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowChanged { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowChanging { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowDeleted { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowDeleting { add { } remove { } }
        public event System.Data.DataTableClearEventHandler TableCleared { add { } remove { } }
        public event System.Data.DataTableClearEventHandler TableClearing { add { } remove { } }
        public event System.Data.DataTableNewRowEventHandler TableNewRow { add { } remove { } }
        public void AcceptChanges() { }
        public virtual void BeginInit() { }
        public void BeginLoadData() { }
        public void Clear() { }
        public virtual System.Data.DataTable Clone() { throw null; }
        public object Compute(string expression, string filter) { throw null; }
        public System.Data.DataTable Copy() { throw null; }
        public System.Data.DataTableReader CreateDataReader() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]protected virtual System.Data.DataTable CreateInstance() { throw null; }
        public virtual void EndInit() { }
        public void EndLoadData() { }
        public System.Data.DataTable GetChanges() { throw null; }
        public System.Data.DataTable GetChanges(System.Data.DataRowState rowStates) { throw null; }
        public static System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public System.Data.DataRow[] GetErrors() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual System.Type GetRowType() { throw null; }
        protected virtual System.Xml.Schema.XmlSchema GetSchema() { throw null; }
        public void ImportRow(System.Data.DataRow row) { }
        public void Load(System.Data.IDataReader reader) { }
        public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption) { }
        public virtual void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, System.Data.FillErrorEventHandler errorHandler) { }
        public System.Data.DataRow LoadDataRow(object[] values, bool fAcceptChanges) { throw null; }
        public System.Data.DataRow LoadDataRow(object[] values, System.Data.LoadOption loadOption) { throw null; }
        public void Merge(System.Data.DataTable table) { }
        public void Merge(System.Data.DataTable table, bool preserveChanges) { }
        public void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        public System.Data.DataRow NewRow() { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]protected internal System.Data.DataRow[] NewRowArray(int size) { throw null; }
        protected virtual System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) { throw null; }
        protected internal virtual void OnColumnChanged(System.Data.DataColumnChangeEventArgs e) { }
        protected internal virtual void OnColumnChanging(System.Data.DataColumnChangeEventArgs e) { }
        protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected virtual void OnRemoveColumn(System.Data.DataColumn column) { }
        protected virtual void OnRowChanged(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnRowChanging(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnRowDeleted(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnRowDeleting(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnTableCleared(System.Data.DataTableClearEventArgs e) { }
        protected virtual void OnTableClearing(System.Data.DataTableClearEventArgs e) { }
        protected virtual void OnTableNewRow(System.Data.DataTableNewRowEventArgs e) { }
        public System.Data.XmlReadMode ReadXml(System.IO.Stream stream) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader) { throw null; }
        public System.Data.XmlReadMode ReadXml(string fileName) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { throw null; }
        public void ReadXmlSchema(System.IO.Stream stream) { }
        public void ReadXmlSchema(System.IO.TextReader reader) { }
        public void ReadXmlSchema(string fileName) { }
        public void ReadXmlSchema(System.Xml.XmlReader reader) { }
        protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) { }
        public void RejectChanges() { }
        public virtual void Reset() { }
        public System.Data.DataRow[] Select() { throw null; }
        public System.Data.DataRow[] Select(string filterExpression) { throw null; }
        public System.Data.DataRow[] Select(string filterExpression, string sort) { throw null; }
        public System.Data.DataRow[] Select(string filterExpression, string sort, System.Data.DataViewRowState recordStates) { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public override string ToString() { throw null; }
        public void WriteXml(System.IO.Stream stream) { }
        public void WriteXml(System.IO.Stream stream, bool writeHierarchy) { }
        public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXml(System.IO.TextWriter writer) { }
        public void WriteXml(System.IO.TextWriter writer, bool writeHierarchy) { }
        public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXml(string fileName) { }
        public void WriteXml(string fileName, bool writeHierarchy) { }
        public void WriteXml(string fileName, System.Data.XmlWriteMode mode) { }
        public void WriteXml(string fileName, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXml(System.Xml.XmlWriter writer) { }
        public void WriteXml(System.Xml.XmlWriter writer, bool writeHierarchy) { }
        public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXmlSchema(System.IO.Stream stream) { }
        public void WriteXmlSchema(System.IO.Stream stream, bool writeHierarchy) { }
        public void WriteXmlSchema(System.IO.TextWriter writer) { }
        public void WriteXmlSchema(System.IO.TextWriter writer, bool writeHierarchy) { }
        public void WriteXmlSchema(string fileName) { }
        public void WriteXmlSchema(string fileName, bool writeHierarchy) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy) { }
    }
    public sealed partial class DataTableClearEventArgs : System.EventArgs
    {
        public DataTableClearEventArgs(System.Data.DataTable dataTable) { }
        public System.Data.DataTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string TableName { get { throw null; } }
        public string TableNamespace { get { throw null; } }
    }
    public delegate void DataTableClearEventHandler(object sender, System.Data.DataTableClearEventArgs e);
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class DataTableCollection : System.Data.InternalDataCollectionBase
    {
        internal DataTableCollection() { }
        public System.Data.DataTable this[int index] { get { throw null; } }
        public System.Data.DataTable this[string name] { get { throw null; } }
        public System.Data.DataTable this[string name, string tableNamespace] { get { throw null; } }
        protected override System.Collections.ArrayList List { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanging { add { } remove { } }
        public System.Data.DataTable Add() { throw null; }
        public void Add(System.Data.DataTable table) { }
        public System.Data.DataTable Add(string name) { throw null; }
        public System.Data.DataTable Add(string name, string tableNamespace) { throw null; }
        public void AddRange(System.Data.DataTable[] tables) { }
        public bool CanRemove(System.Data.DataTable table) { throw null; }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public bool Contains(string name, string tableNamespace) { throw null; }
        public void CopyTo(System.Data.DataTable[] array, int index) { }
        public int IndexOf(System.Data.DataTable table) { throw null; }
        public int IndexOf(string tableName) { throw null; }
        public int IndexOf(string tableName, string tableNamespace) { throw null; }
        public void Remove(System.Data.DataTable table) { }
        public void Remove(string name) { }
        public void Remove(string name, string tableNamespace) { }
        public void RemoveAt(int index) { }
    }
    public sealed partial class DataTableNewRowEventArgs : System.EventArgs
    {
        public DataTableNewRowEventArgs(System.Data.DataRow dataRow) { }
        public System.Data.DataRow Row { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public delegate void DataTableNewRowEventHandler(object sender, System.Data.DataTableNewRowEventArgs e);
    public sealed partial class DataTableReader : System.Data.Common.DbDataReader
    {
        public DataTableReader(System.Data.DataTable dataTable) { }
        public DataTableReader(System.Data.DataTable[] dataTables) { }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int ordinal] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override void Close() { }
        public override bool GetBoolean(int ordinal) { throw null; }
        public override byte GetByte(int ordinal) { throw null; }
        public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw null; }
        public override char GetChar(int ordinal) { throw null; }
        public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length) { throw null; }
        public override string GetDataTypeName(int ordinal) { throw null; }
        public override System.DateTime GetDateTime(int ordinal) { throw null; }
        public override decimal GetDecimal(int ordinal) { throw null; }
        public override double GetDouble(int ordinal) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int ordinal) { throw null; }
        public override float GetFloat(int ordinal) { throw null; }
        public override System.Guid GetGuid(int ordinal) { throw null; }
        public override short GetInt16(int ordinal) { throw null; }
        public override int GetInt32(int ordinal) { throw null; }
        public override long GetInt64(int ordinal) { throw null; }
        public override string GetName(int ordinal) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        public override System.Type GetProviderSpecificFieldType(int ordinal) { throw null; }
        public override object GetProviderSpecificValue(int ordinal) { throw null; }
        public override int GetProviderSpecificValues(object[] values) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int ordinal) { throw null; }
        public override object GetValue(int ordinal) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int ordinal) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("PositionChanged")]
    [System.ComponentModel.DefaultPropertyAttribute("Table")]
    public partial class DataView : System.ComponentModel.MarshalByValueComponent, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.IBindingListView, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.ComponentModel.ITypedList
    {
        public DataView() { }
        public DataView(System.Data.DataTable table) { }
        public DataView(System.Data.DataTable table, string RowFilter, string Sort, System.Data.DataViewRowState RowState) { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowDelete { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowEdit { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowNew { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool ApplyDefaultSort { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataViewManager DataViewManager { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInitialized { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        protected bool IsOpen { get { throw null; } }
        public System.Data.DataRowView this[int recordIndex] { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string RowFilter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.DataViewRowState)(22))]
        public System.Data.DataViewRowState RowStateFilter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Sort { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int recordIndex] { get { throw null; } set { } }
        bool System.ComponentModel.IBindingList.AllowEdit { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowNew { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowRemove { get { throw null; } }
        bool System.ComponentModel.IBindingList.IsSorted { get { throw null; } }
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { throw null; } }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSearching { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSorting { get { throw null; } }
        string System.ComponentModel.IBindingListView.Filter { get { throw null; } set { } }
        System.ComponentModel.ListSortDescriptionCollection System.ComponentModel.IBindingListView.SortDescriptions { get { throw null; } }
        bool System.ComponentModel.IBindingListView.SupportsAdvancedSorting { get { throw null; } }
        bool System.ComponentModel.IBindingListView.SupportsFiltering { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.DataTableTypeConverter")]
        public System.Data.DataTable Table { get { throw null; } set { } }
        public event System.EventHandler Initialized { add { } remove { } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public virtual System.Data.DataRowView AddNew() { throw null; }
        public void BeginInit() { }
        protected void Close() { }
        protected virtual void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        public void CopyTo(System.Array array, int index) { }
        public void Delete(int index) { }
        protected override void Dispose(bool disposing) { }
        public void EndInit() { }
        public virtual bool Equals(System.Data.DataView view) { throw null; }
        public int Find(object key) { throw null; }
        public int Find(object[] key) { throw null; }
        public System.Data.DataRowView[] FindRows(object key) { throw null; }
        public System.Data.DataRowView[] FindRows(object[] key) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected virtual void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e) { }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        protected void Open() { }
        protected void Reset() { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
        object System.ComponentModel.IBindingList.AddNew() { throw null; }
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { throw null; }
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
        void System.ComponentModel.IBindingList.RemoveSort() { }
        void System.ComponentModel.IBindingListView.ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts) { }
        void System.ComponentModel.IBindingListView.RemoveFilter() { }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        public System.Data.DataTable ToTable() { throw null; }
        public System.Data.DataTable ToTable(bool distinct, params string[] columnNames) { throw null; }
        public System.Data.DataTable ToTable(string tableName) { throw null; }
        public System.Data.DataTable ToTable(string tableName, bool distinct, params string[] columnNames) { throw null; }
        protected void UpdateIndex() { }
        protected virtual void UpdateIndex(bool force) { }
    }
    public partial class DataViewManager : System.ComponentModel.MarshalByValueComponent, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ITypedList
    {
        public DataViewManager() { }
        public DataViewManager(System.Data.DataSet dataSet) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.Data.DataSet DataSet { get { throw null; } set { } }
        public string DataViewSettingCollectionString { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.DataViewSettingCollection DataViewSettings { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        bool System.ComponentModel.IBindingList.AllowEdit { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowNew { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowRemove { get { throw null; } }
        bool System.ComponentModel.IBindingList.IsSorted { get { throw null; } }
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { throw null; } }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSearching { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSorting { get { throw null; } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public System.Data.DataView CreateDataView(System.Data.DataTable table) { throw null; }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        protected virtual void RelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
        object System.ComponentModel.IBindingList.AddNew() { throw null; }
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { throw null; }
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
        void System.ComponentModel.IBindingList.RemoveSort() { }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        protected virtual void TableCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
    }
    [System.FlagsAttribute]
    public enum DataViewRowState
    {
        Added = 4,
        CurrentRows = 22,
        Deleted = 8,
        ModifiedCurrent = 16,
        ModifiedOriginal = 32,
        None = 0,
        OriginalRows = 42,
        Unchanged = 2,
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class DataViewSetting
    {
        internal DataViewSetting() { }
        public bool ApplyDefaultSort { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataViewManager DataViewManager { get { throw null; } }
        public string RowFilter { get { throw null; } set { } }
        public System.Data.DataViewRowState RowStateFilter { get { throw null; } set { } }
        public string Sort { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataTable Table { get { throw null; } }
    }
    public partial class DataViewSettingCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal DataViewSettingCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsSynchronized { get { throw null; } }
        public virtual System.Data.DataViewSetting this[System.Data.DataTable table] { get { throw null; } set { } }
        public virtual System.Data.DataViewSetting this[int index] { get { throw null; } set { } }
        public virtual System.Data.DataViewSetting this[string tableName] { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public object SyncRoot { get { throw null; } }
        public void CopyTo(System.Array ar, int index) { }
        public void CopyTo(System.Data.DataViewSetting[] ar, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class DBConcurrencyException : System.SystemException
    {
        public DBConcurrencyException() { }
        public DBConcurrencyException(string message) { }
        public DBConcurrencyException(string message, System.Exception inner) { }
        public DBConcurrencyException(string message, System.Exception inner, System.Data.DataRow[] dataRows) { }
        public System.Data.DataRow Row { get { throw null; } set { } }
        public int RowCount { get { throw null; } }
        public void CopyToRows(System.Data.DataRow[] array) { }
        public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum DbType
    {
        AnsiString = 0,
        AnsiStringFixedLength = 22,
        Binary = 1,
        Boolean = 3,
        Byte = 2,
        Currency = 4,
        Date = 5,
        DateTime = 6,
        DateTime2 = 26,
        DateTimeOffset = 27,
        Decimal = 7,
        Double = 8,
        Guid = 9,
        Int16 = 10,
        Int32 = 11,
        Int64 = 12,
        Object = 13,
        SByte = 14,
        Single = 15,
        String = 16,
        StringFixedLength = 23,
        Time = 17,
        UInt16 = 18,
        UInt32 = 19,
        UInt64 = 20,
        VarNumeric = 21,
        Xml = 25,
    }
    [System.SerializableAttribute]
    public partial class DeletedRowInaccessibleException : System.Data.DataException
    {
        public DeletedRowInaccessibleException() { }
        protected DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DeletedRowInaccessibleException(string s) { }
        public DeletedRowInaccessibleException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class DuplicateNameException : System.Data.DataException
    {
        public DuplicateNameException() { }
        protected DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DuplicateNameException(string s) { }
        public DuplicateNameException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class EvaluateException : System.Data.InvalidExpressionException
    {
        public EvaluateException() { }
        protected EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EvaluateException(string s) { }
        public EvaluateException(string message, System.Exception innerException) { }
    }
    public partial class FillErrorEventArgs : System.EventArgs
    {
        public FillErrorEventArgs(System.Data.DataTable dataTable, object[] values) { }
        public bool Continue { get { throw null; } set { } }
        public System.Data.DataTable DataTable { get { throw null; } }
        public System.Exception Errors { get { throw null; } set { } }
        public object[] Values { get { throw null; } }
    }
    public delegate void FillErrorEventHandler(object sender, System.Data.FillErrorEventArgs e);
    [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
    public partial class ForeignKeyConstraint : System.Data.Constraint
    {
        public ForeignKeyConstraint(System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
        public ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        public ForeignKeyConstraint(string constraintName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
        public ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public ForeignKeyConstraint(string constraintName, string parentTableName, string parentTableNamespace, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
        [System.ComponentModel.DefaultValueAttribute((System.Data.AcceptRejectRule)(0))]
        public virtual System.Data.AcceptRejectRule AcceptRejectRule { get { throw null; } set { } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataColumn[] Columns { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.Rule)(1))]
        public virtual System.Data.Rule DeleteRule { get { throw null; } set { } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataColumn[] RelatedColumns { get { throw null; } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataTable RelatedTable { get { throw null; } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public override System.Data.DataTable Table { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.Rule)(1))]
        public virtual System.Data.Rule UpdateRule { get { throw null; } set { } }
        public override bool Equals(object key) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial interface IColumnMapping
    {
        string DataSetColumn { get; set; }
        string SourceColumn { get; set; }
    }
    public partial interface IColumnMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        object this[string index] { get; set; }
        System.Data.IColumnMapping Add(string sourceColumnName, string dataSetColumnName);
        bool Contains(string sourceColumnName);
        System.Data.IColumnMapping GetByDataSetColumn(string dataSetColumnName);
        int IndexOf(string sourceColumnName);
        void RemoveAt(string sourceColumnName);
    }
    public partial interface IDataAdapter
    {
        System.Data.MissingMappingAction MissingMappingAction { get; set; }
        System.Data.MissingSchemaAction MissingSchemaAction { get; set; }
        System.Data.ITableMappingCollection TableMappings { get; }
        int Fill(System.Data.DataSet dataSet);
        System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType);
        System.Data.IDataParameter[] GetFillParameters();
        int Update(System.Data.DataSet dataSet);
    }
    public partial interface IDataParameter
    {
        System.Data.DbType DbType { get; set; }
        System.Data.ParameterDirection Direction { get; set; }
        bool IsNullable { get; }
        string ParameterName { get; set; }
        string SourceColumn { get; set; }
        System.Data.DataRowVersion SourceVersion { get; set; }
        object Value { get; set; }
    }
    public partial interface IDataParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        object this[string parameterName] { get; set; }
        bool Contains(string parameterName);
        int IndexOf(string parameterName);
        void RemoveAt(string parameterName);
    }
    public partial interface IDataReader : System.Data.IDataRecord, System.IDisposable
    {
        int Depth { get; }
        bool IsClosed { get; }
        int RecordsAffected { get; }
        void Close();
        System.Data.DataTable GetSchemaTable();
        bool NextResult();
        bool Read();
    }
    public partial interface IDataRecord
    {
        int FieldCount { get; }
        object this[int i] { get; }
        object this[string name] { get; }
        bool GetBoolean(int i);
        byte GetByte(int i);
        long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);
        char GetChar(int i);
        long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);
        System.Data.IDataReader GetData(int i);
        string GetDataTypeName(int i);
        System.DateTime GetDateTime(int i);
        decimal GetDecimal(int i);
        double GetDouble(int i);
        System.Type GetFieldType(int i);
        float GetFloat(int i);
        System.Guid GetGuid(int i);
        short GetInt16(int i);
        int GetInt32(int i);
        long GetInt64(int i);
        string GetName(int i);
        int GetOrdinal(string name);
        string GetString(int i);
        object GetValue(int i);
        int GetValues(object[] values);
        bool IsDBNull(int i);
    }
    public partial interface IDbCommand : System.IDisposable
    {
        string CommandText { get; set; }
        int CommandTimeout { get; set; }
        System.Data.CommandType CommandType { get; set; }
        System.Data.IDbConnection Connection { get; set; }
        System.Data.IDataParameterCollection Parameters { get; }
        System.Data.IDbTransaction Transaction { get; set; }
        System.Data.UpdateRowSource UpdatedRowSource { get; set; }
        void Cancel();
        System.Data.IDbDataParameter CreateParameter();
        int ExecuteNonQuery();
        System.Data.IDataReader ExecuteReader();
        System.Data.IDataReader ExecuteReader(System.Data.CommandBehavior behavior);
        object ExecuteScalar();
        void Prepare();
    }
    public partial interface IDbConnection : System.IDisposable
    {
        string ConnectionString { get; set; }
        int ConnectionTimeout { get; }
        string Database { get; }
        System.Data.ConnectionState State { get; }
        System.Data.IDbTransaction BeginTransaction();
        System.Data.IDbTransaction BeginTransaction(System.Data.IsolationLevel il);
        void ChangeDatabase(string databaseName);
        void Close();
        System.Data.IDbCommand CreateCommand();
        void Open();
    }
    public partial interface IDbDataAdapter : System.Data.IDataAdapter
    {
        System.Data.IDbCommand DeleteCommand { get; set; }
        System.Data.IDbCommand InsertCommand { get; set; }
        System.Data.IDbCommand SelectCommand { get; set; }
        System.Data.IDbCommand UpdateCommand { get; set; }
    }
    public partial interface IDbDataParameter : System.Data.IDataParameter
    {
        byte Precision { get; set; }
        byte Scale { get; set; }
        int Size { get; set; }
    }
    public partial interface IDbTransaction : System.IDisposable
    {
        System.Data.IDbConnection Connection { get; }
        System.Data.IsolationLevel IsolationLevel { get; }
        void Commit();
        void Rollback();
    }
    [System.SerializableAttribute]
    public partial class InRowChangingEventException : System.Data.DataException
    {
        public InRowChangingEventException() { }
        protected InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InRowChangingEventException(string s) { }
        public InRowChangingEventException(string message, System.Exception innerException) { }
    }
    public partial class InternalDataCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public InternalDataCollectionBase() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsSynchronized { get { throw null; } }
        protected virtual System.Collections.ArrayList List { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public object SyncRoot { get { throw null; } }
        public virtual void CopyTo(System.Array ar, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class InvalidConstraintException : System.Data.DataException
    {
        public InvalidConstraintException() { }
        protected InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidConstraintException(string s) { }
        public InvalidConstraintException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class InvalidExpressionException : System.Data.DataException
    {
        public InvalidExpressionException() { }
        protected InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidExpressionException(string s) { }
        public InvalidExpressionException(string message, System.Exception innerException) { }
    }
    public enum IsolationLevel
    {
        Chaos = 16,
        ReadCommitted = 4096,
        ReadUncommitted = 256,
        RepeatableRead = 65536,
        Serializable = 1048576,
        Snapshot = 16777216,
        Unspecified = -1,
    }
    public partial interface ITableMapping
    {
        System.Data.IColumnMappingCollection ColumnMappings { get; }
        string DataSetTable { get; set; }
        string SourceTable { get; set; }
    }
    public partial interface ITableMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        object this[string index] { get; set; }
        System.Data.ITableMapping Add(string sourceTableName, string dataSetTableName);
        bool Contains(string sourceTableName);
        System.Data.ITableMapping GetByDataSetTable(string dataSetTableName);
        int IndexOf(string sourceTableName);
        void RemoveAt(string sourceTableName);
    }
    [System.SerializableAttribute]
    public enum KeyRestrictionBehavior
    {
        AllowOnly = 0,
        PreventUsage = 1,
    }
    public enum LoadOption
    {
        OverwriteChanges = 1,
        PreserveChanges = 2,
        Upsert = 3,
    }
    [System.SerializableAttribute]
    public enum MappingType
    {
        Attribute = 2,
        Element = 1,
        Hidden = 4,
        SimpleContent = 3,
    }
    public partial class MergeFailedEventArgs : System.EventArgs
    {
        public MergeFailedEventArgs(System.Data.DataTable table, string conflict) { }
        public string Conflict { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Data.DataTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public delegate void MergeFailedEventHandler(object sender, System.Data.MergeFailedEventArgs e);
    public enum MissingMappingAction
    {
        Error = 3,
        Ignore = 2,
        Passthrough = 1,
    }
    [System.SerializableAttribute]
    public partial class MissingPrimaryKeyException : System.Data.DataException
    {
        public MissingPrimaryKeyException() { }
        protected MissingPrimaryKeyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MissingPrimaryKeyException(string s) { }
        public MissingPrimaryKeyException(string message, System.Exception innerException) { }
    }
    public enum MissingSchemaAction
    {
        Add = 1,
        AddWithKey = 4,
        Error = 3,
        Ignore = 2,
    }
    [System.SerializableAttribute]
    public partial class NoNullAllowedException : System.Data.DataException
    {
        public NoNullAllowedException() { }
        protected NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NoNullAllowedException(string s) { }
        public NoNullAllowedException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public sealed partial class OperationAbortedException : System.SystemException
    {
        internal OperationAbortedException() { }
    }
    public enum ParameterDirection
    {
        Input = 1,
        InputOutput = 3,
        Output = 2,
        ReturnValue = 6,
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("PropertyAttributes has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public enum PropertyAttributes
    {
        NotSupported = 0,
        Optional = 2,
        Read = 512,
        Required = 1,
        Write = 1024,
    }
    [System.SerializableAttribute]
    public partial class PropertyCollection : System.Collections.Hashtable
    {
        public PropertyCollection() { }
        protected PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override object Clone() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ReadOnlyException : System.Data.DataException
    {
        public ReadOnlyException() { }
        protected ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ReadOnlyException(string s) { }
        public ReadOnlyException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class RowNotInTableException : System.Data.DataException
    {
        public RowNotInTableException() { }
        protected RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RowNotInTableException(string s) { }
        public RowNotInTableException(string message, System.Exception innerException) { }
    }
    public enum Rule
    {
        Cascade = 1,
        None = 0,
        SetDefault = 3,
        SetNull = 2,
    }
    public enum SchemaSerializationMode
    {
        ExcludeSchema = 2,
        IncludeSchema = 1,
    }
    public enum SchemaType
    {
        Mapped = 2,
        Source = 1,
    }
    public enum SerializationFormat
    {
        Binary = 1,
        Xml = 0,
    }
    public enum SqlDbType
    {
        BigInt = 0,
        Binary = 1,
        Bit = 2,
        Char = 3,
        Date = 31,
        DateTime = 4,
        DateTime2 = 33,
        DateTimeOffset = 34,
        Decimal = 5,
        Float = 6,
        Image = 7,
        Int = 8,
        Money = 9,
        NChar = 10,
        NText = 11,
        NVarChar = 12,
        Real = 13,
        SmallDateTime = 15,
        SmallInt = 16,
        SmallMoney = 17,
        Structured = 30,
        Text = 18,
        Time = 32,
        Timestamp = 19,
        TinyInt = 20,
        Udt = 29,
        UniqueIdentifier = 14,
        VarBinary = 21,
        VarChar = 22,
        Variant = 23,
        Xml = 25,
    }
    public sealed partial class StateChangeEventArgs : System.EventArgs
    {
        public StateChangeEventArgs(System.Data.ConnectionState originalState, System.Data.ConnectionState currentState) { }
        public System.Data.ConnectionState CurrentState { get { throw null; } }
        public System.Data.ConnectionState OriginalState { get { throw null; } }
    }
    public delegate void StateChangeEventHandler(object sender, System.Data.StateChangeEventArgs e);
    public sealed partial class StatementCompletedEventArgs : System.EventArgs
    {
        public StatementCompletedEventArgs(int recordCount) { }
        public int RecordCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public delegate void StatementCompletedEventHandler(object sender, System.Data.StatementCompletedEventArgs e);
    public enum StatementType
    {
        Batch = 4,
        Delete = 3,
        Insert = 1,
        Select = 0,
        Update = 2,
    }
    [System.SerializableAttribute]
    public partial class StrongTypingException : System.Data.DataException
    {
        public StrongTypingException() { }
        protected StrongTypingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public StrongTypingException(string message) { }
        public StrongTypingException(string s, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class SyntaxErrorException : System.Data.InvalidExpressionException
    {
        public SyntaxErrorException() { }
        protected SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SyntaxErrorException(string s) { }
        public SyntaxErrorException(string message, System.Exception innerException) { }
    }
    [System.ObsoleteAttribute("TypedDataSetGenerator class will be removed in a future release. Please use System.Data.Design.TypedDataSetGenerator in System.Design.dll.")]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SharedState=true, Synchronization=true)]
    public partial class TypedDataSetGenerator
    {
        public TypedDataSetGenerator() { }
        public static void Generate(System.Data.DataSet dataSet, System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.Compiler.ICodeGenerator codeGen) { }
        public static string GenerateIdName(string name, System.CodeDom.Compiler.ICodeGenerator codeGen) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class TypedDataSetGeneratorException : System.Data.DataException
    {
        public TypedDataSetGeneratorException() { }
        public TypedDataSetGeneratorException(System.Collections.ArrayList list) { }
        protected TypedDataSetGeneratorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TypedDataSetGeneratorException(string message) { }
        public TypedDataSetGeneratorException(string message, System.Exception innerException) { }
        public System.Collections.ArrayList ErrorList { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
    public partial class UniqueConstraint : System.Data.Constraint
    {
        public UniqueConstraint(System.Data.DataColumn column) { }
        public UniqueConstraint(System.Data.DataColumn column, bool isPrimaryKey) { }
        public UniqueConstraint(System.Data.DataColumn[] columns) { }
        public UniqueConstraint(System.Data.DataColumn[] columns, bool isPrimaryKey) { }
        public UniqueConstraint(string name, System.Data.DataColumn column) { }
        public UniqueConstraint(string name, System.Data.DataColumn column, bool isPrimaryKey) { }
        public UniqueConstraint(string name, System.Data.DataColumn[] columns) { }
        public UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey) { }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataColumn[] Columns { get { throw null; } }
        public bool IsPrimaryKey { get { throw null; } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public override System.Data.DataTable Table { get { throw null; } }
        public override bool Equals(object key2) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum UpdateRowSource
    {
        Both = 3,
        FirstReturnedRecord = 2,
        None = 0,
        OutputParameters = 1,
    }
    public enum UpdateStatus
    {
        Continue = 0,
        ErrorsOccurred = 1,
        SkipAllRemainingRows = 3,
        SkipCurrentRow = 2,
    }
    [System.SerializableAttribute]
    public partial class VersionNotFoundException : System.Data.DataException
    {
        public VersionNotFoundException() { }
        protected VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public VersionNotFoundException(string s) { }
        public VersionNotFoundException(string message, System.Exception innerException) { }
    }
    public enum XmlReadMode
    {
        Auto = 0,
        DiffGram = 4,
        Fragment = 5,
        IgnoreSchema = 2,
        InferSchema = 3,
        InferTypedSchema = 6,
        ReadSchema = 1,
    }
    public enum XmlWriteMode
    {
        DiffGram = 2,
        IgnoreSchema = 1,
        WriteSchema = 0,
    }
}
namespace System.Data.Common
{
    public enum CatalogLocation
    {
        End = 2,
        Start = 1,
    }
    public partial class DataAdapter : System.ComponentModel.Component, System.Data.IDataAdapter
    {
        protected DataAdapter() { }
        protected DataAdapter(System.Data.Common.DataAdapter from) { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AcceptChangesDuringFill { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AcceptChangesDuringUpdate { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ContinueUpdateOnError { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public System.Data.LoadOption FillLoadOption { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.MissingMappingAction)(1))]
        public System.Data.MissingMappingAction MissingMappingAction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.MissingSchemaAction)(1))]
        public System.Data.MissingSchemaAction MissingSchemaAction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public virtual bool ReturnProviderSpecificTypes { get { throw null; } set { } }
        System.Data.ITableMappingCollection System.Data.IDataAdapter.TableMappings { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.Common.DataTableMappingCollection TableMappings { get { throw null; } }
        public event System.Data.FillErrorEventHandler FillError { add { } remove { } }
        [System.ObsoleteAttribute("CloneInternals() has been deprecated.  Use the DataAdapter(DataAdapter from) constructor.  http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual System.Data.Common.DataAdapter CloneInternals() { throw null; }
        protected virtual System.Data.Common.DataTableMappingCollection CreateTableMappings() { throw null; }
        protected override void Dispose(bool disposing) { }
        public virtual int Fill(System.Data.DataSet dataSet) { throw null; }
        protected virtual int Fill(System.Data.DataSet dataSet, string srcTable, System.Data.IDataReader dataReader, int startRecord, int maxRecords) { throw null; }
        protected virtual int Fill(System.Data.DataTable dataTable, System.Data.IDataReader dataReader) { throw null; }
        protected virtual int Fill(System.Data.DataTable[] dataTables, System.Data.IDataReader dataReader, int startRecord, int maxRecords) { throw null; }
        public virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) { throw null; }
        protected virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable, System.Data.IDataReader dataReader) { throw null; }
        protected virtual System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType, System.Data.IDataReader dataReader) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public virtual System.Data.IDataParameter[] GetFillParameters() { throw null; }
        protected bool HasTableMappings() { throw null; }
        protected virtual void OnFillError(System.Data.FillErrorEventArgs value) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public void ResetFillLoadOption() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual bool ShouldSerializeAcceptChangesDuringFill() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual bool ShouldSerializeFillLoadOption() { throw null; }
        protected virtual bool ShouldSerializeTableMappings() { throw null; }
        public virtual int Update(System.Data.DataSet dataSet) { throw null; }
    }
    [System.ComponentModel.TypeConverterAttribute("System.Data.Common.DataColumnMapping.DataColumnMappingConverter")]
    public sealed partial class DataColumnMapping : System.MarshalByRefObject, System.Data.IColumnMapping, System.ICloneable
    {
        public DataColumnMapping() { }
        public DataColumnMapping(string sourceColumn, string dataSetColumn) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataSetColumn { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SourceColumn { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Data.DataColumn GetDataColumnBySchemaAction(System.Data.DataTable dataTable, System.Type dataType, System.Data.MissingSchemaAction schemaAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static System.Data.DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, System.Data.DataTable dataTable, System.Type dataType, System.Data.MissingSchemaAction schemaAction) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class DataColumnMappingCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IColumnMappingCollection
    {
        public DataColumnMappingCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DataColumnMapping this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DataColumnMapping this[string sourceColumn] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        object System.Data.IColumnMappingCollection.this[string index] { get { throw null; } set { } }
        public int Add(object value) { throw null; }
        public System.Data.Common.DataColumnMapping Add(string sourceColumn, string dataSetColumn) { throw null; }
        public void AddRange(System.Array values) { }
        public void AddRange(System.Data.Common.DataColumnMapping[] values) { }
        public void Clear() { }
        public bool Contains(object value) { throw null; }
        public bool Contains(string value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.Common.DataColumnMapping[] array, int index) { }
        public System.Data.Common.DataColumnMapping GetByDataSetColumn(string value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static System.Data.Common.DataColumnMapping GetColumnMappingBySchemaAction(System.Data.Common.DataColumnMappingCollection columnMappings, string sourceColumn, System.Data.MissingMappingAction mappingAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static System.Data.DataColumn GetDataColumn(System.Data.Common.DataColumnMappingCollection columnMappings, string sourceColumn, System.Type dataType, System.Data.DataTable dataTable, System.Data.MissingMappingAction mappingAction, System.Data.MissingSchemaAction schemaAction) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(object value) { throw null; }
        public int IndexOf(string sourceColumn) { throw null; }
        public int IndexOfDataSetColumn(string dataSetColumn) { throw null; }
        public void Insert(int index, System.Data.Common.DataColumnMapping value) { }
        public void Insert(int index, object value) { }
        public void Remove(System.Data.Common.DataColumnMapping value) { }
        public void Remove(object value) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(string sourceColumn) { }
        System.Data.IColumnMapping System.Data.IColumnMappingCollection.Add(string sourceColumnName, string dataSetColumnName) { throw null; }
        System.Data.IColumnMapping System.Data.IColumnMappingCollection.GetByDataSetColumn(string dataSetColumnName) { throw null; }
    }
    [System.ComponentModel.TypeConverterAttribute("System.Data.Common.DataTableMapping.DataTableMappingConverter")]
    public sealed partial class DataTableMapping : System.MarshalByRefObject, System.Data.ITableMapping, System.ICloneable
    {
        public DataTableMapping() { }
        public DataTableMapping(string sourceTable, string dataSetTable) { }
        public DataTableMapping(string sourceTable, string dataSetTable, System.Data.Common.DataColumnMapping[] columnMappings) { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.Common.DataColumnMappingCollection ColumnMappings { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataSetTable { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SourceTable { get { throw null; } set { } }
        System.Data.IColumnMappingCollection System.Data.ITableMapping.ColumnMappings { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Data.Common.DataColumnMapping GetColumnMappingBySchemaAction(string sourceColumn, System.Data.MissingMappingAction mappingAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Data.DataColumn GetDataColumn(string sourceColumn, System.Type dataType, System.Data.DataTable dataTable, System.Data.MissingMappingAction mappingAction, System.Data.MissingSchemaAction schemaAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public System.Data.DataTable GetDataTableBySchemaAction(System.Data.DataSet dataSet, System.Data.MissingSchemaAction schemaAction) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class DataTableMappingCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.ITableMappingCollection
    {
        public DataTableMappingCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DataTableMapping this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DataTableMapping this[string sourceTable] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        object System.Data.ITableMappingCollection.this[string index] { get { throw null; } set { } }
        public int Add(object value) { throw null; }
        public System.Data.Common.DataTableMapping Add(string sourceTable, string dataSetTable) { throw null; }
        public void AddRange(System.Array values) { }
        public void AddRange(System.Data.Common.DataTableMapping[] values) { }
        public void Clear() { }
        public bool Contains(object value) { throw null; }
        public bool Contains(string value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.Common.DataTableMapping[] array, int index) { }
        public System.Data.Common.DataTableMapping GetByDataSetTable(string dataSetTable) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static System.Data.Common.DataTableMapping GetTableMappingBySchemaAction(System.Data.Common.DataTableMappingCollection tableMappings, string sourceTable, string dataSetTable, System.Data.MissingMappingAction mappingAction) { throw null; }
        public int IndexOf(object value) { throw null; }
        public int IndexOf(string sourceTable) { throw null; }
        public int IndexOfDataSetTable(string dataSetTable) { throw null; }
        public void Insert(int index, System.Data.Common.DataTableMapping value) { }
        public void Insert(int index, object value) { }
        public void Remove(System.Data.Common.DataTableMapping value) { }
        public void Remove(object value) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(string sourceTable) { }
        System.Data.ITableMapping System.Data.ITableMappingCollection.Add(string sourceTableName, string dataSetTableName) { throw null; }
        System.Data.ITableMapping System.Data.ITableMappingCollection.GetByDataSetTable(string dataSetTableName) { throw null; }
    }
    public abstract partial class DbCommand : System.ComponentModel.Component, System.Data.IDbCommand, System.IDisposable
    {
        protected DbCommand() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public abstract string CommandText { get; set; }
        public abstract int CommandTimeout { get; set; }
        [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public abstract System.Data.CommandType CommandType { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbConnection Connection { get { throw null; } set { } }
        protected abstract System.Data.Common.DbConnection DbConnection { get; set; }
        protected abstract System.Data.Common.DbParameterCollection DbParameterCollection { get; }
        protected abstract System.Data.Common.DbTransaction DbTransaction { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract bool DesignTimeVisible { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbParameterCollection Parameters { get { throw null; } }
        System.Data.IDbConnection System.Data.IDbCommand.Connection { get { throw null; } set { } }
        System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { throw null; } }
        System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
        public abstract System.Data.UpdateRowSource UpdatedRowSource { get; set; }
        public abstract void Cancel();
        protected abstract System.Data.Common.DbParameter CreateDbParameter();
        public System.Data.Common.DbParameter CreateParameter() { throw null; }
        protected abstract System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior);
        protected virtual System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract int ExecuteNonQuery();
        public System.Threading.Tasks.Task<int> ExecuteNonQueryAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Data.Common.DbDataReader ExecuteReader() { throw null; }
        public System.Data.Common.DbDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync() { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract object ExecuteScalar();
        public System.Threading.Tasks.Task<object> ExecuteScalarAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract void Prepare();
        System.Data.IDbDataParameter System.Data.IDbCommand.CreateParameter() { throw null; }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { throw null; }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
    }
    public abstract partial class DbCommandBuilder : System.ComponentModel.Component
    {
        protected DbCommandBuilder() { }
        [System.ComponentModel.DefaultValueAttribute((System.Data.Common.CatalogLocation)(1))]
        public virtual System.Data.Common.CatalogLocation CatalogLocation { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(".")]
        public virtual string CatalogSeparator { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.ConflictOption)(1))]
        public virtual System.Data.ConflictOption ConflictOption { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbDataAdapter DataAdapter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string QuotePrefix { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string QuoteSuffix { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(".")]
        public virtual string SchemaSeparator { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SetAllValues { get { throw null; } set { } }
        protected abstract void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow row, System.Data.StatementType statementType, bool whereClause);
        protected override void Dispose(bool disposing) { }
        public System.Data.Common.DbCommand GetDeleteCommand() { throw null; }
        public System.Data.Common.DbCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public System.Data.Common.DbCommand GetInsertCommand() { throw null; }
        public System.Data.Common.DbCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected abstract string GetParameterName(int parameterOrdinal);
        protected abstract string GetParameterName(string parameterName);
        protected abstract string GetParameterPlaceholder(int parameterOrdinal);
        protected virtual System.Data.DataTable GetSchemaTable(System.Data.Common.DbCommand sourceCommand) { throw null; }
        public System.Data.Common.DbCommand GetUpdateCommand() { throw null; }
        public System.Data.Common.DbCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        protected virtual System.Data.Common.DbCommand InitializeCommand(System.Data.Common.DbCommand command) { throw null; }
        public virtual string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        public virtual void RefreshSchema() { }
        protected void RowUpdatingHandler(System.Data.Common.RowUpdatingEventArgs rowUpdatingEvent) { }
        protected abstract void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter);
        public virtual string UnquoteIdentifier(string quotedIdentifier) { throw null; }
    }
    public abstract partial class DbConnection : System.ComponentModel.Component, System.Data.IDbConnection, System.IDisposable
    {
        protected DbConnection() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public abstract string ConnectionString { get; set; }
        public virtual int ConnectionTimeout { get { throw null; } }
        public abstract string Database { get; }
        public abstract string DataSource { get; }
        protected virtual System.Data.Common.DbProviderFactory DbProviderFactory { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public abstract string ServerVersion { get; }
        [System.ComponentModel.BrowsableAttribute(false)]
        public abstract System.Data.ConnectionState State { get; }
        public virtual event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
        protected abstract System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel);
        public System.Data.Common.DbTransaction BeginTransaction() { throw null; }
        public System.Data.Common.DbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public abstract void ChangeDatabase(string databaseName);
        public abstract void Close();
        public System.Data.Common.DbCommand CreateCommand() { throw null; }
        protected abstract System.Data.Common.DbCommand CreateDbCommand();
        public virtual void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public virtual System.Data.DataTable GetSchema() { throw null; }
        public virtual System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public virtual System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        protected virtual void OnStateChange(System.Data.StateChangeEventArgs stateChange) { }
        public abstract void Open();
        public System.Threading.Tasks.Task OpenAsync() { throw null; }
        public virtual System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { throw null; }
        System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { throw null; }
    }
    public partial class DbConnectionStringBuilder : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor
    {
        public DbConnectionStringBuilder() { }
        public DbConnectionStringBuilder(bool useOdbcRules) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public bool BrowsableConnectionString { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual bool IsFixedSize { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual object this[string keyword] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual System.Collections.ICollection Keys { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IDictionary.this[object keyword] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual System.Collections.ICollection Values { get { throw null; } }
        public void Add(string keyword, object value) { }
        public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value) { }
        public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value, bool useOdbcRules) { }
        public virtual void Clear() { }
        protected internal void ClearPropertyDescriptors() { }
        public virtual bool ContainsKey(string keyword) { throw null; }
        public virtual bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) { throw null; }
        protected virtual void GetProperties(System.Collections.Hashtable propertyDescriptors) { }
        public virtual bool Remove(string keyword) { throw null; }
        public virtual bool ShouldSerialize(string keyword) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object keyword, object value) { }
        bool System.Collections.IDictionary.Contains(object keyword) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object keyword) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { throw null; }
        System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
        public override string ToString() { throw null; }
        public virtual bool TryGetValue(string keyword, out object value) { value = default(object); throw null; }
    }
    public abstract partial class DbDataAdapter : System.Data.Common.DataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
    {
        public const string DefaultSourceTableName = "Table";
        protected DbDataAdapter() { }
        protected DbDataAdapter(System.Data.Common.DbDataAdapter adapter) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbCommand DeleteCommand { get { throw null; } set { } }
        protected internal System.Data.CommandBehavior FillCommandBehavior { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbCommand InsertCommand { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbCommand SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(1)]
        public virtual int UpdateBatchSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Common.DbCommand UpdateCommand { get { throw null; } set { } }
        protected virtual int AddToBatch(System.Data.IDbCommand command) { throw null; }
        protected virtual void ClearBatch() { }
        protected virtual System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected virtual System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected virtual int ExecuteBatch() { throw null; }
        public override int Fill(System.Data.DataSet dataSet) { throw null; }
        public int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable) { throw null; }
        protected virtual int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        public int Fill(System.Data.DataSet dataSet, string srcTable) { throw null; }
        public int Fill(System.Data.DataTable dataTable) { throw null; }
        protected virtual int Fill(System.Data.DataTable dataTable, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        protected virtual int Fill(System.Data.DataTable[] dataTables, int startRecord, int maxRecords, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        public int Fill(int startRecord, int maxRecords, params System.Data.DataTable[] dataTables) { throw null; }
        public override System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) { throw null; }
        protected virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, System.Data.IDbCommand command, string srcTable, System.Data.CommandBehavior behavior) { throw null; }
        public System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable) { throw null; }
        public System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType) { throw null; }
        protected virtual System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        protected virtual System.Data.IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex) { throw null; }
        protected virtual bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out System.Exception error) { recordsAffected = default(int); error = default(System.Exception); throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public override System.Data.IDataParameter[] GetFillParameters() { throw null; }
        protected virtual void InitializeBatching() { }
        protected virtual void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected virtual void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
        object System.ICloneable.Clone() { throw null; }
        protected virtual void TerminateBatching() { }
        public int Update(System.Data.DataRow[] dataRows) { throw null; }
        protected virtual int Update(System.Data.DataRow[] dataRows, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        public override int Update(System.Data.DataSet dataSet) { throw null; }
        public int Update(System.Data.DataSet dataSet, string srcTable) { throw null; }
        public int Update(System.Data.DataTable dataTable) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, ControlEvidence=true, ControlPolicy=true)]
    [System.SerializableAttribute]
    public abstract partial class DBDataPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        [System.ObsoleteAttribute("DBDataPermission() has been deprecated.  Use the DBDataPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        protected DBDataPermission() { }
        protected DBDataPermission(System.Data.Common.DBDataPermission permission) { }
        protected DBDataPermission(System.Data.Common.DBDataPermissionAttribute permissionAttribute) { }
        protected DBDataPermission(System.Security.Permissions.PermissionState state) { }
        [System.ObsoleteAttribute("DBDataPermission(PermissionState state,Boolean allowBlankPassword) has been deprecated.  Use the DBDataPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        protected DBDataPermission(System.Security.Permissions.PermissionState state, bool allowBlankPassword) { }
        public bool AllowBlankPassword { get { throw null; } set { } }
        public virtual void Add(string connectionString, string restrictions, System.Data.KeyRestrictionBehavior behavior) { }
        protected void Clear() { }
        public override System.Security.IPermission Copy() { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
        protected virtual System.Data.Common.DBDataPermission CreateInstance() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public abstract partial class DBDataPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        protected DBDataPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool AllowBlankPassword { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public System.Data.KeyRestrictionBehavior KeyRestrictionBehavior { get { throw null; } set { } }
        public string KeyRestrictions { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public bool ShouldSerializeConnectionString() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public bool ShouldSerializeKeyRestrictions() { throw null; }
    }
    public abstract partial class DbDataReader : System.MarshalByRefObject, System.Collections.IEnumerable, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable
    {
        protected DbDataReader() { }
        public abstract int Depth { get; }
        public abstract int FieldCount { get; }
        public abstract bool HasRows { get; }
        public abstract bool IsClosed { get; }
        public abstract object this[int ordinal] { get; }
        public abstract object this[string name] { get; }
        public abstract int RecordsAffected { get; }
        public virtual int VisibleFieldCount { get { throw null; } }
        public abstract void Close();
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract bool GetBoolean(int ordinal);
        public abstract byte GetByte(int ordinal);
        public abstract long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length);
        public abstract char GetChar(int ordinal);
        public abstract long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length);
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public System.Data.Common.DbDataReader GetData(int ordinal) { throw null; }
        public abstract string GetDataTypeName(int ordinal);
        public abstract System.DateTime GetDateTime(int ordinal);
        protected virtual System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { throw null; }
        public abstract decimal GetDecimal(int ordinal);
        public abstract double GetDouble(int ordinal);
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract System.Collections.IEnumerator GetEnumerator();
        public abstract System.Type GetFieldType(int ordinal);
        public System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal) { throw null; }
        public virtual System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual T GetFieldValue<T>(int ordinal) { throw null; }
        public abstract float GetFloat(int ordinal);
        public abstract System.Guid GetGuid(int ordinal);
        public abstract short GetInt16(int ordinal);
        public abstract int GetInt32(int ordinal);
        public abstract long GetInt64(int ordinal);
        public abstract string GetName(int ordinal);
        public abstract int GetOrdinal(string name);
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual System.Type GetProviderSpecificFieldType(int ordinal) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual object GetProviderSpecificValue(int ordinal) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual int GetProviderSpecificValues(object[] values) { throw null; }
        public abstract System.Data.DataTable GetSchemaTable();
        public virtual System.IO.Stream GetStream(int ordinal) { throw null; }
        public abstract string GetString(int ordinal);
        public virtual System.IO.TextReader GetTextReader(int ordinal) { throw null; }
        public abstract object GetValue(int ordinal);
        public abstract int GetValues(object[] values);
        public abstract bool IsDBNull(int ordinal);
        public System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal) { throw null; }
        public virtual System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract bool NextResult();
        public System.Threading.Tasks.Task<bool> NextResultAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract bool Read();
        public System.Threading.Tasks.Task<bool> ReadAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { throw null; }
    }
    public abstract partial class DbDataRecord : System.ComponentModel.ICustomTypeDescriptor, System.Data.IDataRecord
    {
        protected DbDataRecord() { }
        public abstract int FieldCount { get; }
        public abstract object this[int i] { get; }
        public abstract object this[string name] { get; }
        public abstract bool GetBoolean(int i);
        public abstract byte GetByte(int i);
        public abstract long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);
        public abstract char GetChar(int i);
        public abstract long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);
        public System.Data.IDataReader GetData(int i) { throw null; }
        public abstract string GetDataTypeName(int i);
        public abstract System.DateTime GetDateTime(int i);
        protected virtual System.Data.Common.DbDataReader GetDbDataReader(int i) { throw null; }
        public abstract decimal GetDecimal(int i);
        public abstract double GetDouble(int i);
        public abstract System.Type GetFieldType(int i);
        public abstract float GetFloat(int i);
        public abstract System.Guid GetGuid(int i);
        public abstract short GetInt16(int i);
        public abstract int GetInt32(int i);
        public abstract long GetInt64(int i);
        public abstract string GetName(int i);
        public abstract int GetOrdinal(string name);
        public abstract string GetString(int i);
        public abstract object GetValue(int i);
        public abstract int GetValues(object[] values);
        public abstract bool IsDBNull(int i);
        System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { throw null; }
        System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
    }
    public abstract partial class DbDataSourceEnumerator
    {
        protected DbDataSourceEnumerator() { }
        public abstract System.Data.DataTable GetDataSources();
    }
    public partial class DbEnumerator : System.Collections.IEnumerator
    {
        public DbEnumerator(System.Data.IDataReader reader) { }
        public DbEnumerator(System.Data.IDataReader reader, bool closeReader) { }
        public object Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public void Reset() { }
    }
    [System.SerializableAttribute]
    public abstract partial class DbException : System.Runtime.InteropServices.ExternalException
    {
        protected DbException() { }
        protected DbException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected DbException(string message) { }
        protected DbException(string message, System.Exception innerException) { }
        protected DbException(string message, int errorCode) { }
    }
    public static partial class DbMetaDataCollectionNames
    {
        public static readonly string DataSourceInformation;
        public static readonly string DataTypes;
        public static readonly string MetaDataCollections;
        public static readonly string ReservedWords;
        public static readonly string Restrictions;
    }
    public static partial class DbMetaDataColumnNames
    {
        public static readonly string CollectionName;
        public static readonly string ColumnSize;
        public static readonly string CompositeIdentifierSeparatorPattern;
        public static readonly string CreateFormat;
        public static readonly string CreateParameters;
        public static readonly string DataSourceProductName;
        public static readonly string DataSourceProductVersion;
        public static readonly string DataSourceProductVersionNormalized;
        public static readonly string DataType;
        public static readonly string GroupByBehavior;
        public static readonly string IdentifierCase;
        public static readonly string IdentifierPattern;
        public static readonly string IsAutoIncrementable;
        public static readonly string IsBestMatch;
        public static readonly string IsCaseSensitive;
        public static readonly string IsConcurrencyType;
        public static readonly string IsFixedLength;
        public static readonly string IsFixedPrecisionScale;
        public static readonly string IsLiteralSupported;
        public static readonly string IsLong;
        public static readonly string IsNullable;
        public static readonly string IsSearchable;
        public static readonly string IsSearchableWithLike;
        public static readonly string IsUnsigned;
        public static readonly string LiteralPrefix;
        public static readonly string LiteralSuffix;
        public static readonly string MaximumScale;
        public static readonly string MinimumScale;
        public static readonly string NumberOfIdentifierParts;
        public static readonly string NumberOfRestrictions;
        public static readonly string OrderByColumnsInSelect;
        public static readonly string ParameterMarkerFormat;
        public static readonly string ParameterMarkerPattern;
        public static readonly string ParameterNameMaxLength;
        public static readonly string ParameterNamePattern;
        public static readonly string ProviderDbType;
        public static readonly string QuotedIdentifierCase;
        public static readonly string QuotedIdentifierPattern;
        public static readonly string ReservedWord;
        public static readonly string StatementSeparatorPattern;
        public static readonly string StringLiteralPattern;
        public static readonly string SupportedJoinOperators;
        public static readonly string TypeName;
    }
    public abstract partial class DbParameter : System.MarshalByRefObject, System.Data.IDataParameter, System.Data.IDbDataParameter
    {
        protected DbParameter() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public abstract System.Data.DbType DbType { get; set; }
        [System.ComponentModel.DefaultValueAttribute((System.Data.ParameterDirection)(1))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public abstract System.Data.ParameterDirection Direction { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract bool IsNullable { get; set; }
        [System.ComponentModel.DefaultValueAttribute("")]
        public abstract string ParameterName { get; set; }
        public abstract int Size { get; set; }
        [System.ComponentModel.DefaultValueAttribute("")]
        public abstract string SourceColumn { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public abstract bool SourceColumnNullMapping { get; set; }
        [System.ComponentModel.DefaultValueAttribute((System.Data.DataRowVersion)(512))]
        public abstract System.Data.DataRowVersion SourceVersion { get; set; }
        byte System.Data.IDbDataParameter.Precision { get { throw null; } set { } }
        byte System.Data.IDbDataParameter.Scale { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public abstract object Value { get; set; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public abstract void ResetDbType();
    }
    public abstract partial class DbParameterCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection
    {
        protected DbParameterCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public abstract int Count { get; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract bool IsFixedSize { get; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract bool IsReadOnly { get; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract bool IsSynchronized { get; }
        public System.Data.Common.DbParameter this[int index] { get { throw null; } set { } }
        public System.Data.Common.DbParameter this[string parameterName] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract object SyncRoot { get; }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        object System.Data.IDataParameterCollection.this[string parameterName] { get { throw null; } set { } }
        public abstract int Add(object value);
        public abstract void AddRange(System.Array values);
        public abstract void Clear();
        public abstract bool Contains(object value);
        public abstract bool Contains(string value);
        public abstract void CopyTo(System.Array array, int index);
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract System.Collections.IEnumerator GetEnumerator();
        protected abstract System.Data.Common.DbParameter GetParameter(int index);
        protected abstract System.Data.Common.DbParameter GetParameter(string parameterName);
        public abstract int IndexOf(object value);
        public abstract int IndexOf(string parameterName);
        public abstract void Insert(int index, object value);
        public abstract void Remove(object value);
        public abstract void RemoveAt(int index);
        public abstract void RemoveAt(string parameterName);
        protected abstract void SetParameter(int index, System.Data.Common.DbParameter value);
        protected abstract void SetParameter(string parameterName, System.Data.Common.DbParameter value);
    }
    public partial class DbProviderConfigurationHandler : System.Configuration.IConfigurationSectionHandler
    {
        public DbProviderConfigurationHandler() { }
        public virtual object Create(object parent, object configContext, System.Xml.XmlNode section) { throw null; }
    }
    public static partial class DbProviderFactories
    {
        public static System.Data.Common.DbProviderFactory GetFactory(System.Data.Common.DbConnection connection) { throw null; }
        public static System.Data.Common.DbProviderFactory GetFactory(System.Data.DataRow providerRow) { throw null; }
        public static System.Data.Common.DbProviderFactory GetFactory(string providerInvariantName) { throw null; }
        public static System.Data.DataTable GetFactoryClasses() { throw null; }
    }
    public partial class DbProviderFactoriesConfigurationHandler : System.Configuration.IConfigurationSectionHandler
    {
        public DbProviderFactoriesConfigurationHandler() { }
        public virtual object Create(object parent, object configContext, System.Xml.XmlNode section) { throw null; }
    }
    public abstract partial class DbProviderFactory
    {
        protected DbProviderFactory() { }
        public virtual bool CanCreateDataSourceEnumerator { get { throw null; } }
        public virtual System.Data.Common.DbCommand CreateCommand() { throw null; }
        public virtual System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public virtual System.Data.Common.DbConnection CreateConnection() { throw null; }
        public virtual System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public virtual System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public virtual System.Data.Common.DbDataSourceEnumerator CreateDataSourceEnumerator() { throw null; }
        public virtual System.Data.Common.DbParameter CreateParameter() { throw null; }
        public virtual System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=true)]
    [System.SerializableAttribute]
    public sealed partial class DbProviderSpecificTypePropertyAttribute : System.Attribute
    {
        public DbProviderSpecificTypePropertyAttribute(bool isProviderSpecificTypeProperty) { }
        public bool IsProviderSpecificTypeProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class DbTransaction : System.MarshalByRefObject, System.Data.IDbTransaction, System.IDisposable
    {
        protected DbTransaction() { }
        public System.Data.Common.DbConnection Connection { get { throw null; } }
        protected abstract System.Data.Common.DbConnection DbConnection { get; }
        public abstract System.Data.IsolationLevel IsolationLevel { get; }
        System.Data.IDbConnection System.Data.IDbTransaction.Connection { get { throw null; } }
        public abstract void Commit();
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract void Rollback();
    }
    public enum GroupByBehavior
    {
        ExactMatch = 4,
        MustContainAll = 3,
        NotSupported = 1,
        Unknown = 0,
        Unrelated = 2,
    }
    public enum IdentifierCase
    {
        Insensitive = 1,
        Sensitive = 2,
        Unknown = 0,
    }
    public partial class RowUpdatedEventArgs : System.EventArgs
    {
        public RowUpdatedEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { }
        public System.Data.IDbCommand Command { get { throw null; } }
        public System.Exception Errors { get { throw null; } set { } }
        public int RecordsAffected { get { throw null; } }
        public System.Data.DataRow Row { get { throw null; } }
        public int RowCount { get { throw null; } }
        public System.Data.StatementType StatementType { get { throw null; } }
        public System.Data.UpdateStatus Status { get { throw null; } set { } }
        public System.Data.Common.DataTableMapping TableMapping { get { throw null; } }
        public void CopyToRows(System.Data.DataRow[] array) { }
        public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) { }
    }
    public partial class RowUpdatingEventArgs : System.EventArgs
    {
        public RowUpdatingEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { }
        protected virtual System.Data.IDbCommand BaseCommand { get { throw null; } set { } }
        public System.Data.IDbCommand Command { get { throw null; } set { } }
        public System.Exception Errors { get { throw null; } set { } }
        public System.Data.DataRow Row { get { throw null; } }
        public System.Data.StatementType StatementType { get { throw null; } }
        public System.Data.UpdateStatus Status { get { throw null; } set { } }
        public System.Data.Common.DataTableMapping TableMapping { get { throw null; } }
    }
    public static partial class SchemaTableColumn
    {
        public static readonly string AllowDBNull;
        public static readonly string BaseColumnName;
        public static readonly string BaseSchemaName;
        public static readonly string BaseTableName;
        public static readonly string ColumnName;
        public static readonly string ColumnOrdinal;
        public static readonly string ColumnSize;
        public static readonly string DataType;
        public static readonly string IsAliased;
        public static readonly string IsExpression;
        public static readonly string IsKey;
        public static readonly string IsLong;
        public static readonly string IsUnique;
        public static readonly string NonVersionedProviderType;
        public static readonly string NumericPrecision;
        public static readonly string NumericScale;
        public static readonly string ProviderType;
    }
    public static partial class SchemaTableOptionalColumn
    {
        public static readonly string AutoIncrementSeed;
        public static readonly string AutoIncrementStep;
        public static readonly string BaseCatalogName;
        public static readonly string BaseColumnNamespace;
        public static readonly string BaseServerName;
        public static readonly string BaseTableNamespace;
        public static readonly string ColumnMapping;
        public static readonly string DefaultValue;
        public static readonly string Expression;
        public static readonly string IsAutoIncrement;
        public static readonly string IsHidden;
        public static readonly string IsReadOnly;
        public static readonly string IsRowVersion;
        public static readonly string ProviderSpecificDataType;
    }
    [System.FlagsAttribute]
    public enum SupportedJoinOperators
    {
        FullOuter = 8,
        Inner = 1,
        LeftOuter = 2,
        None = 0,
        RightOuter = 4,
    }
}
namespace System.Data.Odbc
{
    [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OdbcCommandDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ToolboxItemAttribute(true)]
    public sealed partial class OdbcCommand : System.Data.Common.DbCommand, System.ICloneable
    {
        public OdbcCommand() { }
        public OdbcCommand(string cmdText) { }
        public OdbcCommand(string cmdText, System.Data.Odbc.OdbcConnection connection) { }
        public OdbcCommand(string cmdText, System.Data.Odbc.OdbcConnection connection, System.Data.Odbc.OdbcTransaction transaction) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Odbc.Design.OdbcCommandTextEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override string CommandText { get { throw null; } set { } }
        public override int CommandTimeout { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override System.Data.CommandType CommandType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.Odbc.OdbcConnection Connection { get { throw null; } set { } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } set { } }
        protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { throw null; } }
        protected override System.Data.Common.DbTransaction DbTransaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool DesignTimeVisible { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public new System.Data.Odbc.OdbcParameterCollection Parameters { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.Odbc.OdbcTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
        public override System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public override void Cancel() { }
        protected override System.Data.Common.DbParameter CreateDbParameter() { throw null; }
        public new System.Data.Odbc.OdbcParameter CreateParameter() { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw null; }
        public override int ExecuteNonQuery() { throw null; }
        public new System.Data.Odbc.OdbcDataReader ExecuteReader() { throw null; }
        public new System.Data.Odbc.OdbcDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public override object ExecuteScalar() { throw null; }
        public override void Prepare() { }
        public void ResetCommandTimeout() { }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class OdbcCommandBuilder : System.Data.Common.DbCommandBuilder
    {
        public OdbcCommandBuilder() { }
        public OdbcCommandBuilder(System.Data.Odbc.OdbcDataAdapter adapter) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public new System.Data.Odbc.OdbcDataAdapter DataAdapter { get { throw null; } set { } }
        protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow datarow, System.Data.StatementType statementType, bool whereClause) { }
        public static void DeriveParameters(System.Data.Odbc.OdbcCommand command) { }
        public new System.Data.Odbc.OdbcCommand GetDeleteCommand() { throw null; }
        public new System.Data.Odbc.OdbcCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public new System.Data.Odbc.OdbcCommand GetInsertCommand() { throw null; }
        public new System.Data.Odbc.OdbcCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected override string GetParameterName(int parameterOrdinal) { throw null; }
        protected override string GetParameterName(string parameterName) { throw null; }
        protected override string GetParameterPlaceholder(int parameterOrdinal) { throw null; }
        public new System.Data.Odbc.OdbcCommand GetUpdateCommand() { throw null; }
        public new System.Data.Odbc.OdbcCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        public override string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        public string QuoteIdentifier(string unquotedIdentifier, System.Data.Odbc.OdbcConnection connection) { throw null; }
        protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
        public override string UnquoteIdentifier(string quotedIdentifier) { throw null; }
        public string UnquoteIdentifier(string quotedIdentifier, System.Data.Odbc.OdbcConnection connection) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
    public sealed partial class OdbcConnection : System.Data.Common.DbConnection, System.ICloneable
    {
        public OdbcConnection() { }
        public OdbcConnection(string connectionString) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Odbc.Design.OdbcConnectionStringEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public override string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(15)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new int ConnectionTimeout { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string Database { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string DataSource { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public string Driver { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string ServerVersion { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override System.Data.ConnectionState State { get { throw null; } }
        public event System.Data.Odbc.OdbcInfoMessageEventHandler InfoMessage { add { } remove { } }
        protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public new System.Data.Odbc.OdbcTransaction BeginTransaction() { throw null; }
        public new System.Data.Odbc.OdbcTransaction BeginTransaction(System.Data.IsolationLevel isolevel) { throw null; }
        public override void ChangeDatabase(string value) { }
        public override void Close() { }
        public new System.Data.Odbc.OdbcCommand CreateCommand() { throw null; }
        protected override System.Data.Common.DbCommand CreateDbCommand() { throw null; }
        protected override void Dispose(bool disposing) { }
        public void EnlistDistributedTransaction(System.EnterpriseServices.ITransaction transaction) { }
        public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public override System.Data.DataTable GetSchema() { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        public override void Open() { }
        public static void ReleaseObjectPool() { }
        object System.ICloneable.Clone() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Driver")]
    [System.ComponentModel.TypeConverterAttribute("System.Data.Odbc.OdbcConnectionStringBuilder.OdbcConnectionStringBuilderConverter")]
    public sealed partial class OdbcConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
    {
        public OdbcConnectionStringBuilder() { }
        public OdbcConnectionStringBuilder(string connectionString) { }
        [System.ComponentModel.DisplayNameAttribute("Driver")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string Driver { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Dsn")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string Dsn { get { throw null; } set { } }
        public override object this[string keyword] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        public override void Clear() { }
        public override bool ContainsKey(string keyword) { throw null; }
        public override bool Remove(string keyword) { throw null; }
        public override bool TryGetValue(string keyword, out object value) { value = default(object); throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("RowUpdated")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OdbcDataAdapterDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.OdbcDataAdapterToolboxItem, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class OdbcDataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
    {
        public OdbcDataAdapter() { }
        public OdbcDataAdapter(System.Data.Odbc.OdbcCommand selectCommand) { }
        public OdbcDataAdapter(string selectCommandText, System.Data.Odbc.OdbcConnection selectConnection) { }
        public OdbcDataAdapter(string selectCommandText, string selectConnectionString) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.Odbc.OdbcCommand DeleteCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.Odbc.OdbcCommand InsertCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.Odbc.OdbcCommand SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.Odbc.OdbcCommand UpdateCommand { get { throw null; } set { } }
        public event System.Data.Odbc.OdbcRowUpdatedEventHandler RowUpdated { add { } remove { } }
        public event System.Data.Odbc.OdbcRowUpdatingEventHandler RowUpdating { add { } remove { } }
        protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class OdbcDataReader : System.Data.Common.DbDataReader
    {
        internal OdbcDataReader() { }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int i] { get { throw null; } }
        public override object this[string value] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override bool GetBoolean(int i) { throw null; }
        public override byte GetByte(int i) { throw null; }
        public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw null; }
        public override char GetChar(int i) { throw null; }
        public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length) { throw null; }
        public override string GetDataTypeName(int i) { throw null; }
        public System.DateTime GetDate(int i) { throw null; }
        public override System.DateTime GetDateTime(int i) { throw null; }
        public override decimal GetDecimal(int i) { throw null; }
        public override double GetDouble(int i) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int i) { throw null; }
        public override float GetFloat(int i) { throw null; }
        public override System.Guid GetGuid(int i) { throw null; }
        public override short GetInt16(int i) { throw null; }
        public override int GetInt32(int i) { throw null; }
        public override long GetInt64(int i) { throw null; }
        public override string GetName(int i) { throw null; }
        public override int GetOrdinal(string value) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int i) { throw null; }
        public System.TimeSpan GetTime(int i) { throw null; }
        public override object GetValue(int i) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int i) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class OdbcError
    {
        internal OdbcError() { }
        public string Message { get { throw null; } }
        public int NativeError { get { throw null; } }
        public string Source { get { throw null; } }
        public string SQLState { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class OdbcErrorCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal OdbcErrorCollection() { }
        public int Count { get { throw null; } }
        public System.Data.Odbc.OdbcError this[int i] { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void CopyTo(System.Array array, int i) { }
        public void CopyTo(System.Data.Odbc.OdbcError[] array, int i) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class OdbcException : System.Data.Common.DbException
    {
        internal OdbcException() { }
        public System.Data.Odbc.OdbcErrorCollection Errors { get { throw null; } }
        public override string Source { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class OdbcFactory : System.Data.Common.DbProviderFactory
    {
        internal OdbcFactory() { }
        public static readonly System.Data.Odbc.OdbcFactory Instance;
        public override System.Data.Common.DbCommand CreateCommand() { throw null; }
        public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public override System.Data.Common.DbConnection CreateConnection() { throw null; }
        public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public override System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public override System.Data.Common.DbParameter CreateParameter() { throw null; }
        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
    }
    public sealed partial class OdbcInfoMessageEventArgs : System.EventArgs
    {
        internal OdbcInfoMessageEventArgs() { }
        public System.Data.Odbc.OdbcErrorCollection Errors { get { throw null; } }
        public string Message { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public delegate void OdbcInfoMessageEventHandler(object sender, System.Data.Odbc.OdbcInfoMessageEventArgs e);
    public static partial class OdbcMetaDataCollectionNames
    {
        public static readonly string Columns;
        public static readonly string Indexes;
        public static readonly string ProcedureColumns;
        public static readonly string ProcedureParameters;
        public static readonly string Procedures;
        public static readonly string Tables;
        public static readonly string Views;
    }
    public static partial class OdbcMetaDataColumnNames
    {
        public static readonly string BooleanFalseLiteral;
        public static readonly string BooleanTrueLiteral;
        public static readonly string SQLType;
    }
    [System.ComponentModel.TypeConverterAttribute("System.Data.Odbc.OdbcParameter.OdbcParameterConverter")]
    public sealed partial class OdbcParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable
    {
        public OdbcParameter() { }
        public OdbcParameter(string name, System.Data.Odbc.OdbcType type) { }
        public OdbcParameter(string name, System.Data.Odbc.OdbcType type, int size) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public OdbcParameter(string parameterName, System.Data.Odbc.OdbcType odbcType, int size, System.Data.ParameterDirection parameterDirection, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public OdbcParameter(string parameterName, System.Data.Odbc.OdbcType odbcType, int size, System.Data.ParameterDirection parameterDirection, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value) { }
        public OdbcParameter(string name, System.Data.Odbc.OdbcType type, int size, string sourcecolumn) { }
        public OdbcParameter(string name, object value) { }
        public override System.Data.DbType DbType { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public override bool IsNullable { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.Odbc.OdbcType)(11))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.Data.Common.DbProviderSpecificTypePropertyAttribute(true)]
        public System.Data.Odbc.OdbcType OdbcType { get { throw null; } set { } }
        public override string ParameterName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((byte)0)]
        public byte Precision { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((byte)0)]
        public byte Scale { get { throw null; } set { } }
        public override int Size { get { throw null; } set { } }
        public override string SourceColumn { get { throw null; } set { } }
        public override bool SourceColumnNullMapping { get { throw null; } set { } }
        public override System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
        public override object Value { get { throw null; } set { } }
        public override void ResetDbType() { }
        public void ResetOdbcType() { }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class OdbcParameterCollection : System.Data.Common.DbParameterCollection
    {
        internal OdbcParameterCollection() { }
        public override int Count { get { throw null; } }
        public override bool IsFixedSize { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.Odbc.OdbcParameter this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.Odbc.OdbcParameter this[string parameterName] { get { throw null; } set { } }
        public override object SyncRoot { get { throw null; } }
        public System.Data.Odbc.OdbcParameter Add(System.Data.Odbc.OdbcParameter value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override int Add(object value) { throw null; }
        public System.Data.Odbc.OdbcParameter Add(string parameterName, System.Data.Odbc.OdbcType odbcType) { throw null; }
        public System.Data.Odbc.OdbcParameter Add(string parameterName, System.Data.Odbc.OdbcType odbcType, int size) { throw null; }
        public System.Data.Odbc.OdbcParameter Add(string parameterName, System.Data.Odbc.OdbcType odbcType, int size, string sourceColumn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Add(String parameterName, Object value) has been deprecated.  Use AddWithValue(String parameterName, Object value).  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public System.Data.Odbc.OdbcParameter Add(string parameterName, object value) { throw null; }
        public override void AddRange(System.Array values) { }
        public void AddRange(System.Data.Odbc.OdbcParameter[] values) { }
        public System.Data.Odbc.OdbcParameter AddWithValue(string parameterName, object value) { throw null; }
        public override void Clear() { }
        public bool Contains(System.Data.Odbc.OdbcParameter value) { throw null; }
        public override bool Contains(object value) { throw null; }
        public override bool Contains(string value) { throw null; }
        public override void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.Odbc.OdbcParameter[] array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(int index) { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw null; }
        public int IndexOf(System.Data.Odbc.OdbcParameter value) { throw null; }
        public override int IndexOf(object value) { throw null; }
        public override int IndexOf(string parameterName) { throw null; }
        public void Insert(int index, System.Data.Odbc.OdbcParameter value) { }
        public override void Insert(int index, object value) { }
        public void Remove(System.Data.Odbc.OdbcParameter value) { }
        public override void Remove(object value) { }
        public override void RemoveAt(int index) { }
        public override void RemoveAt(string parameterName) { }
        protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
        protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
    }
    [System.SerializableAttribute]
    public sealed partial class OdbcPermission : System.Data.Common.DBDataPermission
    {
        [System.ObsoleteAttribute("OdbcPermission() has been deprecated.  Use the OdbcPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        public OdbcPermission() : base (default(System.Security.Permissions.PermissionState)) { }
        public OdbcPermission(System.Security.Permissions.PermissionState state) : base (default(System.Security.Permissions.PermissionState)) { }
        [System.ObsoleteAttribute("OdbcPermission(PermissionState state, Boolean allowBlankPassword) has been deprecated.  Use the OdbcPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        public OdbcPermission(System.Security.Permissions.PermissionState state, bool allowBlankPassword) : base (default(System.Security.Permissions.PermissionState)) { }
        public override void Add(string connectionString, string restrictions, System.Data.KeyRestrictionBehavior behavior) { }
        public override System.Security.IPermission Copy() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class OdbcPermissionAttribute : System.Data.Common.DBDataPermissionAttribute
    {
        public OdbcPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public sealed partial class OdbcRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs
    {
        public OdbcRowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        public new System.Data.Odbc.OdbcCommand Command { get { throw null; } }
    }
    public delegate void OdbcRowUpdatedEventHandler(object sender, System.Data.Odbc.OdbcRowUpdatedEventArgs e);
    public sealed partial class OdbcRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs
    {
        public OdbcRowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        protected override System.Data.IDbCommand BaseCommand { get { throw null; } set { } }
        public new System.Data.Odbc.OdbcCommand Command { get { throw null; } set { } }
    }
    public delegate void OdbcRowUpdatingEventHandler(object sender, System.Data.Odbc.OdbcRowUpdatingEventArgs e);
    public sealed partial class OdbcTransaction : System.Data.Common.DbTransaction
    {
        internal OdbcTransaction() { }
        public new System.Data.Odbc.OdbcConnection Connection { get { throw null; } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } }
        public override System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public override void Commit() { }
        protected override void Dispose(bool disposing) { }
        public override void Rollback() { }
    }
    public enum OdbcType
    {
        BigInt = 1,
        Binary = 2,
        Bit = 3,
        Char = 4,
        Date = 23,
        DateTime = 5,
        Decimal = 6,
        Double = 8,
        Image = 9,
        Int = 10,
        NChar = 11,
        NText = 12,
        Numeric = 7,
        NVarChar = 13,
        Real = 14,
        SmallDateTime = 16,
        SmallInt = 17,
        Text = 18,
        Time = 24,
        Timestamp = 19,
        TinyInt = 20,
        UniqueIdentifier = 15,
        VarBinary = 21,
        VarChar = 22,
    }
}
namespace System.Data.OleDb
{
    [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OleDbCommandDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ToolboxItemAttribute(true)]
    public sealed partial class OleDbCommand : System.Data.Common.DbCommand, System.Data.IDbCommand, System.ICloneable, System.IDisposable
    {
        public OleDbCommand() { }
        public OleDbCommand(string cmdText) { }
        public OleDbCommand(string cmdText, System.Data.OleDb.OleDbConnection connection) { }
        public OleDbCommand(string cmdText, System.Data.OleDb.OleDbConnection connection, System.Data.OleDb.OleDbTransaction transaction) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.ADO.Design.OleDbCommandTextEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override string CommandText { get { throw null; } set { } }
        public override int CommandTimeout { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override System.Data.CommandType CommandType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OleDb.OleDbConnection Connection { get { throw null; } set { } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } set { } }
        protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { throw null; } }
        protected override System.Data.Common.DbTransaction DbTransaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool DesignTimeVisible { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public new System.Data.OleDb.OleDbParameterCollection Parameters { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.OleDb.OleDbTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
        public override System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public override void Cancel() { }
        public System.Data.OleDb.OleDbCommand Clone() { throw null; }
        protected override System.Data.Common.DbParameter CreateDbParameter() { throw null; }
        public new System.Data.OleDb.OleDbParameter CreateParameter() { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw null; }
        public override int ExecuteNonQuery() { throw null; }
        public new System.Data.OleDb.OleDbDataReader ExecuteReader() { throw null; }
        public new System.Data.OleDb.OleDbDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public override object ExecuteScalar() { throw null; }
        public override void Prepare() { }
        public void ResetCommandTimeout() { }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { throw null; }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class OleDbCommandBuilder : System.Data.Common.DbCommandBuilder
    {
        public OleDbCommandBuilder() { }
        public OleDbCommandBuilder(System.Data.OleDb.OleDbDataAdapter adapter) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public new System.Data.OleDb.OleDbDataAdapter DataAdapter { get { throw null; } set { } }
        protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow datarow, System.Data.StatementType statementType, bool whereClause) { }
        public static void DeriveParameters(System.Data.OleDb.OleDbCommand command) { }
        public new System.Data.OleDb.OleDbCommand GetDeleteCommand() { throw null; }
        public new System.Data.OleDb.OleDbCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public new System.Data.OleDb.OleDbCommand GetInsertCommand() { throw null; }
        public new System.Data.OleDb.OleDbCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected override string GetParameterName(int parameterOrdinal) { throw null; }
        protected override string GetParameterName(string parameterName) { throw null; }
        protected override string GetParameterPlaceholder(int parameterOrdinal) { throw null; }
        public new System.Data.OleDb.OleDbCommand GetUpdateCommand() { throw null; }
        public new System.Data.OleDb.OleDbCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        public override string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        public string QuoteIdentifier(string unquotedIdentifier, System.Data.OleDb.OleDbConnection connection) { throw null; }
        protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
        public override string UnquoteIdentifier(string quotedIdentifier) { throw null; }
        public string UnquoteIdentifier(string quotedIdentifier, System.Data.OleDb.OleDbConnection connection) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
    public sealed partial class OleDbConnection : System.Data.Common.DbConnection, System.Data.IDbConnection, System.ICloneable, System.IDisposable
    {
        public OleDbConnection() { }
        public OleDbConnection(string connectionString) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.ADO.Design.OleDbConnectionStringEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public override string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override int ConnectionTimeout { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string Database { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        public override string DataSource { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public string Provider { get { throw null; } }
        public override string ServerVersion { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override System.Data.ConnectionState State { get { throw null; } }
        public event System.Data.OleDb.OleDbInfoMessageEventHandler InfoMessage { add { } remove { } }
        protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public new System.Data.OleDb.OleDbTransaction BeginTransaction() { throw null; }
        public new System.Data.OleDb.OleDbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public override void ChangeDatabase(string value) { }
        public override void Close() { }
        public new System.Data.OleDb.OleDbCommand CreateCommand() { throw null; }
        protected override System.Data.Common.DbCommand CreateDbCommand() { throw null; }
        protected override void Dispose(bool disposing) { }
        public void EnlistDistributedTransaction(System.EnterpriseServices.ITransaction transaction) { }
        public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public System.Data.DataTable GetOleDbSchemaTable(System.Guid schema, object[] restrictions) { throw null; }
        public override System.Data.DataTable GetSchema() { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        public override void Open() { }
        public static void ReleaseObjectPool() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public void ResetState() { }
        object System.ICloneable.Clone() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Provider")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute("System.Data.OleDb.OleDbConnectionStringBuilder.OleDbConnectionStringBuilderConverter")]
    public sealed partial class OleDbConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
    {
        public OleDbConnectionStringBuilder() { }
        public OleDbConnectionStringBuilder(string connectionString) { }
        [System.ComponentModel.DisplayNameAttribute("Data Source")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string DataSource { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("File Name")]
        [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string FileName { get { throw null; } set { } }
        public override object this[string keyword] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        [System.ComponentModel.DisplayNameAttribute("OLE DB Services")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.OleDb.OleDbConnectionStringBuilder.OleDbServicesConverter")]
        public int OleDbServices { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Persist Security Info")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool PersistSecurityInfo { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Provider")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.OleDb.OleDbConnectionStringBuilder.OleDbProviderConverter")]
        public string Provider { get { throw null; } set { } }
        public override void Clear() { }
        public override bool ContainsKey(string keyword) { throw null; }
        protected override void GetProperties(System.Collections.Hashtable propertyDescriptors) { }
        public override bool Remove(string keyword) { throw null; }
        public override bool TryGetValue(string keyword, out object value) { value = default(object); throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("RowUpdated")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OleDbDataAdapterDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.OleDbDataAdapterToolboxItem, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class OleDbDataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
    {
        public OleDbDataAdapter() { }
        public OleDbDataAdapter(System.Data.OleDb.OleDbCommand selectCommand) { }
        public OleDbDataAdapter(string selectCommandText, System.Data.OleDb.OleDbConnection selectConnection) { }
        public OleDbDataAdapter(string selectCommandText, string selectConnectionString) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OleDb.OleDbCommand DeleteCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OleDb.OleDbCommand InsertCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OleDb.OleDbCommand SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OleDb.OleDbCommand UpdateCommand { get { throw null; } set { } }
        public event System.Data.OleDb.OleDbRowUpdatedEventHandler RowUpdated { add { } remove { } }
        public event System.Data.OleDb.OleDbRowUpdatingEventHandler RowUpdating { add { } remove { } }
        protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        public int Fill(System.Data.DataSet dataSet, object ADODBRecordSet, string srcTable) { throw null; }
        public int Fill(System.Data.DataTable dataTable, object ADODBRecordSet) { throw null; }
        protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class OleDbDataReader : System.Data.Common.DbDataReader
    {
        internal OleDbDataReader() { }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int index] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override int VisibleFieldCount { get { throw null; } }
        public override void Close() { }
        public override bool GetBoolean(int ordinal) { throw null; }
        public override byte GetByte(int ordinal) { throw null; }
        public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override char GetChar(int ordinal) { throw null; }
        public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public new System.Data.OleDb.OleDbDataReader GetData(int ordinal) { throw null; }
        public override string GetDataTypeName(int index) { throw null; }
        public override System.DateTime GetDateTime(int ordinal) { throw null; }
        protected override System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { throw null; }
        public override decimal GetDecimal(int ordinal) { throw null; }
        public override double GetDouble(int ordinal) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int index) { throw null; }
        public override float GetFloat(int ordinal) { throw null; }
        public override System.Guid GetGuid(int ordinal) { throw null; }
        public override short GetInt16(int ordinal) { throw null; }
        public override int GetInt32(int ordinal) { throw null; }
        public override long GetInt64(int ordinal) { throw null; }
        public override string GetName(int index) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int ordinal) { throw null; }
        public System.TimeSpan GetTimeSpan(int ordinal) { throw null; }
        public override object GetValue(int ordinal) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int ordinal) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    public sealed partial class OleDbEnumerator
    {
        public OleDbEnumerator() { }
        public System.Data.DataTable GetElements() { throw null; }
        public static System.Data.OleDb.OleDbDataReader GetEnumerator(System.Type type) { throw null; }
        public static System.Data.OleDb.OleDbDataReader GetRootEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class OleDbError
    {
        internal OleDbError() { }
        public string Message { get { throw null; } }
        public int NativeError { get { throw null; } }
        public string Source { get { throw null; } }
        public string SQLState { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.ListBindableAttribute(false)]
    [System.SerializableAttribute]
    public sealed partial class OleDbErrorCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal OleDbErrorCollection() { }
        public int Count { get { throw null; } }
        public System.Data.OleDb.OleDbError this[int index] { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.OleDb.OleDbError[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class OleDbException : System.Data.Common.DbException
    {
        internal OleDbException() { }
        [System.ComponentModel.TypeConverterAttribute("System.Data.OleDb.OleDbException.ErrorCodeConverter")]
        public override int ErrorCode { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.OleDb.OleDbErrorCollection Errors { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class OleDbFactory : System.Data.Common.DbProviderFactory
    {
        internal OleDbFactory() { }
        public static readonly System.Data.OleDb.OleDbFactory Instance;
        public override System.Data.Common.DbCommand CreateCommand() { throw null; }
        public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public override System.Data.Common.DbConnection CreateConnection() { throw null; }
        public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public override System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public override System.Data.Common.DbParameter CreateParameter() { throw null; }
        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
    }
    public sealed partial class OleDbInfoMessageEventArgs : System.EventArgs
    {
        internal OleDbInfoMessageEventArgs() { }
        public int ErrorCode { get { throw null; } }
        public System.Data.OleDb.OleDbErrorCollection Errors { get { throw null; } }
        public string Message { get { throw null; } }
        public string Source { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public delegate void OleDbInfoMessageEventHandler(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e);
    public enum OleDbLiteral
    {
        Binary_Literal = 1,
        Catalog_Name = 2,
        Catalog_Separator = 3,
        Char_Literal = 4,
        Column_Alias = 5,
        Column_Name = 6,
        Correlation_Name = 7,
        Cube_Name = 21,
        Cursor_Name = 8,
        Dimension_Name = 22,
        Escape_Percent_Prefix = 9,
        Escape_Percent_Suffix = 29,
        Escape_Underscore_Prefix = 10,
        Escape_Underscore_Suffix = 30,
        Hierarchy_Name = 23,
        Index_Name = 11,
        Invalid = 0,
        Level_Name = 24,
        Like_Percent = 12,
        Like_Underscore = 13,
        Member_Name = 25,
        Procedure_Name = 14,
        Property_Name = 26,
        Quote_Prefix = 15,
        Quote_Suffix = 28,
        Schema_Name = 16,
        Schema_Separator = 27,
        Table_Name = 17,
        Text_Command = 18,
        User_Name = 19,
        View_Name = 20,
    }
    public static partial class OleDbMetaDataCollectionNames
    {
        public static readonly string Catalogs;
        public static readonly string Collations;
        public static readonly string Columns;
        public static readonly string Indexes;
        public static readonly string ProcedureColumns;
        public static readonly string ProcedureParameters;
        public static readonly string Procedures;
        public static readonly string Tables;
        public static readonly string Views;
    }
    public static partial class OleDbMetaDataColumnNames
    {
        public static readonly string BooleanFalseLiteral;
        public static readonly string BooleanTrueLiteral;
        public static readonly string DateTimeDigits;
        public static readonly string NativeDataType;
    }
    [System.ComponentModel.TypeConverterAttribute("System.Data.OleDb.OleDbParameter.OleDbParameterConverter")]
    public sealed partial class OleDbParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable
    {
        public OleDbParameter() { }
        public OleDbParameter(string name, System.Data.OleDb.OleDbType dataType) { }
        public OleDbParameter(string name, System.Data.OleDb.OleDbType dataType, int size) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public OleDbParameter(string parameterName, System.Data.OleDb.OleDbType dbType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public OleDbParameter(string parameterName, System.Data.OleDb.OleDbType dbType, int size, System.Data.ParameterDirection direction, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value) { }
        public OleDbParameter(string name, System.Data.OleDb.OleDbType dataType, int size, string srcColumn) { }
        public OleDbParameter(string name, object value) { }
        public override System.Data.DbType DbType { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public override bool IsNullable { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.Data.Common.DbProviderSpecificTypePropertyAttribute(true)]
        public System.Data.OleDb.OleDbType OleDbType { get { throw null; } set { } }
        public override string ParameterName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((byte)0)]
        public byte Precision { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((byte)0)]
        public byte Scale { get { throw null; } set { } }
        public override int Size { get { throw null; } set { } }
        public override string SourceColumn { get { throw null; } set { } }
        public override bool SourceColumnNullMapping { get { throw null; } set { } }
        public override System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
        public override object Value { get { throw null; } set { } }
        public override void ResetDbType() { }
        public void ResetOleDbType() { }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class OleDbParameterCollection : System.Data.Common.DbParameterCollection
    {
        internal OleDbParameterCollection() { }
        public override int Count { get { throw null; } }
        public override bool IsFixedSize { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.OleDb.OleDbParameter this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.OleDb.OleDbParameter this[string parameterName] { get { throw null; } set { } }
        public override object SyncRoot { get { throw null; } }
        public System.Data.OleDb.OleDbParameter Add(System.Data.OleDb.OleDbParameter value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override int Add(object value) { throw null; }
        public System.Data.OleDb.OleDbParameter Add(string parameterName, System.Data.OleDb.OleDbType oleDbType) { throw null; }
        public System.Data.OleDb.OleDbParameter Add(string parameterName, System.Data.OleDb.OleDbType oleDbType, int size) { throw null; }
        public System.Data.OleDb.OleDbParameter Add(string parameterName, System.Data.OleDb.OleDbType oleDbType, int size, string sourceColumn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Add(String parameterName, Object value) has been deprecated.  Use AddWithValue(String parameterName, Object value).  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public System.Data.OleDb.OleDbParameter Add(string parameterName, object value) { throw null; }
        public override void AddRange(System.Array values) { }
        public void AddRange(System.Data.OleDb.OleDbParameter[] values) { }
        public System.Data.OleDb.OleDbParameter AddWithValue(string parameterName, object value) { throw null; }
        public override void Clear() { }
        public bool Contains(System.Data.OleDb.OleDbParameter value) { throw null; }
        public override bool Contains(object value) { throw null; }
        public override bool Contains(string value) { throw null; }
        public override void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.OleDb.OleDbParameter[] array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(int index) { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw null; }
        public int IndexOf(System.Data.OleDb.OleDbParameter value) { throw null; }
        public override int IndexOf(object value) { throw null; }
        public override int IndexOf(string parameterName) { throw null; }
        public void Insert(int index, System.Data.OleDb.OleDbParameter value) { }
        public override void Insert(int index, object value) { }
        public void Remove(System.Data.OleDb.OleDbParameter value) { }
        public override void Remove(object value) { }
        public override void RemoveAt(int index) { }
        public override void RemoveAt(string parameterName) { }
        protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
        protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
    }
    [System.SerializableAttribute]
    public sealed partial class OleDbPermission : System.Data.Common.DBDataPermission
    {
        [System.ObsoleteAttribute("OleDbPermission() has been deprecated.  Use the OleDbPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        public OleDbPermission() : base (default(System.Security.Permissions.PermissionState)) { }
        public OleDbPermission(System.Security.Permissions.PermissionState state) : base (default(System.Security.Permissions.PermissionState)) { }
        [System.ObsoleteAttribute("OleDbPermission(PermissionState state, Boolean allowBlankPassword) has been deprecated.  Use the OleDbPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        public OleDbPermission(System.Security.Permissions.PermissionState state, bool allowBlankPassword) : base (default(System.Security.Permissions.PermissionState)) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Provider property has been deprecated.  Use the Add method.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public string Provider { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class OleDbPermissionAttribute : System.Data.Common.DBDataPermissionAttribute
    {
        public OleDbPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Provider property has been deprecated.  Use the Add method.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public string Provider { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public sealed partial class OleDbRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs
    {
        public OleDbRowUpdatedEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        public new System.Data.OleDb.OleDbCommand Command { get { throw null; } }
    }
    public delegate void OleDbRowUpdatedEventHandler(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e);
    public sealed partial class OleDbRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs
    {
        public OleDbRowUpdatingEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        protected override System.Data.IDbCommand BaseCommand { get { throw null; } set { } }
        public new System.Data.OleDb.OleDbCommand Command { get { throw null; } set { } }
    }
    public delegate void OleDbRowUpdatingEventHandler(object sender, System.Data.OleDb.OleDbRowUpdatingEventArgs e);
    public sealed partial class OleDbSchemaGuid
    {
        public static readonly System.Guid Assertions;
        public static readonly System.Guid Catalogs;
        public static readonly System.Guid Character_Sets;
        public static readonly System.Guid Check_Constraints;
        public static readonly System.Guid Check_Constraints_By_Table;
        public static readonly System.Guid Collations;
        public static readonly System.Guid Columns;
        public static readonly System.Guid Column_Domain_Usage;
        public static readonly System.Guid Column_Privileges;
        public static readonly System.Guid Constraint_Column_Usage;
        public static readonly System.Guid Constraint_Table_Usage;
        public static readonly System.Guid DbInfoKeywords;
        public static readonly System.Guid DbInfoLiterals;
        public static readonly System.Guid Foreign_Keys;
        public static readonly System.Guid Indexes;
        public static readonly System.Guid Key_Column_Usage;
        public static readonly System.Guid Primary_Keys;
        public static readonly System.Guid Procedures;
        public static readonly System.Guid Procedure_Columns;
        public static readonly System.Guid Procedure_Parameters;
        public static readonly System.Guid Provider_Types;
        public static readonly System.Guid Referential_Constraints;
        public static readonly System.Guid SchemaGuids;
        public static readonly System.Guid Schemata;
        public static readonly System.Guid Sql_Languages;
        public static readonly System.Guid Statistics;
        public static readonly System.Guid Tables;
        public static readonly System.Guid Tables_Info;
        public static readonly System.Guid Table_Constraints;
        public static readonly System.Guid Table_Privileges;
        public static readonly System.Guid Table_Statistics;
        public static readonly System.Guid Translations;
        public static readonly System.Guid Trustee;
        public static readonly System.Guid Usage_Privileges;
        public static readonly System.Guid Views;
        public static readonly System.Guid View_Column_Usage;
        public static readonly System.Guid View_Table_Usage;
        public OleDbSchemaGuid() { }
    }
    public sealed partial class OleDbTransaction : System.Data.Common.DbTransaction
    {
        internal OleDbTransaction() { }
        public new System.Data.OleDb.OleDbConnection Connection { get { throw null; } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } }
        public override System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public System.Data.OleDb.OleDbTransaction Begin() { throw null; }
        public System.Data.OleDb.OleDbTransaction Begin(System.Data.IsolationLevel isolevel) { throw null; }
        public override void Commit() { }
        protected override void Dispose(bool disposing) { }
        public override void Rollback() { }
    }
    public enum OleDbType
    {
        BigInt = 20,
        Binary = 128,
        Boolean = 11,
        BSTR = 8,
        Char = 129,
        Currency = 6,
        Date = 7,
        DBDate = 133,
        DBTime = 134,
        DBTimeStamp = 135,
        Decimal = 14,
        Double = 5,
        Empty = 0,
        Error = 10,
        Filetime = 64,
        Guid = 72,
        IDispatch = 9,
        Integer = 3,
        IUnknown = 13,
        LongVarBinary = 205,
        LongVarChar = 201,
        LongVarWChar = 203,
        Numeric = 131,
        PropVariant = 138,
        Single = 4,
        SmallInt = 2,
        TinyInt = 16,
        UnsignedBigInt = 21,
        UnsignedInt = 19,
        UnsignedSmallInt = 18,
        UnsignedTinyInt = 17,
        VarBinary = 204,
        VarChar = 200,
        Variant = 12,
        VarNumeric = 139,
        VarWChar = 202,
        WChar = 130,
    }
}
namespace System.Data.Sql
{
    public sealed partial class SqlDataSourceEnumerator : System.Data.Common.DbDataSourceEnumerator
    {
        internal SqlDataSourceEnumerator() { }
        public static System.Data.Sql.SqlDataSourceEnumerator Instance { get { throw null; } }
        public override System.Data.DataTable GetDataSources() { throw null; }
    }
    public sealed partial class SqlNotificationRequest
    {
        public SqlNotificationRequest() { }
        public SqlNotificationRequest(string userData, string options, int timeout) { }
        public string Options { get { throw null; } set { } }
        public int Timeout { get { throw null; } set { } }
        public string UserData { get { throw null; } set { } }
    }
}
namespace System.Data.SqlClient
{
    [System.SerializableAttribute]
    public enum ApplicationIntent
    {
        ReadOnly = 1,
        ReadWrite = 0,
    }
    public delegate void OnChangeEventHandler(object sender, System.Data.SqlClient.SqlNotificationEventArgs e);
    public enum SortOrder
    {
        Ascending = 0,
        Descending = 1,
        Unspecified = -1,
    }
    public sealed partial class SqlBulkCopy : System.IDisposable
    {
        public SqlBulkCopy(System.Data.SqlClient.SqlConnection connection) { }
        [System.MonoTODOAttribute]
        public SqlBulkCopy(System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlBulkCopyOptions copyOptions, System.Data.SqlClient.SqlTransaction externalTransaction) { }
        public SqlBulkCopy(string connectionString) { }
        [System.MonoTODOAttribute]
        public SqlBulkCopy(string connectionString, System.Data.SqlClient.SqlBulkCopyOptions copyOptions) { }
        public int BatchSize { get { throw null; } set { } }
        public int BulkCopyTimeout { get { throw null; } set { } }
        public System.Data.SqlClient.SqlBulkCopyColumnMappingCollection ColumnMappings { get { throw null; } }
        public string DestinationTableName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool EnableStreaming { get { throw null; } set { } }
        public int NotifyAfter { get { throw null; } set { } }
        public event System.Data.SqlClient.SqlRowsCopiedEventHandler SqlRowsCopied { add { } remove { } }
        public void Close() { }
        void System.IDisposable.Dispose() { }
        public void WriteToServer(System.Data.DataRow[] rows) { }
        public void WriteToServer(System.Data.DataTable table) { }
        public void WriteToServer(System.Data.DataTable table, System.Data.DataRowState rowState) { }
        public void WriteToServer(System.Data.IDataReader reader) { }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.DataRow[] rows) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.DataRow[] rows, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.DataTable table) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.DataTable table, System.Data.DataRowState rowState) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.DataTable table, System.Data.DataRowState rowState, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.DataTable table, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.IDataReader reader) { throw null; }
        public System.Threading.Tasks.Task WriteToServerAsync(System.Data.IDataReader reader, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class SqlBulkCopyColumnMapping
    {
        public SqlBulkCopyColumnMapping() { }
        public SqlBulkCopyColumnMapping(int sourceColumnOrdinal, int destinationOrdinal) { }
        public SqlBulkCopyColumnMapping(int sourceColumnOrdinal, string destinationColumn) { }
        public SqlBulkCopyColumnMapping(string sourceColumn, int destinationOrdinal) { }
        public SqlBulkCopyColumnMapping(string sourceColumn, string destinationColumn) { }
        public string DestinationColumn { get { throw null; } set { } }
        public int DestinationOrdinal { get { throw null; } set { } }
        public string SourceColumn { get { throw null; } set { } }
        public int SourceOrdinal { get { throw null; } set { } }
    }
    public sealed partial class SqlBulkCopyColumnMappingCollection : System.Collections.CollectionBase
    {
        internal SqlBulkCopyColumnMappingCollection() { }
        public System.Data.SqlClient.SqlBulkCopyColumnMapping this[int index] { get { throw null; } }
        public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(System.Data.SqlClient.SqlBulkCopyColumnMapping bulkCopyColumnMapping) { throw null; }
        public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(int sourceColumnIndex, int destinationColumnIndex) { throw null; }
        public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(int sourceColumnIndex, string destinationColumn) { throw null; }
        public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(string sourceColumn, int destinationColumnIndex) { throw null; }
        public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(string sourceColumn, string destinationColumn) { throw null; }
        public new void Clear() { }
        public bool Contains(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { throw null; }
        public void CopyTo(System.Data.SqlClient.SqlBulkCopyColumnMapping[] array, int index) { }
        public int IndexOf(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { throw null; }
        public void Insert(int index, System.Data.SqlClient.SqlBulkCopyColumnMapping value) { }
        public void Remove(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { }
        public new void RemoveAt(int index) { }
    }
    [System.FlagsAttribute]
    public enum SqlBulkCopyOptions
    {
        CheckConstraints = 2,
        Default = 0,
        FireTriggers = 16,
        KeepIdentity = 1,
        KeepNulls = 8,
        TableLock = 4,
        UseInternalTransaction = 32,
    }
    public sealed partial class SqlClientFactory : System.Data.Common.DbProviderFactory, System.IServiceProvider
    {
        internal SqlClientFactory() { }
        public static readonly System.Data.SqlClient.SqlClientFactory Instance;
        public override bool CanCreateDataSourceEnumerator { get { throw null; } }
        public override System.Data.Common.DbCommand CreateCommand() { throw null; }
        public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public override System.Data.Common.DbConnection CreateConnection() { throw null; }
        public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public override System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public override System.Data.Common.DbDataSourceEnumerator CreateDataSourceEnumerator() { throw null; }
        public override System.Data.Common.DbParameter CreateParameter() { throw null; }
        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
    }
    public static partial class SqlClientMetaDataCollectionNames
    {
        public static readonly string Columns;
        public static readonly string Databases;
        public static readonly string ForeignKeys;
        public static readonly string IndexColumns;
        public static readonly string Indexes;
        public static readonly string Parameters;
        public static readonly string ProcedureColumns;
        public static readonly string Procedures;
        public static readonly string Tables;
        public static readonly string UserDefinedTypes;
        public static readonly string Users;
        public static readonly string ViewColumns;
        public static readonly string Views;
    }
    [System.SerializableAttribute]
    public sealed partial class SqlClientPermission : System.Data.Common.DBDataPermission
    {
        [System.ObsoleteAttribute("SqlClientPermission() has been deprecated.  Use the SqlClientPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        public SqlClientPermission() : base (default(System.Security.Permissions.PermissionState)) { }
        public SqlClientPermission(System.Security.Permissions.PermissionState state) : base (default(System.Security.Permissions.PermissionState)) { }
        [System.ObsoleteAttribute("SqlClientPermission(PermissionState state, Boolean allowBlankPassword) has been deprecated.  Use the SqlClientPermission(PermissionState.None) constructor.  http://go.microsoft.com/fwlink/?linkid=14202", true)]
        public SqlClientPermission(System.Security.Permissions.PermissionState state, bool allowBlankPassword) : base (default(System.Security.Permissions.PermissionState)) { }
        public override void Add(string connectionString, string restrictions, System.Data.KeyRestrictionBehavior behavior) { }
        public override System.Security.IPermission Copy() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class SqlClientPermissionAttribute : System.Data.Common.DBDataPermissionAttribute
    {
        public SqlClientPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.SqlCommandDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
    [System.ComponentModel.ToolboxItemAttribute("System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class SqlCommand : System.Data.Common.DbCommand, System.ICloneable
    {
        public SqlCommand() { }
        public SqlCommand(string cmdText) { }
        public SqlCommand(string cmdText, System.Data.SqlClient.SqlConnection connection) { }
        public SqlCommand(string cmdText, System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlTransaction transaction) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.SQL.Design.SqlCommandTextEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override string CommandText { get { throw null; } set { } }
        public override int CommandTimeout { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.CommandType)(1))]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override System.Data.CommandType CommandType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.SqlClient.SqlConnection Connection { get { throw null; } set { } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } set { } }
        protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { throw null; } }
        protected override System.Data.Common.DbTransaction DbTransaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override bool DesignTimeVisible { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Data.Sql.SqlNotificationRequest Notification { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool NotificationAutoEnlist { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public new System.Data.SqlClient.SqlParameterCollection Parameters { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.SqlClient.SqlTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Data.UpdateRowSource)(3))]
        public override System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public event System.Data.StatementCompletedEventHandler StatementCompleted { add { } remove { } }
        public System.IAsyncResult BeginExecuteNonQuery() { throw null; }
        public System.IAsyncResult BeginExecuteNonQuery(System.AsyncCallback callback, object stateObject) { throw null; }
        public System.IAsyncResult BeginExecuteReader() { throw null; }
        public System.IAsyncResult BeginExecuteReader(System.AsyncCallback callback, object stateObject) { throw null; }
        public System.IAsyncResult BeginExecuteReader(System.AsyncCallback callback, object stateObject, System.Data.CommandBehavior behavior) { throw null; }
        public System.IAsyncResult BeginExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public System.IAsyncResult BeginExecuteXmlReader() { throw null; }
        public System.IAsyncResult BeginExecuteXmlReader(System.AsyncCallback callback, object stateObject) { throw null; }
        public override void Cancel() { }
        public System.Data.SqlClient.SqlCommand Clone() { throw null; }
        protected override System.Data.Common.DbParameter CreateDbParameter() { throw null; }
        public new System.Data.SqlClient.SqlParameter CreateParameter() { throw null; }
        protected override void Dispose(bool disposing) { }
        public int EndExecuteNonQuery(System.IAsyncResult asyncResult) { throw null; }
        public System.Data.SqlClient.SqlDataReader EndExecuteReader(System.IAsyncResult asyncResult) { throw null; }
        public System.Xml.XmlReader EndExecuteXmlReader(System.IAsyncResult asyncResult) { throw null; }
        protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw null; }
        protected override System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int ExecuteNonQuery() { throw null; }
        public override System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public new System.Data.SqlClient.SqlDataReader ExecuteReader() { throw null; }
        public new System.Data.SqlClient.SqlDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync() { throw null; }
        public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { throw null; }
        public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw null; }
        public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override object ExecuteScalar() { throw null; }
        public override System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Xml.XmlReader ExecuteXmlReader() { throw null; }
        public System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync() { throw null; }
        public System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Prepare() { }
        public void ResetCommandTimeout() { }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class SqlCommandBuilder : System.Data.Common.DbCommandBuilder
    {
        public SqlCommandBuilder() { }
        public SqlCommandBuilder(System.Data.SqlClient.SqlDataAdapter adapter) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override System.Data.Common.CatalogLocation CatalogLocation { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override string CatalogSeparator { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public new System.Data.SqlClient.SqlDataAdapter DataAdapter { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override string QuotePrefix { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override string QuoteSuffix { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override string SchemaSeparator { get { throw null; } set { } }
        protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow datarow, System.Data.StatementType statementType, bool whereClause) { }
        public static void DeriveParameters(System.Data.SqlClient.SqlCommand command) { }
        public new System.Data.SqlClient.SqlCommand GetDeleteCommand() { throw null; }
        public new System.Data.SqlClient.SqlCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public new System.Data.SqlClient.SqlCommand GetInsertCommand() { throw null; }
        public new System.Data.SqlClient.SqlCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected override string GetParameterName(int parameterOrdinal) { throw null; }
        protected override string GetParameterName(string parameterName) { throw null; }
        protected override string GetParameterPlaceholder(int parameterOrdinal) { throw null; }
        protected override System.Data.DataTable GetSchemaTable(System.Data.Common.DbCommand srcCommand) { throw null; }
        public new System.Data.SqlClient.SqlCommand GetUpdateCommand() { throw null; }
        public new System.Data.SqlClient.SqlCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        protected override System.Data.Common.DbCommand InitializeCommand(System.Data.Common.DbCommand command) { throw null; }
        public override string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
        public override string UnquoteIdentifier(string quotedIdentifier) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
    public sealed partial class SqlConnection : System.Data.Common.DbConnection, System.ICloneable
    {
        public SqlConnection() { }
        public SqlConnection(string connectionString) { }
        public SqlConnection(string connectionString, System.Data.SqlClient.SqlCredential credential) { }
        [System.MonoTODOAttribute]
        public System.Guid ClientConnectionId { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.SQL.Design.SqlConnectionStringEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override string ConnectionString { get { throw null; } [System.MonoTODOAttribute("persist security info, encrypt, enlist keyword not implemented")]set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override int ConnectionTimeout { get { throw null; } }
        public System.Data.SqlClient.SqlCredential Credential { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string Database { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string DataSource { get { throw null; } }
        protected override System.Data.Common.DbProviderFactory DbProviderFactory { get { throw null; } }
        public bool FireInfoMessageEventOnUserErrors { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int PacketSize { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override string ServerVersion { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public override System.Data.ConnectionState State { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool StatisticsEnabled { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public string WorkstationId { get { throw null; } }
        public event System.Data.SqlClient.SqlInfoMessageEventHandler InfoMessage { add { } remove { } }
        protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public new System.Data.SqlClient.SqlTransaction BeginTransaction() { throw null; }
        public new System.Data.SqlClient.SqlTransaction BeginTransaction(System.Data.IsolationLevel iso) { throw null; }
        public System.Data.SqlClient.SqlTransaction BeginTransaction(System.Data.IsolationLevel iso, string transactionName) { throw null; }
        public System.Data.SqlClient.SqlTransaction BeginTransaction(string transactionName) { throw null; }
        public override void ChangeDatabase(string database) { }
        public static void ChangePassword(string connectionString, System.Data.SqlClient.SqlCredential credential, System.Security.SecureString newSecurePassword) { }
        public static void ChangePassword(string connectionString, string newPassword) { }
        public static void ClearAllPools() { }
        public static void ClearPool(System.Data.SqlClient.SqlConnection connection) { }
        public override void Close() { }
        public new System.Data.SqlClient.SqlCommand CreateCommand() { throw null; }
        protected override System.Data.Common.DbCommand CreateDbCommand() { throw null; }
        protected override void Dispose(bool disposing) { }
        [System.MonoTODOAttribute("Not sure what this means at present.")]
        public void EnlistDistributedTransaction(System.EnterpriseServices.ITransaction transaction) { }
        public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public override System.Data.DataTable GetSchema() { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        public override void Open() { }
        public override System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.MonoTODOAttribute]
        public void ResetStatistics() { }
        [System.MonoTODOAttribute]
        public System.Collections.IDictionary RetrieveStatistics() { throw null; }
        object System.ICloneable.Clone() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
    [System.ComponentModel.TypeConverterAttribute("System.Data.SqlClient.SqlConnectionStringBuilder.SqlConnectionStringBuilderConverter")]
    public sealed partial class SqlConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
    {
        public SqlConnectionStringBuilder() { }
        public SqlConnectionStringBuilder(string connectionString) { }
        [System.ComponentModel.DisplayNameAttribute("ApplicationIntent")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public System.Data.SqlClient.ApplicationIntent ApplicationIntent { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Application Name")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string ApplicationName { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Asynchronous Processing")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool AsynchronousProcessing { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("AttachDbFilename")]
        [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string AttachDBFilename { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DisplayNameAttribute("Connection Reset")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ObsoleteAttribute("ConnectionReset has been deprecated.  SqlConnection will ignore the 'connection reset' keyword and always reset the connection")]
        public bool ConnectionReset { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Connect Timeout")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public int ConnectTimeout { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Context Connection")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool ContextConnection { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Current Language")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string CurrentLanguage { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Data Source")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.SqlClient.SqlConnectionStringBuilder.SqlDataSourceConverter")]
        public string DataSource { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Encrypt")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool Encrypt { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Enlist")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool Enlist { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Failover Partner")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.SqlClient.SqlConnectionStringBuilder.SqlDataSourceConverter")]
        public string FailoverPartner { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Initial Catalog")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.SqlClient.SqlConnectionStringBuilder.SqlInitialCatalogConverter")]
        public string InitialCatalog { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Integrated Security")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool IntegratedSecurity { get { throw null; } set { } }
        public override bool IsFixedSize { get { throw null; } }
        public override object this[string keyword] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        [System.ComponentModel.DisplayNameAttribute("Load Balance Timeout")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public int LoadBalanceTimeout { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Max Pool Size")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public int MaxPoolSize { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Min Pool Size")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public int MinPoolSize { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("MultipleActiveResultSets")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool MultipleActiveResultSets { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("MultiSubnetFailover")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool MultiSubnetFailover { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Network Library")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute("System.Data.SqlClient.SqlConnectionStringBuilder.NetworkLibraryConverter")]
        public string NetworkLibrary { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Packet Size")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public int PacketSize { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Password")]
        [System.ComponentModel.PasswordPropertyTextAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string Password { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Persist Security Info")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool PersistSecurityInfo { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Pooling")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool Pooling { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Replication")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool Replication { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Transaction Binding")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string TransactionBinding { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("TrustServerCertificate")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool TrustServerCertificate { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Type System Version")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string TypeSystemVersion { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("User ID")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string UserID { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("User Instance")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public bool UserInstance { get { throw null; } set { } }
        public override System.Collections.ICollection Values { get { throw null; } }
        [System.ComponentModel.DisplayNameAttribute("Workstation ID")]
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string WorkstationID { get { throw null; } set { } }
        public override void Clear() { }
        public override bool ContainsKey(string keyword) { throw null; }
        protected override void GetProperties(System.Collections.Hashtable propertyDescriptors) { }
        public override bool Remove(string keyword) { throw null; }
        public override bool ShouldSerialize(string keyword) { throw null; }
        public override bool TryGetValue(string keyword, out object value) { value = default(object); throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlCredential
    {
        public SqlCredential(string userId, System.Security.SecureString password) { }
        public System.Security.SecureString Password { get { throw null; } }
        public string UserId { get { throw null; } }
    }
    [System.ComponentModel.DefaultEventAttribute("RowUpdated")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.SqlDataAdapterDesigner, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
    [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.SqlDataAdapterToolboxItem, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class SqlDataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
    {
        public SqlDataAdapter() { }
        public SqlDataAdapter(System.Data.SqlClient.SqlCommand selectCommand) { }
        public SqlDataAdapter(string selectCommandText, System.Data.SqlClient.SqlConnection selectConnection) { }
        public SqlDataAdapter(string selectCommandText, string selectConnectionString) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.SqlClient.SqlCommand DeleteCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.SqlClient.SqlCommand InsertCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.SqlClient.SqlCommand SelectCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        public override int UpdateBatchSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.SqlClient.SqlCommand UpdateCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public event System.Data.SqlClient.SqlRowUpdatedEventHandler RowUpdated { add { } remove { } }
        public event System.Data.SqlClient.SqlRowUpdatingEventHandler RowUpdating { add { } remove { } }
        [System.MonoTODOAttribute]
        protected override int AddToBatch(System.Data.IDbCommand command) { throw null; }
        [System.MonoTODOAttribute]
        protected override void ClearBatch() { }
        protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        [System.MonoTODOAttribute]
        protected override int ExecuteBatch() { throw null; }
        [System.MonoTODOAttribute]
        protected override System.Data.IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex) { throw null; }
        protected override bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out System.Exception error) { recordsAffected = default(int); error = default(System.Exception); throw null; }
        [System.MonoTODOAttribute]
        protected override void InitializeBatching() { }
        protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
        [System.MonoTODOAttribute]
        object System.ICloneable.Clone() { throw null; }
        [System.MonoTODOAttribute]
        protected override void TerminateBatching() { }
    }
    public partial class SqlDataReader : System.Data.Common.DbDataReader, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable
    {
        internal SqlDataReader() { }
        protected System.Data.SqlClient.SqlConnection Connection { get { throw null; } }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int i] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override int VisibleFieldCount { get { throw null; } }
        public override void Close() { }
        public override bool GetBoolean(int i) { throw null; }
        public override byte GetByte(int i) { throw null; }
        public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override char GetChar(int i) { throw null; }
        public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length) { throw null; }
        public override string GetDataTypeName(int i) { throw null; }
        public override System.DateTime GetDateTime(int i) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.DateTimeOffset GetDateTimeOffset(int i) { throw null; }
        public override decimal GetDecimal(int i) { throw null; }
        public override double GetDouble(int i) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int i) { throw null; }
        public override System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int i, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override T GetFieldValue<T>(int i) { throw null; }
        public override float GetFloat(int i) { throw null; }
        public override System.Guid GetGuid(int i) { throw null; }
        public override short GetInt16(int i) { throw null; }
        public override int GetInt32(int i) { throw null; }
        public override long GetInt64(int i) { throw null; }
        public override string GetName(int i) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        public override System.Type GetProviderSpecificFieldType(int i) { throw null; }
        public override object GetProviderSpecificValue(int i) { throw null; }
        public override int GetProviderSpecificValues(object[] values) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int i) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int i) { throw null; }
        public virtual System.Data.SqlTypes.SqlString GetSqlString(int i) { throw null; }
        public virtual object GetSqlValue(int i) { throw null; }
        public virtual int GetSqlValues(object[] values) { throw null; }
        public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int i) { throw null; }
        public override System.IO.Stream GetStream(int i) { throw null; }
        public override string GetString(int i) { throw null; }
        public override System.IO.TextReader GetTextReader(int i) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.TimeSpan GetTimeSpan(int i) { throw null; }
        public override object GetValue(int i) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.Xml.XmlReader GetXmlReader(int i) { throw null; }
        protected internal bool IsCommandBehavior(System.Data.CommandBehavior condition) { throw null; }
        public override bool IsDBNull(int i) { throw null; }
        public override System.Threading.Tasks.Task<bool> IsDBNullAsync(int i, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override bool NextResult() { throw null; }
        public override System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override bool Read() { throw null; }
        public override System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Data.IDataReader System.Data.IDataRecord.GetData(int i) { throw null; }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("afef65ad-4577-447a-a148-83acadd3d4b9")]
    public sealed partial class SQLDebugging
    {
        [System.MonoTODOAttribute]
        public SQLDebugging() { }
    }
    public sealed partial class SqlDependency
    {
        [System.MonoTODOAttribute]
        public SqlDependency() { }
        [System.MonoTODOAttribute]
        public SqlDependency(System.Data.SqlClient.SqlCommand command) { }
        [System.MonoTODOAttribute]
        public SqlDependency(System.Data.SqlClient.SqlCommand command, string options, int timeout) { }
        [System.MonoTODOAttribute]
        public bool HasChanges { get { throw null; } }
        public string Id { get { throw null; } }
        [System.MonoTODOAttribute]
        public event System.Data.SqlClient.OnChangeEventHandler OnChange { add { } remove { } }
        [System.MonoTODOAttribute]
        public void AddCommandDependency(System.Data.SqlClient.SqlCommand command) { }
        [System.MonoTODOAttribute]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
        public static bool Start(string connectionString) { throw null; }
        [System.MonoTODOAttribute]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
        public static bool Start(string connectionString, string queue) { throw null; }
        [System.MonoTODOAttribute]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
        public static bool Stop(string connectionString) { throw null; }
        [System.MonoTODOAttribute]
        [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
        public static bool Stop(string connectionString, string queue) { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlError
    {
        internal SqlError() { }
        public byte Class { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public string Message { get { throw null; } }
        public int Number { get { throw null; } }
        public string Procedure { get { throw null; } }
        public string Server { get { throw null; } }
        public string Source { get { throw null; } }
        public byte State { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlErrorCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal SqlErrorCollection() { }
        public int Count { get { throw null; } }
        public System.Data.SqlClient.SqlError this[int index] { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.SqlClient.SqlError[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlException : System.Data.Common.DbException
    {
        internal SqlException() { }
        public byte Class { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Guid ClientConnectionId { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Data.SqlClient.SqlErrorCollection Errors { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int Number { get { throw null; } }
        public string Procedure { get { throw null; } }
        public string Server { get { throw null; } }
        public override string Source { get { throw null; } }
        public byte State { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public sealed partial class SqlInfoMessageEventArgs : System.EventArgs
    {
        internal SqlInfoMessageEventArgs() { }
        public System.Data.SqlClient.SqlErrorCollection Errors { get { throw null; } }
        public string Message { get { throw null; } }
        public string Source { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public delegate void SqlInfoMessageEventHandler(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e);
    public partial class SqlNotificationEventArgs : System.EventArgs
    {
        public SqlNotificationEventArgs(System.Data.SqlClient.SqlNotificationType type, System.Data.SqlClient.SqlNotificationInfo info, System.Data.SqlClient.SqlNotificationSource source) { }
        public System.Data.SqlClient.SqlNotificationInfo Info { get { throw null; } }
        public System.Data.SqlClient.SqlNotificationSource Source { get { throw null; } }
        public System.Data.SqlClient.SqlNotificationType Type { get { throw null; } }
    }
    public enum SqlNotificationInfo
    {
        AlreadyChanged = -2,
        Alter = 5,
        Delete = 3,
        Drop = 4,
        Error = 7,
        Expired = 12,
        Insert = 1,
        Invalid = 9,
        Isolation = 11,
        Merge = 16,
        Options = 10,
        PreviousFire = 14,
        Query = 8,
        Resource = 13,
        Restart = 6,
        TemplateLimit = 15,
        Truncate = 0,
        Unknown = -1,
        Update = 2,
    }
    public enum SqlNotificationSource
    {
        Client = -2,
        Data = 0,
        Database = 3,
        Environment = 6,
        Execution = 7,
        Object = 2,
        Owner = 8,
        Statement = 5,
        System = 4,
        Timeout = 1,
        Unknown = -1,
    }
    public enum SqlNotificationType
    {
        Change = 0,
        Subscribe = 1,
        Unknown = -1,
    }
    [System.ComponentModel.TypeConverterAttribute("System.Data.SqlClient.SqlParameter+SqlParameterConverter, System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public sealed partial class SqlParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable
    {
        public SqlParameter() { }
        public SqlParameter(string parameterName, System.Data.SqlDbType dbType) { }
        public SqlParameter(string parameterName, System.Data.SqlDbType dbType, int size) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public SqlParameter(string parameterName, System.Data.SqlDbType dbType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion sourceVersion, object value) { }
        public SqlParameter(string parameterName, System.Data.SqlDbType dbType, int size, System.Data.ParameterDirection direction, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value, string xmlSchemaCollectionDatabase, string xmlSchemaCollectionOwningSchema, string xmlSchemaCollectionName) { }
        public SqlParameter(string parameterName, System.Data.SqlDbType dbType, int size, string sourceColumn) { }
        public SqlParameter(string parameterName, object value) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.SqlTypes.SqlCompareOptions CompareInfo { get { throw null; } set { } }
        public override System.Data.DbType DbType { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public override System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public override bool IsNullable { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int LocaleId { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public int Offset { get { throw null; } set { } }
        public override string ParameterName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public byte Precision { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public byte Scale { get { throw null; } set { } }
        public override int Size { get { throw null; } set { } }
        public override string SourceColumn { get { throw null; } set { } }
        public override bool SourceColumnNullMapping { get { throw null; } set { } }
        public override System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.Data.Common.DbProviderSpecificTypePropertyAttribute(true)]
        public System.Data.SqlDbType SqlDbType { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public object SqlValue { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string UdtTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
        public override object Value { get { throw null; } set { } }
        public string XmlSchemaCollectionDatabase { get { throw null; } set { } }
        public string XmlSchemaCollectionName { get { throw null; } set { } }
        public string XmlSchemaCollectionOwningSchema { get { throw null; } set { } }
        public override void ResetDbType() { }
        public void ResetSqlDbType() { }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class SqlParameterCollection : System.Data.Common.DbParameterCollection
    {
        internal SqlParameterCollection() { }
        public override int Count { get { throw null; } }
        public override bool IsFixedSize { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.SqlClient.SqlParameter this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public new System.Data.SqlClient.SqlParameter this[string parameterName] { get { throw null; } set { } }
        public override object SyncRoot { get { throw null; } }
        public System.Data.SqlClient.SqlParameter Add(System.Data.SqlClient.SqlParameter value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public override int Add(object value) { throw null; }
        public System.Data.SqlClient.SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType) { throw null; }
        public System.Data.SqlClient.SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType, int size) { throw null; }
        public System.Data.SqlClient.SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType, int size, string sourceColumn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Do not call this method.")]
        public System.Data.SqlClient.SqlParameter Add(string parameterName, object value) { throw null; }
        public override void AddRange(System.Array values) { }
        public void AddRange(System.Data.SqlClient.SqlParameter[] values) { }
        public System.Data.SqlClient.SqlParameter AddWithValue(string parameterName, object value) { throw null; }
        public override void Clear() { }
        public bool Contains(System.Data.SqlClient.SqlParameter value) { throw null; }
        public override bool Contains(object value) { throw null; }
        public override bool Contains(string value) { throw null; }
        public override void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.SqlClient.SqlParameter[] array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(int index) { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw null; }
        public int IndexOf(System.Data.SqlClient.SqlParameter value) { throw null; }
        public override int IndexOf(object value) { throw null; }
        public override int IndexOf(string parameterName) { throw null; }
        public void Insert(int index, System.Data.SqlClient.SqlParameter value) { }
        public override void Insert(int index, object value) { }
        public void Remove(System.Data.SqlClient.SqlParameter value) { }
        public override void Remove(object value) { }
        public override void RemoveAt(int index) { }
        public override void RemoveAt(string parameterName) { }
        protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
        protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
    }
    public partial class SqlRowsCopiedEventArgs : System.EventArgs
    {
        public SqlRowsCopiedEventArgs(long rowsCopied) { }
        public bool Abort { get { throw null; } set { } }
        public long RowsCopied { get { throw null; } }
    }
    public delegate void SqlRowsCopiedEventHandler(object sender, System.Data.SqlClient.SqlRowsCopiedEventArgs e);
    public sealed partial class SqlRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs
    {
        public SqlRowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        public new System.Data.SqlClient.SqlCommand Command { get { throw null; } }
    }
    public delegate void SqlRowUpdatedEventHandler(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e);
    public sealed partial class SqlRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs
    {
        public SqlRowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        protected override System.Data.IDbCommand BaseCommand { get { throw null; } set { } }
        public new System.Data.SqlClient.SqlCommand Command { get { throw null; } set { } }
    }
    public delegate void SqlRowUpdatingEventHandler(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e);
    public sealed partial class SqlTransaction : System.Data.Common.DbTransaction
    {
        internal SqlTransaction() { }
        public new System.Data.SqlClient.SqlConnection Connection { get { throw null; } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } }
        public override System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public override void Commit() { }
        protected override void Dispose(bool disposing) { }
        public override void Rollback() { }
        public void Rollback(string transactionName) { }
        public void Save(string savePointName) { }
    }
}
namespace System.Data.SqlTypes
{
    public partial interface INullable
    {
        bool IsNull { get; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlAlreadyFilledException : System.Data.SqlTypes.SqlTypeException
    {
        public SqlAlreadyFilledException() { }
        public SqlAlreadyFilledException(string message) { }
        public SqlAlreadyFilledException(string message, System.Exception e) { }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private object _dummy;
        public static readonly System.Data.SqlTypes.SqlBinary Null;
        public SqlBinary(byte[] value) { throw null;}
        public bool IsNull { get { throw null; } }
        public byte this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public byte[] Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlBinary Add(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlBinary value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlBinary Concat(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBinary operator +(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static explicit operator byte[] (System.Data.SqlTypes.SqlBinary x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBinary (System.Data.SqlTypes.SqlGuid x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlBinary (byte[] x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlGuid ToSqlGuid() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlBoolean False;
        public static readonly System.Data.SqlTypes.SqlBoolean Null;
        public static readonly System.Data.SqlTypes.SqlBoolean One;
        public static readonly System.Data.SqlTypes.SqlBoolean True;
        public static readonly System.Data.SqlTypes.SqlBoolean Zero;
        public SqlBoolean(bool value) { throw null;}
        public SqlBoolean(int value) { throw null;}
        public byte ByteValue { get { throw null; } }
        public bool IsFalse { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public bool IsTrue { get { throw null; } }
        public bool Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlBoolean value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEquals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEquals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean OnesComplement(System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator &(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator |(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ^(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static explicit operator bool (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlString x) { throw null; }
        public static bool operator false(System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlBoolean (bool x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !(System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ~(System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static bool operator true(System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Parse(string s) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Xor(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlByte : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlByte MaxValue;
        public static readonly System.Data.SqlTypes.SqlByte MinValue;
        public static readonly System.Data.SqlTypes.SqlByte Null;
        public static readonly System.Data.SqlTypes.SqlByte Zero;
        public SqlByte(byte value) { throw null;}
        public bool IsNull { get { throw null; } }
        public byte Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlByte Add(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte BitwiseAnd(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte BitwiseOr(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlByte value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlByte Divide(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte Mod(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte Modulus(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte OnesComplement(System.Data.SqlTypes.SqlByte x) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator +(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator &(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator |(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator /(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator ^(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator byte (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlByte (byte x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator %(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator *(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator ~(System.Data.SqlTypes.SqlByte x) { throw null; }
        public static System.Data.SqlTypes.SqlByte operator -(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        public static System.Data.SqlTypes.SqlByte Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlByte Subtract(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.SqlTypes.SqlByte Xor(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    public sealed partial class SqlBytes : System.Data.SqlTypes.INullable, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
    {
        public SqlBytes() { }
        public SqlBytes(byte[] buffer) { }
        public SqlBytes(System.Data.SqlTypes.SqlBinary value) { }
        public SqlBytes(System.IO.Stream s) { }
        public byte[] Buffer { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public byte this[long offset] { get { throw null; } set { } }
        public long Length { get { throw null; } }
        public long MaxLength { get { throw null; } }
        public static System.Data.SqlTypes.SqlBytes Null { get { throw null; } }
        public System.Data.SqlTypes.StorageState Storage { get { throw null; } }
        public System.IO.Stream Stream { get { throw null; } set { } }
        public byte[] Value { get { throw null; } }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBytes (System.Data.SqlTypes.SqlBinary value) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlBinary (System.Data.SqlTypes.SqlBytes value) { throw null; }
        public long Read(long offset, byte[] buffer, int offsetInBuffer, int count) { throw null; }
        public void SetLength(long value) { }
        public void SetNull() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBinary ToSqlBinary() { throw null; }
        public void Write(long offset, byte[] buffer, int offsetInBuffer, int count) { }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    public sealed partial class SqlChars : System.Data.SqlTypes.INullable, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
    {
        public SqlChars() { }
        public SqlChars(char[] buffer) { }
        public SqlChars(System.Data.SqlTypes.SqlString value) { }
        public char[] Buffer { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public char this[long offset] { get { throw null; } set { } }
        public long Length { get { throw null; } }
        public long MaxLength { get { throw null; } }
        public static System.Data.SqlTypes.SqlChars Null { get { throw null; } }
        public System.Data.SqlTypes.StorageState Storage { get { throw null; } }
        public char[] Value { get { throw null; } }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlChars value) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlChars (System.Data.SqlTypes.SqlString value) { throw null; }
        public long Read(long offset, char[] buffer, int offsetInBuffer, int count) { throw null; }
        public void SetLength(long value) { }
        public void SetNull() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public void Write(long offset, char[] buffer, int offsetInBuffer, int count) { }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum SqlCompareOptions
    {
        BinarySort = 32768,
        BinarySort2 = 16384,
        IgnoreCase = 1,
        IgnoreKanaType = 8,
        IgnoreNonSpace = 2,
        IgnoreWidth = 16,
        None = 0,
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlDateTime : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlDateTime MaxValue;
        public static readonly System.Data.SqlTypes.SqlDateTime MinValue;
        public static readonly System.Data.SqlTypes.SqlDateTime Null;
        public static readonly int SQLTicksPerHour;
        public static readonly int SQLTicksPerMinute;
        public static readonly int SQLTicksPerSecond;
        public SqlDateTime(System.DateTime value) { throw null;}
        public SqlDateTime(int dayTicks, int timeTicks) { throw null;}
        public SqlDateTime(int year, int month, int day) { throw null;}
        public SqlDateTime(int year, int month, int day, int hour, int minute, int second) { throw null;}
        public SqlDateTime(int year, int month, int day, int hour, int minute, int second, double millisecond) { throw null;}
        public SqlDateTime(int year, int month, int day, int hour, int minute, int second, int bilisecond) { throw null;}
        public int DayTicks { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public int TimeTicks { get { throw null; } }
        public System.DateTime Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlDateTime Add(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlDateTime value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlDateTime operator +(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static explicit operator System.DateTime (System.Data.SqlTypes.SqlDateTime x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDateTime (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDateTime (System.DateTime value) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { throw null; }
        public static System.Data.SqlTypes.SqlDateTime operator -(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { throw null; }
        public static System.Data.SqlTypes.SqlDateTime Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlDateTime Subtract(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlDecimal : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly byte MaxPrecision;
        public static readonly byte MaxScale;
        public static readonly System.Data.SqlTypes.SqlDecimal MaxValue;
        public static readonly System.Data.SqlTypes.SqlDecimal MinValue;
        public static readonly System.Data.SqlTypes.SqlDecimal Null;
        public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int data1, int data2, int data3, int data4) { throw null;}
        public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int[] bits) { throw null;}
        public SqlDecimal(decimal value) { throw null;}
        public SqlDecimal(double dVal) { throw null;}
        public SqlDecimal(int value) { throw null;}
        public SqlDecimal(long value) { throw null;}
        public byte[] BinData { get { throw null; } }
        public int[] Data { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public bool IsPositive { get { throw null; } }
        public byte Precision { get { throw null; } }
        public byte Scale { get { throw null; } }
        public decimal Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlDecimal Abs(System.Data.SqlTypes.SqlDecimal n) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Add(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal AdjustScale(System.Data.SqlTypes.SqlDecimal n, int digits, bool fRound) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Ceiling(System.Data.SqlTypes.SqlDecimal n) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlDecimal value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal ConvertToPrecScale(System.Data.SqlTypes.SqlDecimal n, int precision, int scale) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Divide(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Floor(System.Data.SqlTypes.SqlDecimal n) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal operator +(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal operator /(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator decimal (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlString x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDecimal (double x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (decimal x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDecimal (long x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal operator *(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal operator -(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal operator -(System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Power(System.Data.SqlTypes.SqlDecimal n, double exp) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Round(System.Data.SqlTypes.SqlDecimal n, int position) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Sign(System.Data.SqlTypes.SqlDecimal n) { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Subtract(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public double ToDouble() { throw null; }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.SqlTypes.SqlDecimal Truncate(System.Data.SqlTypes.SqlDecimal n, int position) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlDouble MaxValue;
        public static readonly System.Data.SqlTypes.SqlDouble MinValue;
        public static readonly System.Data.SqlTypes.SqlDouble Null;
        public static readonly System.Data.SqlTypes.SqlDouble Zero;
        public SqlDouble(double value) { throw null;}
        public bool IsNull { get { throw null; } }
        public double Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlDouble Add(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlDouble value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlDouble Divide(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlDouble Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlDouble operator +(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlDouble operator /(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator double (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlDouble (double x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlDouble operator *(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlDouble operator -(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        public static System.Data.SqlTypes.SqlDouble operator -(System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static System.Data.SqlTypes.SqlDouble Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlDouble Subtract(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class SqlFileStream : System.IO.Stream
    {
        public SqlFileStream(string path, byte[] transactionContext, System.IO.FileAccess access) { }
        public SqlFileStream(string path, byte[] transactionContext, System.IO.FileAccess access, System.IO.FileOptions options, long allocationSize) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public string Name { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public byte[] TransactionContext { get { throw null; } }
        public override int WriteTimeout { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        ~SqlFileStream() { }
        public override void Flush() { }
        public override int Read([System.Runtime.InteropServices.In][System.Runtime.InteropServices.Out]byte[] buffer, int offset, int count) { buffer = default(byte[]); throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void WriteByte(byte value) { }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private object _dummy;
        public static readonly System.Data.SqlTypes.SqlGuid Null;
        public SqlGuid(byte[] value) { throw null;}
        public SqlGuid(System.Guid g) { throw null;}
        public SqlGuid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { throw null;}
        public SqlGuid(string s) { throw null;}
        public bool IsNull { get { throw null; } }
        public System.Guid Value { get { throw null; } }
        public int CompareTo(System.Data.SqlTypes.SqlGuid value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlGuid (System.Data.SqlTypes.SqlBinary x) { throw null; }
        public static explicit operator System.Guid (System.Data.SqlTypes.SqlGuid x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlGuid (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlGuid (System.Guid x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { throw null; }
        public static System.Data.SqlTypes.SqlGuid Parse(string s) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public byte[] ToByteArray() { throw null; }
        public System.Data.SqlTypes.SqlBinary ToSqlBinary() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlInt16 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlInt16 MaxValue;
        public static readonly System.Data.SqlTypes.SqlInt16 MinValue;
        public static readonly System.Data.SqlTypes.SqlInt16 Null;
        public static readonly System.Data.SqlTypes.SqlInt16 Zero;
        public SqlInt16(short value) { throw null;}
        public bool IsNull { get { throw null; } }
        public short Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlInt16 Add(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 BitwiseAnd(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 BitwiseOr(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlInt16 value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Divide(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Mod(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Modulus(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 OnesComplement(System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator +(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator &(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator |(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator /(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator ^(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator short (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt16 (short x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator %(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator *(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator ~(System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator -(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 operator -(System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Subtract(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.SqlTypes.SqlInt16 Xor(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlInt32 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlInt32 MaxValue;
        public static readonly System.Data.SqlTypes.SqlInt32 MinValue;
        public static readonly System.Data.SqlTypes.SqlInt32 Null;
        public static readonly System.Data.SqlTypes.SqlInt32 Zero;
        public SqlInt32(int value) { throw null;}
        public bool IsNull { get { throw null; } }
        public int Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlInt32 Add(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 BitwiseAnd(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 BitwiseOr(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlInt32 value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Divide(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Mod(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Modulus(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 OnesComplement(System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator +(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator &(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator |(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator /(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator ^(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator int (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt32 (int x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator %(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator *(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator ~(System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator -(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 operator -(System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Subtract(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.SqlTypes.SqlInt32 Xor(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlInt64 : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlInt64 MaxValue;
        public static readonly System.Data.SqlTypes.SqlInt64 MinValue;
        public static readonly System.Data.SqlTypes.SqlInt64 Null;
        public static readonly System.Data.SqlTypes.SqlInt64 Zero;
        public SqlInt64(long value) { throw null;}
        public bool IsNull { get { throw null; } }
        public long Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlInt64 Add(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 BitwiseAnd(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 BitwiseOr(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlInt64 value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Divide(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Mod(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 OnesComplement(System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator +(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator &(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator |(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator /(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator ^(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator long (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlInt64 (long x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator %(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator *(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator ~(System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator -(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 operator -(System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Subtract(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.SqlTypes.SqlInt64 Xor(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlMoney : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlMoney MaxValue;
        public static readonly System.Data.SqlTypes.SqlMoney MinValue;
        public static readonly System.Data.SqlTypes.SqlMoney Null;
        public static readonly System.Data.SqlTypes.SqlMoney Zero;
        public SqlMoney(decimal value) { throw null;}
        public SqlMoney(double value) { throw null;}
        public SqlMoney(int value) { throw null;}
        public SqlMoney(long value) { throw null;}
        public bool IsNull { get { throw null; } }
        public decimal Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlMoney Add(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlMoney value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlMoney Divide(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlMoney Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlMoney operator +(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlMoney operator /(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator decimal (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlString x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlMoney (double x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlMoney (decimal x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlMoney (long x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlMoney operator *(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlMoney operator -(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        public static System.Data.SqlTypes.SqlMoney operator -(System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static System.Data.SqlTypes.SqlMoney Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlMoney Subtract(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public decimal ToDecimal() { throw null; }
        public double ToDouble() { throw null; }
        public int ToInt32() { throw null; }
        public long ToInt64() { throw null; }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlNotFilledException : System.Data.SqlTypes.SqlTypeException
    {
        public SqlNotFilledException() { }
        public SqlNotFilledException(string message) { }
        public SqlNotFilledException(string message, System.Exception e) { }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlNullValueException : System.Data.SqlTypes.SqlTypeException
    {
        public SqlNullValueException() { }
        public SqlNullValueException(string message) { }
        public SqlNullValueException(string message, System.Exception e) { }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.SqlTypes.SqlSingle MaxValue;
        public static readonly System.Data.SqlTypes.SqlSingle MinValue;
        public static readonly System.Data.SqlTypes.SqlSingle Null;
        public static readonly System.Data.SqlTypes.SqlSingle Zero;
        public SqlSingle(double value) { throw null;}
        public SqlSingle(float value) { throw null;}
        public bool IsNull { get { throw null; } }
        public float Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlSingle Add(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlSingle value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlSingle Divide(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlSingle Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlSingle operator +(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlSingle operator /(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator float (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlSingle (float x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlSingle operator *(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlSingle operator -(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        public static System.Data.SqlTypes.SqlSingle operator -(System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static System.Data.SqlTypes.SqlSingle Parse(string s) { throw null; }
        public static System.Data.SqlTypes.SqlSingle Subtract(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlString ToSqlString() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SqlString : System.Data.SqlTypes.INullable, System.IComparable, System.Xml.Serialization.IXmlSerializable
    {
        private object _dummy;
        private int _dummyPrimitive;
        public static readonly int BinarySort;
        public static readonly int BinarySort2;
        public static readonly int IgnoreCase;
        public static readonly int IgnoreKanaType;
        public static readonly int IgnoreNonSpace;
        public static readonly int IgnoreWidth;
        public static readonly System.Data.SqlTypes.SqlString Null;
        public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data) { throw null;}
        public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data, bool fUnicode) { throw null;}
        public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data, int index, int count) { throw null;}
        public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data, int index, int count, bool fUnicode) { throw null;}
        public SqlString(string data) { throw null;}
        public SqlString(string data, int lcid) { throw null;}
        public SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions) { throw null;}
        public System.Globalization.CompareInfo CompareInfo { get { throw null; } }
        public System.Globalization.CultureInfo CultureInfo { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public int LCID { get { throw null; } }
        public System.Data.SqlTypes.SqlCompareOptions SqlCompareOptions { get { throw null; } }
        public string Value { get { throw null; } }
        public static System.Data.SqlTypes.SqlString Add(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public System.Data.SqlTypes.SqlString Clone() { throw null; }
        public static System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions) { throw null; }
        public int CompareTo(System.Data.SqlTypes.SqlString value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Data.SqlTypes.SqlString Concat(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public byte[] GetNonUnicodeBytes() { throw null; }
        public byte[] GetUnicodeBytes() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlString operator +(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlBoolean x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlByte x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlDateTime x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlDecimal x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlDouble x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlGuid x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlInt16 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlInt32 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlInt64 x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlMoney x) { throw null; }
        public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlSingle x) { throw null; }
        public static explicit operator string (System.Data.SqlTypes.SqlString x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static implicit operator System.Data.SqlTypes.SqlString (string x) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { throw null; }
        public System.Data.SqlTypes.SqlByte ToSqlByte() { throw null; }
        public System.Data.SqlTypes.SqlDateTime ToSqlDateTime() { throw null; }
        public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { throw null; }
        public System.Data.SqlTypes.SqlDouble ToSqlDouble() { throw null; }
        public System.Data.SqlTypes.SqlGuid ToSqlGuid() { throw null; }
        public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { throw null; }
        public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { throw null; }
        public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { throw null; }
        public System.Data.SqlTypes.SqlMoney ToSqlMoney() { throw null; }
        public System.Data.SqlTypes.SqlSingle ToSqlSingle() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SqlTruncateException : System.Data.SqlTypes.SqlTypeException
    {
        public SqlTruncateException() { }
        public SqlTruncateException(string message) { }
        public SqlTruncateException(string message, System.Exception e) { }
    }
    [System.SerializableAttribute]
    public partial class SqlTypeException : System.SystemException
    {
        public SqlTypeException() { }
        protected SqlTypeException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) { }
        public SqlTypeException(string message) { }
        public SqlTypeException(string message, System.Exception e) { }
    }
    public partial class SqlTypesSchemaImporterExtensionHelper : System.Xml.Serialization.Advanced.SchemaImporterExtension
    {
        protected static readonly string SqlTypesNamespace;
        public SqlTypesSchemaImporterExtensionHelper(string name, string destinationType) { }
        public SqlTypesSchemaImporterExtensionHelper(string name, string destinationType, bool direct) { }
        public SqlTypesSchemaImporterExtensionHelper(string name, string targetNamespace, string[] references, System.CodeDom.CodeNamespaceImport[] namespaceImports, string destinationType, bool direct) { }
        public override string ImportSchemaType(string name, string xmlNamespace, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public override string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
    }
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetXsdType")]
    [System.SerializableAttribute]
    public sealed partial class SqlXml : System.Data.SqlTypes.INullable, System.Xml.Serialization.IXmlSerializable
    {
        public SqlXml() { }
        public SqlXml(System.IO.Stream value) { }
        public SqlXml(System.Xml.XmlReader value) { }
        public bool IsNull { get { throw null; } }
        public static System.Data.SqlTypes.SqlXml Null { get { throw null; } }
        public string Value { get { throw null; } }
        public System.Xml.XmlReader CreateReader() { throw null; }
        public static System.Xml.XmlQualifiedName GetXsdType(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader r) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    }
    public enum StorageState
    {
        Buffer = 0,
        Stream = 1,
        UnmanagedBuffer = 2,
    }
    public sealed partial class TypeBigIntSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeBigIntSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeBinarySchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeBinarySchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeBitSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeBitSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeCharSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeCharSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeDateTimeSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeDateTimeSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeDecimalSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeDecimalSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeFloatSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeFloatSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeIntSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeIntSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeMoneySchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeMoneySchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeNCharSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeNCharSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeNTextSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeNTextSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeNumericSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeNumericSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeNVarCharSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeNVarCharSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeRealSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeRealSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeSmallDateTimeSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeSmallDateTimeSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeSmallIntSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeSmallIntSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeSmallMoneySchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeSmallMoneySchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeTextSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeTextSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeTinyIntSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeTinyIntSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeUniqueIdentifierSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeUniqueIdentifierSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeVarBinarySchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeVarBinarySchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeVarCharSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeVarCharSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
    public sealed partial class TypeVarImageSchemaImporterExtension : System.Data.SqlTypes.SqlTypesSchemaImporterExtensionHelper
    {
        public TypeVarImageSchemaImporterExtension() : base (default(string), default(string), default(string[]), default(System.CodeDom.CodeNamespaceImport[]), default(string), default(bool)) { }
    }
}
namespace System.Xml
{
    [System.ObsoleteAttribute("XmlDataDocument class will be removed in a future release.")]
    public partial class XmlDataDocument : System.Xml.XmlDocument
    {
        public XmlDataDocument() { }
        public XmlDataDocument(System.Data.DataSet dataset) { }
        public System.Data.DataSet DataSet { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI) { throw null; }
        public override System.Xml.XmlEntityReference CreateEntityReference(string name) { throw null; }
        protected override System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node) { throw null; }
        public override System.Xml.XmlElement GetElementById(string elemId) { throw null; }
        public System.Xml.XmlElement GetElementFromRow(System.Data.DataRow r) { throw null; }
        public override System.Xml.XmlNodeList GetElementsByTagName(string name) { throw null; }
        public System.Data.DataRow GetRowFromElement(System.Xml.XmlElement e) { throw null; }
        public override void Load(System.IO.Stream inStream) { }
        public override void Load(System.IO.TextReader txtReader) { }
        public override void Load(string filename) { }
        public override void Load(System.Xml.XmlReader reader) { }
    }
}
