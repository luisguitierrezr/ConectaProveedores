using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENInvoiceStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENInvoiceStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"isinaccounting", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@IsInAccounting, "isinaccounting") ?? "isinaccounting"},
{"labeles", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._InvoiceStatusAttributeKeys.@LabelES, "labeles") ?? "labeles"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, "invoi_u8aqr95gpfe1avmvxq7fi3t4") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, "invoi_u8aqr95gpfe1avmvxq7fi3t4") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@InvoiceStatus, "invoi_u8aqr95gpfe1avmvxq7fi3t4"));
}
}
} // ENInvoiceStatusEntity
partial class ENInvoiceStatusEntity : InMemoryStaticEntityRuntime<EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord, int> {
    

    private static ENInvoiceStatusEntity instance = new();
    public static ENInvoiceStatusEntity GetInstance() => instance;

    public static EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("J4p4BoSeP06EZmvoJ_ofhg"), 17 },
{ ObjectKey.Parse("+o3LB6D8JEaAPRwNpdwZag"), 11 },
{ ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"), 9 },
{ ObjectKey.Parse("clB7Cs6DQ0ebdBjstV8soA"), 7 },
{ ObjectKey.Parse("4NyjEZqqGEqzQUUvdWYJqw"), 10 },
{ ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"), 3 },
{ ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"), 1 },
{ ObjectKey.Parse("MCsBYwvZFUCwVOmkbA9eBw"), 2 },
{ ObjectKey.Parse("0rAQZBOb8Eyg7vnrS+suFw"), 5 },
{ ObjectKey.Parse("rN7AdMIY8UCc6++CrM79jQ"), 12 },
{ ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"), 6 },
{ ObjectKey.Parse("q0tYi3ZiTEKjRg2gCsYIDA"), 18 },
{ ObjectKey.Parse("CJKmpdl1bUqOtDMY59Vg9Q"), 13 },
{ ObjectKey.Parse("pWUau3x8lku6cvimchlK7g"), 8 },
{ ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"), 14 },
{ ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"), 4 },
{ ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"), 15 },

    };

    protected override Dictionary<int, EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord> RecordIdToRecordMap { get; } = new() {
        {17, new() {
ssId = 17,
ssLabel = "PendingAccounting",
ssClass = "modify",
ssOrder = 16,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilidad pendiente",
}},
{11, new() {
ssId = 11,
ssLabel = "Submitted",
ssClass = "modify",
ssOrder = 11,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Enviado",
}},
{9, new() {
ssId = 9,
ssLabel = "Modify",
ssClass = "modify",
ssOrder = 9,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Modificar",
}},
{7, new() {
ssId = 7,
ssLabel = "Pending Payment",
ssClass = "inapproval",
ssOrder = 7,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Pendiente de Pago",
}},
{10, new() {
ssId = 10,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 10,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Aprobada",
}},
{3, new() {
ssId = 3,
ssLabel = "In Approval (User Area)",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "En aprobación (Área usuaria)",
}},
{1, new() {
ssId = 1,
ssLabel = "Document Upload",
ssClass = "import",
ssOrder = 1,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Carga de documentos",
}},
{2, new() {
ssId = 2,
ssLabel = "Assign Initial Approver",
ssClass = "modify",
ssOrder = 2,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Designar Aprobador Inicial",
}},
{5, new() {
ssId = 5,
ssLabel = "Scheduled for Payment",
ssClass = "payments",
ssOrder = 5,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Programada para Pago",
}},
{12, new() {
ssId = 12,
ssLabel = "Rejected",
ssClass = "rejected",
ssOrder = 12,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Rechazada",
}},
{6, new() {
ssId = 6,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 6,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Cancelada",
}},
{18, new() {
ssId = 18,
ssLabel = "ManualAccounting",
ssClass = "modify",
ssOrder = 17,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilización Manual",
}},
{13, new() {
ssId = 13,
ssLabel = "Contabilization Error",
ssClass = "rejected",
ssOrder = 13,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Error Contabilidad",
}},
{8, new() {
ssId = 8,
ssLabel = "Paid",
ssClass = "paid",
ssOrder = 8,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Pagada",
}},
{14, new() {
ssId = 14,
ssLabel = "Contabilization Success",
ssClass = "approved",
ssOrder = 14,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilizado",
}},
{4, new() {
ssId = 4,
ssLabel = "In Approval (CxP)",
ssClass = "inapproval",
ssOrder = 4,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "En aprobación (CxP)",
}},
{15, new() {
ssId = 15,
ssLabel = "Accounting",
ssClass = "payments",
ssOrder = 15,
ssIs_Active = true,
ssIsInAccounting = true,
ssLabelES = "En contabilización",
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{17, new() {
ssId = 17,
ssLabel = "Contabilidad pendiente",
ssClass = "modify",
ssOrder = 16,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilidad pendiente",
}},
{11, new() {
ssId = 11,
ssLabel = "Enviado",
ssClass = "modify",
ssOrder = 11,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Enviado",
}},
{9, new() {
ssId = 9,
ssLabel = "Modificar",
ssClass = "modify",
ssOrder = 9,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Modificar",
}},
{7, new() {
ssId = 7,
ssLabel = "Pendiente de Pago",
ssClass = "inapproval",
ssOrder = 7,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Pendiente de Pago",
}},
{10, new() {
ssId = 10,
ssLabel = "Aprobada",
ssClass = "approved",
ssOrder = 10,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Aprobada",
}},
{3, new() {
ssId = 3,
ssLabel = "En aprobación (Área usuaria)",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "En aprobación (Área usuaria)",
}},
{1, new() {
ssId = 1,
ssLabel = "Carga de documentos",
ssClass = "import",
ssOrder = 1,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Carga de documentos",
}},
{2, new() {
ssId = 2,
ssLabel = "Designar Aprobador Inicial",
ssClass = "modify",
ssOrder = 2,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Designar Aprobador Inicial",
}},
{5, new() {
ssId = 5,
ssLabel = "Programada para Pago",
ssClass = "payments",
ssOrder = 5,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Programada para Pago",
}},
{12, new() {
ssId = 12,
ssLabel = "Rechazada",
ssClass = "rejected",
ssOrder = 12,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Rechazada",
}},
{6, new() {
ssId = 6,
ssLabel = "Cancelada",
ssClass = "canceled",
ssOrder = 6,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Cancelada",
}},
{18, new() {
ssId = 18,
ssLabel = "Contabilización Manual",
ssClass = "modify",
ssOrder = 17,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilización Manual",
}},
{13, new() {
ssId = 13,
ssLabel = "Error Contabilidad",
ssClass = "rejected",
ssOrder = 13,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Error Contabilidad",
}},
{8, new() {
ssId = 8,
ssLabel = "Pagada",
ssClass = "paid",
ssOrder = 8,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Pagada",
}},
{14, new() {
ssId = 14,
ssLabel = "Contabilizado",
ssClass = "approved",
ssOrder = 14,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilizado",
}},
{4, new() {
ssId = 4,
ssLabel = "En aprobación (CxP)",
ssClass = "inapproval",
ssOrder = 4,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "En aprobación (CxP)",
}},
{15, new() {
ssId = 15,
ssLabel = "En contabilización",
ssClass = "payments",
ssOrder = 15,
ssIs_Active = true,
ssIsInAccounting = true,
ssLabelES = "En contabilización",
}},
}},
{"en-US", new() {
{17, new() {
ssId = 17,
ssLabel = "PendingAccounting",
ssClass = "modify",
ssOrder = 16,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilidad pendiente",
}},
{11, new() {
ssId = 11,
ssLabel = "Submitted",
ssClass = "modify",
ssOrder = 11,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Enviado",
}},
{9, new() {
ssId = 9,
ssLabel = "Modify",
ssClass = "modify",
ssOrder = 9,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Modificar",
}},
{7, new() {
ssId = 7,
ssLabel = "Pending Payment",
ssClass = "inapproval",
ssOrder = 7,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Pendiente de Pago",
}},
{10, new() {
ssId = 10,
ssLabel = "Approved",
ssClass = "approved",
ssOrder = 10,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Aprobada",
}},
{3, new() {
ssId = 3,
ssLabel = "In Approval (User Area)",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "En aprobación (Área usuaria)",
}},
{1, new() {
ssId = 1,
ssLabel = "Document Upload",
ssClass = "import",
ssOrder = 1,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Carga de documentos",
}},
{2, new() {
ssId = 2,
ssLabel = "Assign Initial Approver",
ssClass = "modify",
ssOrder = 2,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Designar Aprobador Inicial",
}},
{5, new() {
ssId = 5,
ssLabel = "Scheduled for Payment",
ssClass = "payments",
ssOrder = 5,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Programada para Pago",
}},
{12, new() {
ssId = 12,
ssLabel = "Rejected",
ssClass = "rejected",
ssOrder = 12,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Rechazada",
}},
{6, new() {
ssId = 6,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 6,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Cancelada",
}},
{18, new() {
ssId = 18,
ssLabel = "ManualAccounting",
ssClass = "modify",
ssOrder = 17,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilización Manual",
}},
{13, new() {
ssId = 13,
ssLabel = "Contabilization Error",
ssClass = "rejected",
ssOrder = 13,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Error Contabilidad",
}},
{8, new() {
ssId = 8,
ssLabel = "Paid",
ssClass = "paid",
ssOrder = 8,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Pagada",
}},
{14, new() {
ssId = 14,
ssLabel = "Contabilization Success",
ssClass = "approved",
ssOrder = 14,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "Contabilizado",
}},
{4, new() {
ssId = 4,
ssLabel = "In Approval (CxP)",
ssClass = "inapproval",
ssOrder = 4,
ssIs_Active = true,
ssIsInAccounting = false,
ssLabelES = "En aprobación (CxP)",
}},
{15, new() {
ssId = 15,
ssLabel = "Accounting",
ssClass = "payments",
ssOrder = 15,
ssIs_Active = true,
ssIsInAccounting = true,
ssLabelES = "En contabilización",
}},
}},

    };
}
}

