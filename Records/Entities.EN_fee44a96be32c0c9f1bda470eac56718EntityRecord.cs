using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENRoleStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENRoleStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, "roles_e_ge42by2w4abk5tg49v3231"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENRoleStatusEntity
partial class ENRoleStatusEntity : InMemoryStaticEntityRuntime<EN_fee44a96be32c0c9f1bda470eac56718EntityRecord, int> {
    

    private static ENRoleStatusEntity instance = new();
    public static ENRoleStatusEntity GetInstance() => instance;

    public static EN_fee44a96be32c0c9f1bda470eac56718EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_fee44a96be32c0c9f1bda470eac56718EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Id, "id") ?? "id"}\" \"RoleStatus.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Label, "label") ?? "label"}\" \"RoleStatus.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Order, "order") ?? "order"}\" \"RoleStatus.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"RoleStatus.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, "roles_e_ge42by2w4abk5tg49v3231"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, _EntityKeyConstants._SecurityAuthEntityKeys._RoleStatusAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRoleStatus", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("RoleStatus", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("hfVxJzNA9UKD7YnqlzEUAA"), 1 },
{ ObjectKey.Parse("MyF8MQKC80ag52yLM39XSQ"), 3 },
{ ObjectKey.Parse("38jddeG670mF8aeZKzjIMw"), 4 },
{ ObjectKey.Parse("ZFhQenm_0EKkilgI6_J_0A"), 2 },

    };

    protected override Dictionary<int, EN_fee44a96be32c0c9f1bda470eac56718EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_fee44a96be32c0c9f1bda470eac56718EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

