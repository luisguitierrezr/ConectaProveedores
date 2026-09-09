using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderStatusAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderStatusAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"labeles", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderStatusAttributeKeys.@LabelES, "labeles") ?? "labeles"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, "order_u8aqr95gpfe2eavx0mo4do_4") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, "order_u8aqr95gpfe2eavx0mo4do_4") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderStatus, "order_u8aqr95gpfe2eavx0mo4do_4"));
}
}
} // ENOrderStatusEntity
partial class ENOrderStatusEntity : InMemoryStaticEntityRuntime<EN_5eda60810da752f579e01795bb7e0de0EntityRecord, int> {
    

    private static ENOrderStatusEntity instance = new();
    public static ENOrderStatusEntity GetInstance() => instance;

    public static EN_5eda60810da752f579e01795bb7e0de0EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_5eda60810da752f579e01795bb7e0de0EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("7Z08Vke3o0m5iptrgiGvaA"), 11 },
{ ObjectKey.Parse("gqnAVya9FU+_7f97jQeuCA"), 5 },
{ ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"), 7 },
{ ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"), 9 },
{ ObjectKey.Parse("rQ22nid450ur93GrTIUjww"), 13 },
{ ObjectKey.Parse("XJxoo8RXb0K2bc9xcMC4lg"), 12 },
{ ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"), 1 },
{ ObjectKey.Parse("VWv8wVvrWkCMFHiCgUHKzw"), 14 },
{ ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"), 3 },
{ ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"), 4 },
{ ObjectKey.Parse("+y0n+52Y0kWtv1lCSYVl5g"), 10 },
{ ObjectKey.Parse("Kgcn_bjDWkCb8O8pyU20dQ"), 8 },

    };

    protected override Dictionary<int, EN_5eda60810da752f579e01795bb7e0de0EntityRecord> RecordIdToRecordMap { get; } = new() {
        {11, new() {
ssId = 11,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 9,
ssIs_Active = true,
ssLabelES = "Cancelado",
}},
{5, new() {
ssId = 5,
ssLabel = "In Approval CxP",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "En aprobación CxP",
}},
{7, new() {
ssId = 7,
ssLabel = "Approved CXP",
ssClass = "approved",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Aprobado CXP",
}},
{9, new() {
ssId = 9,
ssLabel = "Rejected",
ssClass = "rejected",
ssOrder = 7,
ssIs_Active = true,
ssLabelES = "Rechazado",
}},
{13, new() {
ssId = 13,
ssLabel = "Unreleased",
ssClass = "saved",
ssOrder = 11,
ssIs_Active = true,
ssLabelES = "Sin Liberar",
}},
{12, new() {
ssId = 12,
ssLabel = "Modify",
ssClass = "modify",
ssOrder = 10,
ssIs_Active = true,
ssLabelES = "Modificar",
}},
{1, new() {
ssId = 1,
ssLabel = "To Complement",
ssClass = "saved",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Para Complementar",
}},
{14, new() {
ssId = 14,
ssLabel = "Deleted",
ssClass = "canceled",
ssOrder = 12,
ssIs_Active = true,
ssLabelES = "Eliminado",
}},
{3, new() {
ssId = 3,
ssLabel = "In Information Completion",
ssClass = "submitted",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "En complemento de información",
}},
{4, new() {
ssId = 4,
ssLabel = "Rejected Distribution",
ssClass = "rejected",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Distribución rechazada",
}},
{10, new() {
ssId = 10,
ssLabel = "Released",
ssClass = "approved",
ssOrder = 8,
ssIs_Active = true,
ssLabelES = "Liberado",
}},
{8, new() {
ssId = 8,
ssLabel = "ErrorAPI",
ssClass = "errorAPI",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Error API",
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_5eda60810da752f579e01795bb7e0de0EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{11, new() {
ssId = 11,
ssLabel = "Cancelado",
ssClass = "canceled",
ssOrder = 9,
ssIs_Active = true,
ssLabelES = "Cancelado",
}},
{5, new() {
ssId = 5,
ssLabel = "En aprobación CxP",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "En aprobación CxP",
}},
{7, new() {
ssId = 7,
ssLabel = "Aprobado CXP",
ssClass = "approved",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Aprobado CXP",
}},
{9, new() {
ssId = 9,
ssLabel = "Rechazado",
ssClass = "rejected",
ssOrder = 7,
ssIs_Active = true,
ssLabelES = "Rechazado",
}},
{13, new() {
ssId = 13,
ssLabel = "Sin Liberar",
ssClass = "saved",
ssOrder = 11,
ssIs_Active = true,
ssLabelES = "Sin Liberar",
}},
{12, new() {
ssId = 12,
ssLabel = "Modificar",
ssClass = "modify",
ssOrder = 10,
ssIs_Active = true,
ssLabelES = "Modificar",
}},
{1, new() {
ssId = 1,
ssLabel = "Para Complementar",
ssClass = "saved",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Para Complementar",
}},
{14, new() {
ssId = 14,
ssLabel = "Eliminado",
ssClass = "canceled",
ssOrder = 12,
ssIs_Active = true,
ssLabelES = "Eliminado",
}},
{3, new() {
ssId = 3,
ssLabel = "En complemento de información",
ssClass = "submitted",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "En complemento de información",
}},
{4, new() {
ssId = 4,
ssLabel = "Distribución rechazada",
ssClass = "rejected",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Distribución rechazada",
}},
{10, new() {
ssId = 10,
ssLabel = "Liberado",
ssClass = "approved",
ssOrder = 8,
ssIs_Active = true,
ssLabelES = "Liberado",
}},
{8, new() {
ssId = 8,
ssLabel = "Error API",
ssClass = "errorAPI",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Error API",
}},
}},
{"en-US", new() {
{11, new() {
ssId = 11,
ssLabel = "Canceled",
ssClass = "canceled",
ssOrder = 9,
ssIs_Active = true,
ssLabelES = "Cancelado",
}},
{5, new() {
ssId = 5,
ssLabel = "In Approval CxP",
ssClass = "inapproval",
ssOrder = 3,
ssIs_Active = true,
ssLabelES = "En aprobación CxP",
}},
{7, new() {
ssId = 7,
ssLabel = "Approved CXP",
ssClass = "approved",
ssOrder = 5,
ssIs_Active = true,
ssLabelES = "Aprobado CXP",
}},
{9, new() {
ssId = 9,
ssLabel = "Rechazado",
ssClass = "rejected",
ssOrder = 7,
ssIs_Active = true,
ssLabelES = "Rechazado",
}},
{13, new() {
ssId = 13,
ssLabel = "Unreleased",
ssClass = "saved",
ssOrder = 11,
ssIs_Active = true,
ssLabelES = "Sin Liberar",
}},
{12, new() {
ssId = 12,
ssLabel = "Modify",
ssClass = "modify",
ssOrder = 10,
ssIs_Active = true,
ssLabelES = "Modificar",
}},
{1, new() {
ssId = 1,
ssLabel = "To Complement",
ssClass = "saved",
ssOrder = 1,
ssIs_Active = true,
ssLabelES = "Para Complementar",
}},
{14, new() {
ssId = 14,
ssLabel = "Deleted",
ssClass = "canceled",
ssOrder = 12,
ssIs_Active = true,
ssLabelES = "Eliminado",
}},
{3, new() {
ssId = 3,
ssLabel = "In Information Completion",
ssClass = "submitted",
ssOrder = 2,
ssIs_Active = true,
ssLabelES = "En complemento de información",
}},
{4, new() {
ssId = 4,
ssLabel = "Rachazado",
ssClass = "rejected",
ssOrder = 4,
ssIs_Active = true,
ssLabelES = "Distribución rechazada",
}},
{10, new() {
ssId = 10,
ssLabel = "Released",
ssClass = "approved",
ssOrder = 8,
ssIs_Active = true,
ssLabelES = "Liberado",
}},
{8, new() {
ssId = 8,
ssLabel = "ErrorAPI",
ssClass = "errorAPI",
ssOrder = 6,
ssIs_Active = true,
ssLabelES = "Error API",
}},
}},

    };
}
}

