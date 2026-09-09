using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENSpecialPostDeliveryAuthorizationEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpecialPostDeliveryAuthorizationEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, "speci_ok7ot05vqros5tbmhixsa2x2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSpecialPostDeliveryAuthorizationEntity
partial class ENSpecialPostDeliveryAuthorizationEntity : InMemoryStaticEntityRuntime<EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord, int> {
    

    private static ENSpecialPostDeliveryAuthorizationEntity instance = new();
    public static ENSpecialPostDeliveryAuthorizationEntity GetInstance() => instance;

    public static EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Id, "id") ?? "id"}\" \"SpecialPostDeliveryAuthorization.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Label, "label") ?? "label"}\" \"SpecialPostDeliveryAuthorization.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Order, "order") ?? "order"}\" \"SpecialPostDeliveryAuthorization.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"SpecialPostDeliveryAuthorization.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, "speci_ok7ot05vqros5tbmhixsa2x2"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, _EntityKeyConstants._OrganizationEntityKeys._SpecialPostDeliveryAuthorizationAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetSpecialPostDeliveryAuthorization", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("SpecialPostDeliveryAuthorization", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("J7VZWUFJD0OF7+hZsTXu6g"), 2 },
{ ObjectKey.Parse("Q69g3V8r30i9+8mlmbAAsg"), 1 },

    };

    protected override Dictionary<int, EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

