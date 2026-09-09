using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENAppConceptEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAppConceptEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, "appco_ok7ot05vqrox9u04cv0z6k97"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAppConceptEntity
partial class ENAppConceptEntity : InMemoryStaticEntityRuntime<EN_01808938be8d2f648d79d661d64023eaEntityRecord, int> {
    

    private static ENAppConceptEntity instance = new();
    public static ENAppConceptEntity GetInstance() => instance;

    public static EN_01808938be8d2f648d79d661d64023eaEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_01808938be8d2f648d79d661d64023eaEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_01808938be8d2f648d79d661d64023eaEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Id, "id") ?? "id"}\" \"AppConcept.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Label, "label") ?? "label"}\" \"AppConcept.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Order, "order") ?? "order"}\" \"AppConcept.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"AppConcept.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, "appco_ok7ot05vqrox9u04cv0z6k97"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, _EntityKeyConstants._OrganizationEntityKeys._AppConceptAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetAppConcept", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("AppConcept", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("YSILcj+jBkWezv4YFmxMXg"), 2 },
{ ObjectKey.Parse("MlP1l+JQTkWVit0A65Z4bg"), 1 },

    };

    protected override Dictionary<int, EN_01808938be8d2f648d79d661d64023eaEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_01808938be8d2f648d79d661d64023eaEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

