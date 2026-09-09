using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENDistributionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDistributionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, "distr_ok7ot05vqrojz1odl8j3wxi1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENDistributionEntity
partial class ENDistributionEntity : InMemoryStaticEntityRuntime<EN_88460e7eac2a65d244abb23fe44af0adEntityRecord, int> {
    

    private static ENDistributionEntity instance = new();
    public static ENDistributionEntity GetInstance() => instance;

    public static EN_88460e7eac2a65d244abb23fe44af0adEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_88460e7eac2a65d244abb23fe44af0adEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Id, "id") ?? "id"}\" \"Distribution.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Label, "label") ?? "label"}\" \"Distribution.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Order, "order") ?? "order"}\" \"Distribution.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"Distribution.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, "distr_ok7ot05vqrojz1odl8j3wxi1"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, _EntityKeyConstants._OrganizationEntityKeys._DistributionAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetDistribution", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Distribution", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("CJSgVyQlWU6xRn7oVgtJpg"), 2 },
{ ObjectKey.Parse("1IA9mzc0B0WmdIBTNZ4YXQ"), 1 },

    };

    protected override Dictionary<int, EN_88460e7eac2a65d244abb23fe44af0adEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_88460e7eac2a65d244abb23fe44af0adEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

