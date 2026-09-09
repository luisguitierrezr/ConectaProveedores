using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENInsuranceTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInsuranceTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, "insur_ok7ot05vqroqdx4ubmeo4eo7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENInsuranceTypeEntity
partial class ENInsuranceTypeEntity : InMemoryStaticEntityRuntime<EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord, int> {
    

    private static ENInsuranceTypeEntity instance = new();
    public static ENInsuranceTypeEntity GetInstance() => instance;

    public static EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Id, "id") ?? "id"}\" \"InsuranceType.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Label, "label") ?? "label"}\" \"InsuranceType.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Order, "order") ?? "order"}\" \"InsuranceType.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"InsuranceType.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, "insur_ok7ot05vqroqdx4ubmeo4eo7"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, _EntityKeyConstants._OrganizationEntityKeys._InsuranceTypeAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetInsuranceType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("InsuranceType", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("nib_dPJmAEavamGjbXuoSg"), 4 },
{ ObjectKey.Parse("U1p+rpq9kUOX8zroi3HA1g"), 1 },
{ ObjectKey.Parse("oosStkyMFkG5oFujJn91ig"), 3 },
{ ObjectKey.Parse("vVCo+0+T10K0CS0gHrYphw"), 2 },

    };

    protected override Dictionary<int, EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

