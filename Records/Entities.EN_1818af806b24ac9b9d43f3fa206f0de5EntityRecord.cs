using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderMainItemStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderMainItemStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemStatusAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemStatusAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemStatusAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemStatusAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemStatusAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, "order_u8aqr95gpfeopzn3ay_g7yf0") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, "order_u8aqr95gpfeopzn3ay_g7yf0") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItemStatus, "order_u8aqr95gpfeopzn3ay_g7yf0"));
}
}
} // ENOrderMainItemStatusEntity
partial class ENOrderMainItemStatusEntity : InMemoryStaticEntityRuntime<EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord, int> {
    

    private static ENOrderMainItemStatusEntity instance = new();
    public static ENOrderMainItemStatusEntity GetInstance() => instance;

    public static EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("DQeZJv62Bkuw1ZQnlDoWSA"), 4 },
{ ObjectKey.Parse("Ca+WgIpOj0CuJbhSpYSjFw"), 1 },
{ ObjectKey.Parse("QSotuynu30q9__cTsHdo9w"), 5 },
{ ObjectKey.Parse("q+0xyofPL0GD2X9+XONdig"), 3 },
{ ObjectKey.Parse("hBWk5oOUvEGgX1TBwwb56g"), 2 },

    };

    protected override Dictionary<int, EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord> RecordIdToRecordMap { get; } = new() {
        {4, new() {
ssId = 4,
ssLabel = "Deleted",
ssClass = "rejected",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Not Delivered",
ssClass = "inapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Blocked",
ssClass = "submitted",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Delivered",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Partially Delivered",
ssClass = "submitted",
ssOrder = 2,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{4, new() {
ssId = 4,
ssLabel = "Eliminado",
ssClass = "rejected",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "No Entregado",
ssClass = "inapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Bloqueado",
ssClass = "submitted",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Entregado",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Entrega parcial",
ssClass = "submitted",
ssOrder = 2,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{4, new() {
ssId = 4,
ssLabel = "Deleted",
ssClass = "rejected",
ssOrder = 4,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Not Delivered",
ssClass = "inapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Blocked",
ssClass = "submitted",
ssOrder = 5,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Delivered",
ssClass = "approved",
ssOrder = 3,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Partially Delivered",
ssClass = "submitted",
ssOrder = 2,
ssIs_Active = true,
}},
}},

    };
}
}

