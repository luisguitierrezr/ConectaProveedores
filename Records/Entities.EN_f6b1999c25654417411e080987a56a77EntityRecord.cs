using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENCFDITypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCFDITypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, "cfdit_ok7ot05vqromgb0f3bt2wec6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCFDITypeEntity
partial class ENCFDITypeEntity : InMemoryStaticEntityRuntime<EN_f6b1999c25654417411e080987a56a77EntityRecord, int> {
    

    private static ENCFDITypeEntity instance = new();
    public static ENCFDITypeEntity GetInstance() => instance;

    public static EN_f6b1999c25654417411e080987a56a77EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_f6b1999c25654417411e080987a56a77EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_f6b1999c25654417411e080987a56a77EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Id, "id") ?? "id"}\" \"CFDIType.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Label, "label") ?? "label"}\" \"CFDIType.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Order, "order") ?? "order"}\" \"CFDIType.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"CFDIType.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, "cfdit_ok7ot05vqromgb0f3bt2wec6"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, _EntityKeyConstants._OrganizationEntityKeys._CFDITypeAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetCFDIType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("CFDIType", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("DBkgX7sRZEitAS2QSg3bwQ"), 3 },
{ ObjectKey.Parse("Reb_l1g8dE+_qYK8SxP_5g"), 4 },
{ ObjectKey.Parse("neifzicrZEaUoCqDWQjjNA"), 1 },
{ ObjectKey.Parse("oqf3z9HYPkmnhynvbzqTUA"), 5 },
{ ObjectKey.Parse("bGK1_tDwu0qOihnkWwjSGQ"), 2 },

    };

    protected override Dictionary<int, EN_f6b1999c25654417411e080987a56a77EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_f6b1999c25654417411e080987a56a77EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

