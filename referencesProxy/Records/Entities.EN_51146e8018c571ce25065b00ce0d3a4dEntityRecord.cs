using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENApprovalProcessTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENApprovalProcessTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Label, "label") ?? "label"},
{"label_es", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Label_ES, "label_es") ?? "label_es"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, "appro_ok7ot05vqroqd6np8hzb3z75"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENApprovalProcessTypeEntity
partial class ENApprovalProcessTypeEntity : InMemoryStaticEntityRuntime<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord, int> {
    

    private static ENApprovalProcessTypeEntity instance = new();
    public static ENApprovalProcessTypeEntity GetInstance() => instance;

    public static EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Id, "id") ?? "id"}\" \"ApprovalProcessType.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Label, "label") ?? "label"}\" \"ApprovalProcessType.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Label_ES, "label_es") ?? "label_es"}\" \"ApprovalProcessType.Label_ES\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Order, "order") ?? "order"}\" \"ApprovalProcessType.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"ApprovalProcessType.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, "appro_ok7ot05vqroqd6np8hzb3z75"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, _EntityKeyConstants._OrganizationEntityKeys._ApprovalProcessTypeAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetApprovalProcessType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("ApprovalProcessType", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("IbBTDwMiLk6pByOEQnONFA"), 3 },
{ ObjectKey.Parse("KMoVNOLGyU6MQcztIWYokg"), 4 },
{ ObjectKey.Parse("inIJWK9ll0CyGEmbObmkIQ"), 2 },
{ ObjectKey.Parse("5FI9qsQZQ0CckJxUIWoeDw"), 1 },

    };

    protected override Dictionary<int, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

