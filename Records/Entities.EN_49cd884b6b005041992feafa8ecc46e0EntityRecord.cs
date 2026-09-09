using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceAccountingProcessStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceAccountingProcessStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceAccountingProcessStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, "invoi_u8aqr95gpfeojd2bxj_uha76") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, "invoi_u8aqr95gpfeojd2bxj_uha76") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceAccountingProcessStatus, "invoi_u8aqr95gpfeojd2bxj_uha76"));
}
}
} // ENInvoiceAccountingProcessStatusEntity
partial class ENInvoiceAccountingProcessStatusEntity : InMemoryStaticEntityRuntime<EN_49cd884b6b005041992feafa8ecc46e0EntityRecord, int> {
    

    private static ENInvoiceAccountingProcessStatusEntity instance = new();
    public static ENInvoiceAccountingProcessStatusEntity GetInstance() => instance;

    public static EN_49cd884b6b005041992feafa8ecc46e0EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_49cd884b6b005041992feafa8ecc46e0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"), 2 },
{ ObjectKey.Parse("b9Zmzw8_MUyampVTkJ_ulw"), 3 },
{ ObjectKey.Parse("Tc6389H3X0+sBfcYBvMR1g"), 1 },

    };

    protected override Dictionary<int, EN_49cd884b6b005041992feafa8ecc46e0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {2, new() {
ssId = 2,
ssLabel = "Ongoing",
ssOrder = 2,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Finished",
ssOrder = 3,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Pending",
ssOrder = 1,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_49cd884b6b005041992feafa8ecc46e0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{2, new() {
ssId = 2,
ssLabel = "En curso",
ssOrder = 2,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Finalizada",
ssOrder = 3,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Pendiente",
ssOrder = 1,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{2, new() {
ssId = 2,
ssLabel = "Ongoing",
ssOrder = 2,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Finished",
ssOrder = 3,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Pending",
ssOrder = 1,
ssIs_Active = true,
}},
}},

    };
}
}

