using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENAIContentTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAIContentTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@_System, _EntityKeyConstants.__SystemEntityKeys.@AIContentType, _EntityKeyConstants.__SystemEntityKeys._AIContentTypeAttributeKeys.@Id, "id") ?? "id"},
{"name", TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@_System, _EntityKeyConstants.__SystemEntityKeys.@AIContentType, _EntityKeyConstants.__SystemEntityKeys._AIContentTypeAttributeKeys.@Name, "name") ?? "name"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@_System, _EntityKeyConstants.__SystemEntityKeys.@AIContentType, "osvue_ai_content_type"));
}
} // ENAIContentTypeEntity
partial class ENAIContentTypeEntity : InMemoryStaticEntityRuntime<ENAIContentTypeEntityRecord, long> {
    

    private static ENAIContentTypeEntity instance = new();
    public static ENAIContentTypeEntity GetInstance() => instance;

    public static ENAIContentTypeEntityRecord GetRecordById(long id) {
return instance.GetRecord(id);
}

    public static ENAIContentTypeEntityRecord GetRecordByKey(ObjectKey key) {
if(!instance.TryGetRecordIdentifierByKey(key, out var meta)) {
throw DatabaseErrorsHelper.StaticEntityRecordMetadataNotFound(ViewName(string.Empty), ObjectKeyUtils.DatabaseValue(key));
}
return instance.GetRecord(meta);
}


    protected override Dictionary<ObjectKey, long> RecordKeyToIdMap { get; } = new() {
        { ObjectKey.Parse("w473PMttLk27+28jYJTy+A"), Convert.ToInt64(1) },
{ ObjectKey.Parse("7OAvHe81qEaBE_fw3r_MsQ"), Convert.ToInt64(2) },
{ ObjectKey.Parse("cG_97wBseU2bjFUuShIdug"), Convert.ToInt64(3) },

    };

    protected override Dictionary<long, ENAIContentTypeEntityRecord> RecordIdToRecordMap { get; } = new() {
        {Convert.ToInt64(1), new() {
ssId = Convert.ToInt64(1),
ssName = "TextContent",
}},
{Convert.ToInt64(2), new() {
ssId = Convert.ToInt64(2),
ssName = "ImageURL",
}},
{Convert.ToInt64(3), new() {
ssId = Convert.ToInt64(3),
ssName = "ImageBinary",
}},

    };

    protected override Dictionary<string, Dictionary<long, ENAIContentTypeEntityRecord>> LocaleToRecordIdMap { get; } = new() {
        
    };
}
}

