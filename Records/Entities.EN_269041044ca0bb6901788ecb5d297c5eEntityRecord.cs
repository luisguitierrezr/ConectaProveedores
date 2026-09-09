using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSpecialApprovalEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpecialApprovalEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._SpecialApprovalAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._SpecialApprovalAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._SpecialApprovalAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, _EntityKeyConstants._ConectaProveedoresEntityKeys._SpecialApprovalAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, "speci_u8aqr95gpfeyil44nl067423") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, "speci_u8aqr95gpfeyil44nl067423") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@SpecialApproval, "speci_u8aqr95gpfeyil44nl067423"));
}
}
} // ENSpecialApprovalEntity
partial class ENSpecialApprovalEntity : InMemoryStaticEntityRuntime<EN_269041044ca0bb6901788ecb5d297c5eEntityRecord, int> {
    

    private static ENSpecialApprovalEntity instance = new();
    public static ENSpecialApprovalEntity GetInstance() => instance;

    public static EN_269041044ca0bb6901788ecb5d297c5eEntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_269041044ca0bb6901788ecb5d297c5eEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("hmBDX1i+ZkmxK06FRay66Q"), 1 },
{ ObjectKey.Parse("1OIcY7z3LUqQcvrIxJHgaA"), 2 },

    };

    protected override Dictionary<int, EN_269041044ca0bb6901788ecb5d297c5eEntityRecord> RecordIdToRecordMap { get; } = new() {
        {1, new() {
ssId = 1,
ssLabel = "Applies",
ssOrder = 1,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Not Applicable",
ssOrder = 2,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_269041044ca0bb6901788ecb5d297c5eEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{1, new() {
ssId = 1,
ssLabel = "Aplica",
ssOrder = 1,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "No Aplica",
ssOrder = 2,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{1, new() {
ssId = 1,
ssLabel = "Applies",
ssOrder = 1,
ssIs_Active = true,
}},
{2, new() {
ssId = 2,
ssLabel = "Not Applicable",
ssOrder = 2,
ssIs_Active = true,
}},
}},

    };
}
}

