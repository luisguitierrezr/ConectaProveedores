using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProposalTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProposalTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Id, "id") ?? "id"},
{"label", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Label, "label") ?? "label"},
{"order", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Order, "order") ?? "order"},
{"is_active", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, _EntityKeyConstants._ConectaProveedoresEntityKeys._ProposalTypeAttributeKeys.@Is_Active, "is_active") ?? "is_active"}
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
case "es-mx": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, "proce_u8aqr95gpfezt8ou5_r74rv4") + "_ml_es_MX");
case "en-us": return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, "proce_u8aqr95gpfezt8ou5_r74rv4") + "_ml_en_US");
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@ProposalType, "proce_u8aqr95gpfezt8ou5_r74rv4"));
}
}
} // ENProposalTypeEntity
partial class ENProposalTypeEntity : InMemoryStaticEntityRuntime<EN_7de728375ec552c47f71bca85f9991d9EntityRecord, int> {
    

    private static ENProposalTypeEntity instance = new();
    public static ENProposalTypeEntity GetInstance() => instance;

    public static EN_7de728375ec552c47f71bca85f9991d9EntityRecord GetRecordById(int id) {
return instance.GetRecord(id);
}

    public static EN_7de728375ec552c47f71bca85f9991d9EntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, int> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("+yIDjJu2pUaWuy5b+63dBA"), 2 },
{ ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"), 1 },

    };

    protected override Dictionary<int, EN_7de728375ec552c47f71bca85f9991d9EntityRecord> RecordIdToRecordMap { get; } = new() {
        {2, new() {
ssId = 2,
ssLabel = "Lease",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Comission",
ssOrder = 1,
ssIs_Active = true,
}},

    };

    protected override Dictionary<string, Dictionary<int, EN_7de728375ec552c47f71bca85f9991d9EntityRecord>> LocaleToRecordIdMap { get; } = new() {
        {"es-MX", new() {
{2, new() {
ssId = 2,
ssLabel = "Arrendamientos",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Comisiones",
ssOrder = 1,
ssIs_Active = true,
}},
}},
{"en-US", new() {
{2, new() {
ssId = 2,
ssLabel = "Lease",
ssOrder = 2,
ssIs_Active = true,
}},
{1, new() {
ssId = 1,
ssLabel = "Comission",
ssOrder = 1,
ssIs_Active = true,
}},
}},

    };
}
}

