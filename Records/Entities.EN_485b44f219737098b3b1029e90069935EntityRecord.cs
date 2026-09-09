using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENAdvancePaymentTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAdvancePaymentTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, "advan_ok7ot05vqrojc6gpla2r27i5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAdvancePaymentTypeEntity
partial class ENAdvancePaymentTypeEntity : InMemoryStaticEntityRuntime<EN_485b44f219737098b3b1029e90069935EntityRecord, int> {
    

    private static ENAdvancePaymentTypeEntity instance = new();
    public static ENAdvancePaymentTypeEntity GetInstance() => instance;

    public static EN_485b44f219737098b3b1029e90069935EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_485b44f219737098b3b1029e90069935EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_485b44f219737098b3b1029e90069935EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Id, "id") ?? "id"}\" \"AdvancePaymentType.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Label, "label") ?? "label"}\" \"AdvancePaymentType.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Order, "order") ?? "order"}\" \"AdvancePaymentType.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"AdvancePaymentType.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, "advan_ok7ot05vqrojc6gpla2r27i5"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, _EntityKeyConstants._OrganizationEntityKeys._AdvancePaymentTypeAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetAdvancePaymentType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("AdvancePaymentType", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("gbeHRVOuRECjlwCjJ9XnuA"), 1 },
{ ObjectKey.Parse("R8dUSUHKN0qAopc2pPY7zA"), 2 },

    };

    protected override Dictionary<int, EN_485b44f219737098b3b1029e90069935EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_485b44f219737098b3b1029e90069935EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

