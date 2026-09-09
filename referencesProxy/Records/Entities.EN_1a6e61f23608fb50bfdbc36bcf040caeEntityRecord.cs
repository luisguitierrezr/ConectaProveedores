using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENAccountingDataTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccountingDataTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"isestim_equal_agreed", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@IsEstim_Equal_Agreed, "isestim_equal_agreed") ?? "isestim_equal_agreed"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, "estim_ok7ot05vqrot1x9s0vlynxf1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAccountingDataTypeEntity
partial class ENAccountingDataTypeEntity : InMemoryStaticEntityRuntime<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, int> {
    

    private static ENAccountingDataTypeEntity instance = new();
    public static ENAccountingDataTypeEntity GetInstance() => instance;

    public static EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Id, "id") ?? "id"}\" \"AccountingDataType.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Label, "label") ?? "label"}\" \"AccountingDataType.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Order, "order") ?? "order"}\" \"AccountingDataType.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"AccountingDataType.Is_Active\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@IsEstim_Equal_Agreed, "isestim_equal_agreed") ?? "isestim_equal_agreed"}\" \"AccountingDataType.IsEstim_Equal_Agreed\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, "estim_ok7ot05vqrot1x9s0vlynxf1"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, _EntityKeyConstants._OrganizationEntityKeys._AccountingDataTypeAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetAccountingDataType", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("AccountingDataType", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("9cmLAng_dEq3tq2sA7QEKA"), 1 },
{ ObjectKey.Parse("rW6wP6Y_E0+Wx3ClSCISGg"), 4 },
{ ObjectKey.Parse("XAAsRWshgEapYg9NyfZ4AQ"), 2 },
{ ObjectKey.Parse("x5Hcl2F2+0+t9vnZ5Uc_Wg"), 8 },
{ ObjectKey.Parse("SwcctndCbUKCFCSO_99adw"), 7 },
{ ObjectKey.Parse("o_zO9puX1EiZCeiZXtFAug"), 3 },
{ ObjectKey.Parse("1db59p24EEaRcf1D0Ihtjg"), 5 },
{ ObjectKey.Parse("z42U_9k0AEWNa_qGoCYO3w"), 6 },

    };

    protected override Dictionary<int, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

