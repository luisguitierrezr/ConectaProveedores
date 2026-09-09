using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFrequencyEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFrequencyEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, "frequ_ok7ot05vqropp6evudul9mf4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENFrequencyEntity
partial class ENFrequencyEntity : InMemoryStaticEntityRuntime<EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, int> {
    

    private static ENFrequencyEntity instance = new();
    public static ENFrequencyEntity GetInstance() => instance;

    public static EN_a6239c65aa61ed4530d18a92034301bbEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_a6239c65aa61ed4530d18a92034301bbEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Id, "id") ?? "id"}\" \"Frequency.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Label, "label") ?? "label"}\" \"Frequency.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Order, "order") ?? "order"}\" \"Frequency.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"Frequency.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, "frequ_ok7ot05vqropp6evudul9mf4"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, _EntityKeyConstants._OrganizationEntityKeys._FrequencyAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetFrequency", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("Frequency", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("udL4DmLosEGbIbbcexAlWg"), 4 },
{ ObjectKey.Parse("H_ZLSzOMvU+A0WlL2x4MPg"), 1 },
{ ObjectKey.Parse("i+4pV+OiD0WQEYphdmg6og"), 2 },
{ ObjectKey.Parse("EhMSeaNnPkCG500AW2GMWg"), 5 },
{ ObjectKey.Parse("E_dBeiQC7kqWgoexKZjmVQ"), 7 },
{ ObjectKey.Parse("OjRBoVwvzEW2x4WKhdUY4Q"), 8 },
{ ObjectKey.Parse("+ulkuKRKDEm9PTMA8E0upw"), 3 },
{ ObjectKey.Parse("swrj+_88QUCMhCiiwZ2GUQ"), 6 },

    };

    protected override Dictionary<int, EN_a6239c65aa61ed4530d18a92034301bbEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_a6239c65aa61ed4530d18a92034301bbEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

