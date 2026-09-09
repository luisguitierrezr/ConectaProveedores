using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENInternalConceptEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInternalConceptEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, "inter_pqz6uvkp8y5jyquv2vka1hu2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("bb3c573f-1de4-4979-b17a-0a3584b8c7b3");
} // ENInternalConceptEntity
partial class ENInternalConceptEntity : InMemoryStaticEntityRuntime<EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord, int> {
    

    private static ENInternalConceptEntity instance = new();
    public static ENInternalConceptEntity GetInstance() => instance;

    public static EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Id, "id") ?? "id"}\" \"InternalConcept.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Label, "label") ?? "label"}\" \"InternalConcept.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Order, "order") ?? "order"}\" \"InternalConcept.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"InternalConcept.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, "inter_pqz6uvkp8y5jyquv2vka1hu2"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@TelcelStorage, _EntityKeyConstants._TelcelStorageEntityKeys.@InternalConcept, _EntityKeyConstants._TelcelStorageEntityKeys._InternalConceptAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInternalConcept", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("InternalConcept", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("skddIFHEtkCYqIUe4fNQVw"), 2 },
{ ObjectKey.Parse("jmvFha_tz0yKO7ooqa1pCg"), 1 },

    };

    protected override Dictionary<int, EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

