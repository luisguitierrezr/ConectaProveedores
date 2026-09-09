using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENUserAreaEntity {
private static readonly ActivitySource activitySource = new(typeof(ENUserAreaEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, "usera_ok7ot05vqroxrhvmkdsh5v91"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENUserAreaEntity
partial class ENUserAreaEntity : InMemoryStaticEntityRuntime<EN_91436b6b897297e560f42a1f2d0c865cEntityRecord, int> {
    

    private static ENUserAreaEntity instance = new();
    public static ENUserAreaEntity GetInstance() => instance;

    public static EN_91436b6b897297e560f42a1f2d0c865cEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_91436b6b897297e560f42a1f2d0c865cEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_91436b6b897297e560f42a1f2d0c865cEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Id, "id") ?? "id"}\" \"UserArea.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Label, "label") ?? "label"}\" \"UserArea.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Order, "order") ?? "order"}\" \"UserArea.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"UserArea.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, "usera_ok7ot05vqroxrhvmkdsh5v91"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, _EntityKeyConstants._OrganizationEntityKeys._UserAreaAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetUserArea", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("UserArea", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("2txKL5lsXkK9+BycNJ0y9A"), 2 },
{ ObjectKey.Parse("6V0rPlwEt06J9l8TxyiYaQ"), 1 },
{ ObjectKey.Parse("EjUQdHJF3kCv+hlt4bNa8g"), 3 },

    };

    protected override Dictionary<int, EN_91436b6b897297e560f42a1f2d0c865cEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_91436b6b897297e560f42a1f2d0c865cEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

