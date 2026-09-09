using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENContractStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENContractStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractStatusAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._ContractStatusAttributeKeys.@Class, "class") ?? "class"}
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
switch (locale == null ? string.Empty : locale.ToLowerInvariant()) {
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, "contr_u8aqr95gpfevg_h07raxqmi1") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, "contr_u8aqr95gpfevg_h07raxqmi1") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ContractStatus, "contr_u8aqr95gpfevg_h07raxqmi1"));
}
}
} // ENContractStatusEntity
partial class ENContractStatusEntity : InMemoryStaticEntityRuntime<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, int> {
    

    private static ENContractStatusEntity instance = new();
    public static ENContractStatusEntity GetInstance() => instance;

    public static EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("eH4dRAbJ6UC4e3_BXQDcSA"), 3 },
{ ObjectKey.Parse("SaaicQI49kuIe5m54y8pXw"), 2 },
{ ObjectKey.Parse("U1S9wQhaL0uJ60HUozDQbg"), 1 },

    };

    protected override Dictionary<int, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> RecordIdToRecordMap { get; } = new() {
        {3, new() {
ssId = 3,
ssLabel = "Pending",
ssOrder = 3,
ssIs_Active = true,
ssClass = "pending",
}},
{2, new() {
ssId = 2,
ssLabel = "No",
ssOrder = 2,
ssIs_Active = true,
ssClass = "no",
}},
{1, new() {
ssId = 1,
ssLabel = "Yes",
ssOrder = 1,
ssIs_Active = true,
ssClass = "yes",
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{3, new() {
ssId = 3,
ssLabel = "Pendiente",
ssOrder = 3,
ssIs_Active = true,
ssClass = "pending",
}},
{2, new() {
ssId = 2,
ssLabel = "No",
ssOrder = 2,
ssIs_Active = true,
ssClass = "no",
}},
{1, new() {
ssId = 1,
ssLabel = "Sí",
ssOrder = 1,
ssIs_Active = true,
ssClass = "Sí",
}},
}},
{"en-US", new() {
{3, new() {
ssId = 3,
ssLabel = "Pending",
ssOrder = 3,
ssIs_Active = true,
ssClass = "pending",
}},
{2, new() {
ssId = 2,
ssLabel = "No",
ssOrder = 2,
ssIs_Active = true,
ssClass = "no",
}},
{1, new() {
ssId = 1,
ssLabel = "Yes",
ssOrder = 1,
ssIs_Active = true,
ssClass = "yes",
}},
}},

    };
}
}

