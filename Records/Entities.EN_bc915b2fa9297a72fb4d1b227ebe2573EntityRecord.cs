using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENSpaceEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSpaceEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"space", "space"},
{"order", "order"}
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
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8be17f2a-431c-4958-b894-c77b988a7271");
} // ENSpaceEntity
/// <summary>
/// Static Entity <code>ENSpaceEntity</code> gets the values for this static entity records in runtime
///  <code>Space</code>
/// </summary>
    partial class ENSpaceEntity {
        

        public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetRecordById(string id) {
return (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord) RsseSpaceOutSystemsUI.ENSpaceEntity.GetRecordById<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord>(id);
}


        public static EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord) RsseSpaceOutSystemsUI.ENSpaceEntity.GetRecordByKey<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord>(key);
}

    } // ENSpaceEntity;

}

