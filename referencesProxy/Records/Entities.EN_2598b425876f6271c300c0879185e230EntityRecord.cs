using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENCustomSettingsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCustomSettingsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Label, "label") ?? "label"},
{"description", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Description, "description") ?? "description"},
{"customsettingtypeid", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@CustomSettingTypeId, "customsettingtypeid") ?? "customsettingtypeid"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, "custo_ok7ot05vqror0uz5g4jbzyl2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCustomSettingsEntity
partial class ENCustomSettingsEntity : InMemoryStaticEntityRuntime<EN_2598b425876f6271c300c0879185e230EntityRecord, int> {
    

    private static ENCustomSettingsEntity instance = new();
    public static ENCustomSettingsEntity GetInstance() => instance;

    public static EN_2598b425876f6271c300c0879185e230EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static async Task<EN_2598b425876f6271c300c0879185e230EntityRecord> GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
var cancellationToken = CancellationToken.None;
var record = new EN_2598b425876f6271c300c0879185e230EntityRecord();
var sql = $"SELECT \"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Id, "id") ?? "id"}\" \"CustomSettings.Id\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Label, "label") ?? "label"}\" \"CustomSettings.Label\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Description, "description") ?? "description"}\" \"CustomSettings.Description\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@CustomSettingTypeId, "customsettingtypeid") ?? "customsettingtypeid"}\" \"CustomSettings.CustomSettingTypeId\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Order, "order") ?? "order"}\" \"CustomSettings.Order\",\"{TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Is_Active, "is_active") ?? "is_active"}\" \"CustomSettings.Is_Active\" FROM {BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, "custo_ok7ot05vqror0uz5g4jbzyl2"))} WHERE {TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, _EntityKeyConstants._OrganizationEntityKeys._CustomSettingsAttributeKeys.@Id, "id") ?? "id"} = '{meta}'";
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
await using(var sqlCmd = trans.CreateCommand(sql)){
sqlCmd.CreateParameter("@objectKey", DbType.String, key.ToString());
using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetCustomSettings", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (reader.Read()) {
                        record.ReadDB(reader);
                        record.AllOptimizedAttributes = new BitArray[] { new(2, false) };
                    } else {
                        throw DatabaseErrorsHelper.EntityRecordNotFound("CustomSettings", key.ToString());
                    }
}}}
return record;
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("NQBpEcr+gU2AKHeNOe8c_A"), 3 },
{ ObjectKey.Parse("xqIyHYvXoEaq+G+cdvFWZQ"), 5 },
{ ObjectKey.Parse("_glcIepsI0CGZq8_yES5Pg"), 8 },
{ ObjectKey.Parse("HG0cJd6cPUm+ObwfNHn6bg"), 9 },
{ ObjectKey.Parse("s+d0ZJgFqECIKIO_PNItXQ"), 10 },
{ ObjectKey.Parse("acv7nLO_PkWFqgs8f_8qfw"), 4 },
{ ObjectKey.Parse("1lv_nvQES0mvPmOrtn5Bbg"), 7 },
{ ObjectKey.Parse("soqhw0qz10epdyiJhc62sw"), 1 },
{ ObjectKey.Parse("hGg471qKi0+dvf_8qKwcwg"), 6 },
{ ObjectKey.Parse("IMFw8Dwoz0K5TAuDyJjmGw"), 2 },

    };

    protected override Dictionary<int, EN_2598b425876f6271c300c0879185e230EntityRecord> RecordIdToRecordMap { get; } = new() {
        
    };

    protected override Dictionary<string, Dictionary<int, EN_2598b425876f6271c300c0879185e230EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

