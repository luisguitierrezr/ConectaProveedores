using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENCommentTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENCommentTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, _EntityKeyConstants._ConectaProveedoresEntityKeys._CommentTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, _EntityKeyConstants._ConectaProveedoresEntityKeys._CommentTypeAttributeKeys.@Label, "label") ?? "label"},
{"class", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, _EntityKeyConstants._ConectaProveedoresEntityKeys._CommentTypeAttributeKeys.@Class, "class") ?? "class"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, _EntityKeyConstants._ConectaProveedoresEntityKeys._CommentTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, _EntityKeyConstants._ConectaProveedoresEntityKeys._CommentTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, "comme_u8aqr95gpfeto7yfqz22wdm6") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, "comme_u8aqr95gpfeto7yfqz22wdm6") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@CommentType, "comme_u8aqr95gpfeto7yfqz22wdm6"));
}
}
} // ENCommentTypeEntity
partial class ENCommentTypeEntity : InMemoryStaticEntityRuntime<EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord, int> {
    

    private static ENCommentTypeEntity instance = new();
    public static ENCommentTypeEntity GetInstance() => instance;

    public static EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("SHDqGuLAPU2VN+umI1VGkQ"), 2 },
{ ObjectKey.Parse("Q+rGOvxr0UWakrrNEZeW8g"), 5 },
{ ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"), 1 },
{ ObjectKey.Parse("fWPpinJz1EuuskuhosoYJA"), 6 },
{ ObjectKey.Parse("Yb_2rORMO0CiONuueCSezA"), 3 },
{ ObjectKey.Parse("qajvy+SdnE6bqldjFZvPIg"), 4 },

    };

    protected override Dictionary<int, EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord> RecordIdToRecordMap { get; } = new() {
        {2, new() {
ssId = 2,
ssLabel = "Observation",
ssClass = "observation",
ssOrder = 2,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Modify",
ssClass = "modifyreq",
ssOrder = 5,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Reject",
ssClass = "rejectapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Evidence Request",
ssClass = "rejectapproval",
ssOrder = 6,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Not Paid",
ssClass = "linenotpaid",
ssOrder = 3,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Cancel",
ssClass = "cancelproposal",
ssOrder = 4,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_4a2f5f1859128b4b2b0510202ed51258EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{2, new() {
ssId = 2,
ssLabel = "Observación",
ssClass = "observation",
ssOrder = 2,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Pedido de Modificación",
ssClass = "modifyreq",
ssOrder = 5,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Rechazar",
ssClass = "rejectapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Evidence Solicitada",
ssClass = "rejectapproval",
ssOrder = 6,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "No Pagado",
ssClass = "linenotpaid",
ssOrder = 3,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Cancelar",
ssClass = "cancelproposal",
ssOrder = 4,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{2, new() {
ssId = 2,
ssLabel = "Observation",
ssClass = "observation",
ssOrder = 2,
ssIs_Active = true,
}},
{5, new() {
ssId = 5,
ssLabel = "Modify",
ssClass = "modifyreq",
ssOrder = 5,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Reject",
ssClass = "rejectapproval",
ssOrder = 1,
ssIs_Active = true,
}},
{6, new() {
ssId = 6,
ssLabel = "Evidence Request",
ssClass = "rejectapproval",
ssOrder = 6,
ssIs_Active = true,
}},
{3, new() {
ssId = 3,
ssLabel = "Not Paid",
ssClass = "linenotpaid",
ssOrder = 3,
ssIs_Active = true,
}},
{4, new() {
ssId = 4,
ssLabel = "Cancel",
ssClass = "cancelproposal",
ssOrder = 4,
ssIs_Active = true,
}},
}},

    };
}
}

