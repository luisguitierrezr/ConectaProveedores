using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENFolioStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENFolioStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioStatusAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioStatusAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"labeles", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._FolioStatusAttributeKeys.@LabelES, "labeles") ?? "labeles"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, "folio_u8aqr95gpfe_nx3kkqk63z96") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, "folio_u8aqr95gpfe_nx3kkqk63z96") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@FolioStatus, "folio_u8aqr95gpfe_nx3kkqk63z96"));
}
}
} // ENFolioStatusEntity
partial class ENFolioStatusEntity : InMemoryStaticEntityRuntime<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, int> {
    

    private static ENFolioStatusEntity instance = new();
    public static ENFolioStatusEntity GetInstance() => instance;

    public static EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"), 1 },
{ ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"), 4 },
{ ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"), 6 },
{ ObjectKey.Parse("WhiUWVQy5E68vtmKmJU0KA"), 2 },
{ ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"), 3 },
{ ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"), 5 },
{ ObjectKey.Parse("hDfRi70FYEOh852aKLpDVA"), 7 },
{ ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"), 8 },
{ ObjectKey.Parse("Sibqk6dY7UGlZ5CDRDlXsg"), 12 },
{ ObjectKey.Parse("OvBzn51W8EyWJHs2cALRmQ"), 15 },
{ ObjectKey.Parse("ZfpLpTdXy0CRfRTjg6qPeA"), 14 },
{ ObjectKey.Parse("gO793L3rZ06FTArG1lVjpg"), 10 },
{ ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"), 9 },
{ ObjectKey.Parse("Di5a7BHsfkq06ZPVPBbZxg"), 11 },

    };

    protected override Dictionary<int, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> RecordIdToRecordMap { get; } = new() {
        {1, new() {
ssId = 1,
ssLabel = "Evidence Review",
ssClass = "pending",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Revisión de Evidencia",
}},
{4, new() {
ssId = 4,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Aprobado",
}},
{6, new() {
ssId = 6,
ssLabel = "Failed Entry Request",
ssClass = "fail-access",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Solicitud de entrada fallida",
}},
{2, new() {
ssId = 2,
ssLabel = "Evidence Requested",
ssClass = "modify",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "Evidencia Solicitada",
}},
{3, new() {
ssId = 3,
ssLabel = "PendingApproval",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "Pendiente de aprobación",
}},
{5, new() {
ssId = 5,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Cancelado",
}},
{7, new() {
ssId = 7,
ssLabel = "Failed Exit Request",
ssClass = "fail-exit",
ssOrder = 7,
ssIs_Active = true,
ssLabelES = "Solicitud de salida fallida",
}},
{8, new() {
ssId = 8,
ssLabel = "Pending Entry Request",
ssClass = "pending",
ssOrder = 8,
ssIs_Active = true,
ssLabelES = "En espera de solicitud de entrada",
}},
{12, new() {
ssId = 12,
ssLabel = "ContabilizationSuccess",
ssClass = "approved",
ssOrder = 12,
ssIs_Active = true,
ssLabelES = "Éxito Contabilidad",
}},
{15, new() {
ssId = 15,
ssLabel = "IncorrectInvoice",
ssClass = "rejected",
ssOrder = 14,
ssIs_Active = true,
ssLabelES = "Factura incorrecta",
}},
{14, new() {
ssId = 14,
ssLabel = "PendingApprovalAccounting",
ssClass = "inapproval",
ssOrder = 13,
ssIs_Active = true,
ssLabelES = "Pendiente de aprobación CxP",
}},
{10, new() {
ssId = 10,
ssLabel = "Approved Without Invoice",
ssClass = "approved-without-invoice",
ssOrder = 10,
ssIs_Active = true,
ssLabelES = "Aprobado sin factura vinculada",
}},
{9, new() {
ssId = 9,
ssLabel = "Canceled by Supplier",
ssClass = "canceled",
ssOrder = 9,
ssIs_Active = true,
ssLabelES = "Cancelado por el Proveedor",
}},
{11, new() {
ssId = 11,
ssLabel = "ContabilizationError",
ssClass = "rejected",
ssOrder = 11,
ssIs_Active = true,
ssLabelES = "Error Contabilidad",
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{1, new() {
ssId = 1,
ssLabel = "Revisión de Evidencia",
ssClass = "pending",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Revisión de Evidencia",
}},
{4, new() {
ssId = 4,
ssLabel = "Aprobado",
ssClass = "approved",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Aprobado",
}},
{6, new() {
ssId = 6,
ssLabel = "Solicitud de entrada fallida",
ssClass = "fail-access",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Solicitud de entrada fallida",
}},
{2, new() {
ssId = 2,
ssLabel = "Evidencia Solicitada",
ssClass = "modify",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "Evidencia Solicitada",
}},
{3, new() {
ssId = 3,
ssLabel = "Pendiente de aprobación",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "Pendiente de aprobación",
}},
{5, new() {
ssId = 5,
ssLabel = "Cancelado",
ssClass = "canceled",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Cancelado",
}},
{7, new() {
ssId = 7,
ssLabel = "Solicitud de salida fallida",
ssClass = "fail-exit",
ssOrder = 7,
ssIs_Active = true,
ssLabelES = "Solicitud de salida fallida",
}},
{8, new() {
ssId = 8,
ssLabel = "En espera de solicitud de entrada",
ssClass = "pending",
ssOrder = 8,
ssIs_Active = true,
ssLabelES = "En espera de solicitud de entrada",
}},
{12, new() {
ssId = 12,
ssLabel = "Éxito Contabilidad",
ssClass = "approved",
ssOrder = 12,
ssIs_Active = true,
ssLabelES = "Éxito Contabilidad",
}},
{15, new() {
ssId = 15,
ssLabel = "Factura incorrecta",
ssClass = "rejected",
ssOrder = 14,
ssIs_Active = true,
ssLabelES = "Factura incorrecta",
}},
{14, new() {
ssId = 14,
ssLabel = "Pendiente de aprobación CxP",
ssClass = "inapproval",
ssOrder = 13,
ssIs_Active = true,
ssLabelES = "Pendiente de aprobación CxP",
}},
{10, new() {
ssId = 10,
ssLabel = "Aprobado sin factura vinculada",
ssClass = "approved-without-invoice",
ssOrder = 10,
ssIs_Active = true,
ssLabelES = "Aprobado sin factura vinculada",
}},
{9, new() {
ssId = 9,
ssLabel = "Cancelado por el Proveedor",
ssClass = "canceled",
ssOrder = 9,
ssIs_Active = true,
ssLabelES = "Cancelado por el Proveedor",
}},
{11, new() {
ssId = 11,
ssLabel = "Error Contabilidad",
ssClass = "rejected",
ssOrder = 11,
ssIs_Active = true,
ssLabelES = "Error Contabilidad",
}},
}},
{"en-US", new() {
{1, new() {
ssId = 1,
ssLabel = "Evidence Review",
ssClass = "pending",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Revisión de Evidencia",
}},
{4, new() {
ssId = 4,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Aprobado",
}},
{6, new() {
ssId = 6,
ssLabel = "Failed Entry Request",
ssClass = "fail-access",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Solicitud de entrada fallida",
}},
{2, new() {
ssId = 2,
ssLabel = "Evidence Requested",
ssClass = "modify",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "Evidencia Solicitada",
}},
{3, new() {
ssId = 3,
ssLabel = "PendingApproval",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "Pendiente de aprobación",
}},
{5, new() {
ssId = 5,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Cancelado",
}},
{7, new() {
ssId = 7,
ssLabel = "Failed Exit Request",
ssClass = "fail-exit",
ssOrder = 7,
ssIs_Active = true,
ssLabelES = "Solicitud de salida fallida",
}},
{8, new() {
ssId = 8,
ssLabel = "Pending Entry Request",
ssClass = "pending",
ssOrder = 8,
ssIs_Active = true,
ssLabelES = "En espera de solicitud de entrada",
}},
{12, new() {
ssId = 12,
ssLabel = "ContabilizationSuccess",
ssClass = "approved",
ssOrder = 12,
ssIs_Active = true,
ssLabelES = "Éxito Contabilidad",
}},
{15, new() {
ssId = 15,
ssLabel = "IncorrectInvoice",
ssClass = "rejected",
ssOrder = 14,
ssIs_Active = true,
ssLabelES = "Factura incorrecta",
}},
{14, new() {
ssId = 14,
ssLabel = "PendingApprovalAccounting",
ssClass = "inapproval",
ssOrder = 13,
ssIs_Active = true,
ssLabelES = "Pendiente de aprobación CxP",
}},
{10, new() {
ssId = 10,
ssLabel = "Approved Without Invoice",
ssClass = "approved-without-invoice",
ssOrder = 10,
ssIs_Active = true,
ssLabelES = "Aprobado sin factura vinculada",
}},
{9, new() {
ssId = 9,
ssLabel = "Canceled by Supplier",
ssClass = "canceled",
ssOrder = 9,
ssIs_Active = true,
ssLabelES = "Cancelado por el Proveedor",
}},
{11, new() {
ssId = 11,
ssLabel = "ContabilizationError",
ssClass = "rejected",
ssOrder = 11,
ssIs_Active = true,
ssLabelES = "Error Contabilidad",
}},
}},

    };
}
}

