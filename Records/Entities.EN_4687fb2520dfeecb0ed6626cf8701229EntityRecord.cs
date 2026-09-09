using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrderRetentionTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrderRetentionTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRetentionTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRetentionTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRetentionTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRetentionTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"},
{"percentage", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderRetentionTypeAttributeKeys.@Percentage, "percentage") ?? "percentage"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, "order_u8aqr95gpfewmnmiduucnxp6") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, "order_u8aqr95gpfewmnmiduucnxp6") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderRetentionType, "order_u8aqr95gpfewmnmiduucnxp6"));
}
}
} // ENOrderRetentionTypeEntity
partial class ENOrderRetentionTypeEntity : InMemoryStaticEntityRuntime<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord, int> {
    

    private static ENOrderRetentionTypeEntity instance = new();
    public static ENOrderRetentionTypeEntity GetInstance() => instance;

    public static EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("YdMLJxjbuUOnoHH1M+m+Nw"), 3 },
{ ObjectKey.Parse("M8KxZNyZ+ECjPns_14H4gA"), 1 },
{ ObjectKey.Parse("24Go+JlbxUSaVuBTTiQ7Kg"), 4 },

    };

    protected override Dictionary<int, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> RecordIdToRecordMap { get; } = new() {
        {3, new() {
ssId = 3,
ssLabel = "25.00%",
ssOrder = 2,
ssIs_Active = true,
ssPercentage = 25.00m,
}},
{1, new() {
ssId = 1,
ssLabel = "10.00%",
ssOrder = 1,
ssIs_Active = true,
ssPercentage = 10.00m,
}},
{4, new() {
ssId = 4,
ssLabel = "Other",
ssOrder = 3,
ssIs_Active = true,
ssPercentage = 0.0M,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{3, new() {
ssId = 3,
ssLabel = "25.00%",
ssOrder = 2,
ssIs_Active = true,
ssPercentage = 25.00m,
}},
{1, new() {
ssId = 1,
ssLabel = "10.00%",
ssOrder = 1,
ssIs_Active = true,
ssPercentage = 10.00m,
}},
{4, new() {
ssId = 4,
ssLabel = "Otro",
ssOrder = 3,
ssIs_Active = true,
ssPercentage = 0.0M,
}},
}},
{"en-US", new() {
{3, new() {
ssId = 3,
ssLabel = "25.00%",
ssOrder = 2,
ssIs_Active = true,
ssPercentage = 25.00m,
}},
{1, new() {
ssId = 1,
ssLabel = "10.00%",
ssOrder = 1,
ssIs_Active = true,
ssPercentage = 10.00m,
}},
{4, new() {
ssId = 4,
ssLabel = "Other",
ssOrder = 3,
ssIs_Active = true,
ssPercentage = 0.0M,
}},
}},

    };
}
}

