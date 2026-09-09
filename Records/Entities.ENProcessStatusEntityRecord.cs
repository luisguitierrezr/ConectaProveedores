using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENProcessStatusEntity {
private static readonly ActivitySource activitySource = new(typeof(ENProcessStatusEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@ProcessStatus, _EntityKeyConstants._System_EntityKeys._ProcessStatusAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@ProcessStatus, _EntityKeyConstants._System_EntityKeys._ProcessStatusAttributeKeys.@Name, "name") ?? "name"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@System_, _EntityKeyConstants._System_EntityKeys.@ProcessStatus, "osvue_process_status"));
}
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("478870b9-2d60-4f73-9eb3-7cd8b994a737");
} // ENProcessStatusEntity
partial class ENProcessStatusEntity : InMemoryStaticEntityRuntime<ENProcessStatusEntityRecord, long> {
    

    private static ENProcessStatusEntity instance = new();
    public static ENProcessStatusEntity GetInstance() => instance;

    public static ENProcessStatusEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENProcessStatusEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("HK7HI_G6S0elndZtDcw+GQ"), Convert.ToInt64(1) },
{ ObjectKey.Parse("MnrlLBHIHEG_dtKIhlB4EQ"), Convert.ToInt64(2) },
{ ObjectKey.Parse("A78nqezbL0qVedRsBQPioQ"), Convert.ToInt64(4) },
{ ObjectKey.Parse("lZ5puamKn0GSjJog96He1A"), Convert.ToInt64(3) },

    };

    protected override Dictionary<long, ENProcessStatusEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "Active",
}},
{Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "ActiveWithErrors",
}},
{Convert.ToInt64(4), new() {
ssId = Convert.ToInt64(4),
ssName = "Terminated",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "Done",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENProcessStatusEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

