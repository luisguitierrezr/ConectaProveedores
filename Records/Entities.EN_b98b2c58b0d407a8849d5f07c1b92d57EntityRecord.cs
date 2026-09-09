using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOriginEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOriginEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
};
}
public static System.Collections.Generic.Dictionary<string,string> AttributesToDatabaseNamesMap() {
return EntityAttributes;
}
public static string AttributeDatabaseName(string attributeName) {
string databaseName;
EntityAttributes.TryGetValue(attributeName, out databaseName);
return databaseName;
}
public static string LocalViewName(string locale) {
return ViewName(locale);
}
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, "origi_9j9tk7mvvctn72stjmado5w0"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
} // ENOriginEntity
partial class ENOriginEntity : InMemoryStaticEntityRuntime<EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord, int> {
    

    private static ENOriginEntity instance = new();
    public static ENOriginEntity GetInstance() => instance;

    public static EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Id, "id") ?? "id"}\" \"Origin.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Label, "label") ?? "label"}\" \"Origin.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Order, "order") ?? "order"}\" \"Origin.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"Origin.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, "origi_9j9tk7mvvctn72stjmado5w0"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, _EntityKeyConstants._AuditEngineEntityKeys._OriginAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrigin", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Origin", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("QJ+dZiq9BkusBzJQx+iTpQ"), 3 },
{ ObjectKey.Parse("EDMoe574bU+9xe7w8wPKgw"), 4 },
{ ObjectKey.Parse("84E2fyOpEECC9A4rBDjgCw"), 1 },
{ ObjectKey.Parse("tOGqoMascUyEafp9TIXKWA"), 2 },
{ ObjectKey.Parse("TRC0qdh+eEe+f2b6iPr3fg"), 7 },
{ ObjectKey.Parse("K1+CxV3wcE60PTFN2cY+QQ"), 5 },
{ ObjectKey.Parse("G27SzZedt0ilPgf3kd71ug"), 6 },

    };

    protected override Dictionary<int, EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

