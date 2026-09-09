using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENActivityStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENActivityStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@ActivityStatus, _EntityKeyConstants._System_EntityKeys._ActivityStatusAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@ActivityStatus, _EntityKeyConstants._System_EntityKeys._ActivityStatusAttributeKeys.@Name, "name") ?? "name"}
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
default :
int pos;
if (!string.IsNullOrEmpty(locale) && ((pos = locale.IndexOf('-')) > 0))
return ViewName(locale.Substring(0, pos));
else
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@ActivityStatus, "osvue_activity_status"));
}
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("478870b9-2d60-4f73-9eb3-7cd8b994a737");
} // ENActivityStatusEntity
partial class ENActivityStatusEntity : InMemoryStaticEntityRuntime<ENActivityStatusEntityRecord, long> {
    

    private static ENActivityStatusEntity instance = new();
    public static ENActivityStatusEntity GetInstance() => instance;

    public static ENActivityStatusEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENActivityStatusEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("kwzSV6NM4UWJMJbgO5Aakg"), Convert.ToInt64(2) },
{ ObjectKey.Parse("XMFEXUppE06y3quF903xFA"), Convert.ToInt64(4) },
{ ObjectKey.Parse("M9zrhm_Kl0+Hc6tRJwI0og"), Convert.ToInt64(1) },
{ ObjectKey.Parse("GoVFlP_JiU6nSEbyQl9y+Q"), Convert.ToInt64(6) },
{ ObjectKey.Parse("4zAIpD1+20GYc12p9P94dQ"), Convert.ToInt64(5) },
{ ObjectKey.Parse("nBzO1q+gL0iQQOJXk7T+6A"), Convert.ToInt64(3) },

    };

    protected override Dictionary<long, ENActivityStatusEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "Running",
}},
{Convert.ToInt64(4), new() {
ssId = Convert.ToInt64(4),
ssName = "Terminated",
}},
{Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "Waiting",
}},
{Convert.ToInt64(6), new() {
ssId = Convert.ToInt64(6),
ssName = "Open",
}},
{Convert.ToInt64(5), new() {
ssId = Convert.ToInt64(5),
ssName = "Error",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "Completed",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENActivityStatusEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

