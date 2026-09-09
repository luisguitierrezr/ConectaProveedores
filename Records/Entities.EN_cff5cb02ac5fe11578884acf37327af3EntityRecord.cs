using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceTaxTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceTaxTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceTaxTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceTaxTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceTaxTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceTaxTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, "invoi_u8aqr95gpfeq6l5jif_3coi4") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, "invoi_u8aqr95gpfeq6l5jif_3coi4") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceTaxType, "invoi_u8aqr95gpfeq6l5jif_3coi4"));
}
}
} // ENInvoiceTaxTypeEntity
partial class ENInvoiceTaxTypeEntity : InMemoryStaticEntityRuntime<EN_cff5cb02ac5fe11578884acf37327af3EntityRecord, int> {
    

    private static ENInvoiceTaxTypeEntity instance = new();
    public static ENInvoiceTaxTypeEntity GetInstance() => instance;

    public static EN_cff5cb02ac5fe11578884acf37327af3EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_cff5cb02ac5fe11578884acf37327af3EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"), 2 },
{ ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"), 1 },

    };

    protected override Dictionary<int, EN_cff5cb02ac5fe11578884acf37327af3EntityRecord> RecordIdToRecordMap { get; } = new() {
        {2, new() {
ssId = 2,
ssLabel = "Retencion",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Traslado",
ssOrder = 1,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_cff5cb02ac5fe11578884acf37327af3EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{2, new() {
ssId = 2,
ssLabel = "Retencion",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Traslado",
ssOrder = 1,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{2, new() {
ssId = 2,
ssLabel = "Retencion",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Traslado",
ssOrder = 1,
ssIs_Active = true,
}},
}},

    };
}
}

