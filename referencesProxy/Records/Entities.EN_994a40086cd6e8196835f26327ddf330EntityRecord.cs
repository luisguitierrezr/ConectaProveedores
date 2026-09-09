using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENDayOfWeekEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDayOfWeekEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, "dayof_woucc4dity1bvqaltlkiu3b5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1");
} // ENDayOfWeekEntity
partial class ENDayOfWeekEntity : InMemoryStaticEntityRuntime<EN_994a40086cd6e8196835f26327ddf330EntityRecord, int> {
    

    private static ENDayOfWeekEntity instance = new();
    public static ENDayOfWeekEntity GetInstance() => instance;

    public static EN_994a40086cd6e8196835f26327ddf330EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_994a40086cd6e8196835f26327ddf330EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_994a40086cd6e8196835f26327ddf330EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Id, "id") ?? "id"}\" \"DayOfWeek.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Label, "label") ?? "label"}\" \"DayOfWeek.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Order, "order") ?? "order"}\" \"DayOfWeek.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"DayOfWeek.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, "dayof_woucc4dity1bvqaltlkiu3b5"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Common, _EntityKeyConstants._CommonEntityKeys.@DayOfWeek, _EntityKeyConstants._CommonEntityKeys._DayOfWeekAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetDayOfWeek", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("DayOfWeek", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("1nsMDx8myUuHmDui2rw+jg"), 4 },
{ ObjectKey.Parse("kY7AQ3TxuU2f_3+5gfc8ig"), 3 },
{ ObjectKey.Parse("Mrs0SsB0XUC8pQkYB_+jdQ"), 6 },
{ ObjectKey.Parse("fXcRU14Tw0KpEyGcsdGD8A"), 7 },
{ ObjectKey.Parse("oJ71iHCygU2SWLzkYqzQnw"), 2 },
{ ObjectKey.Parse("+nqZrevxMEKU1RPmMF+MKw"), 5 },
{ ObjectKey.Parse("xR3AxwTY2U22wE1Pfvz_SQ"), 1 },

    };

    protected override Dictionary<int, EN_994a40086cd6e8196835f26327ddf330EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_994a40086cd6e8196835f26327ddf330EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

