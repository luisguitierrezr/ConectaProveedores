using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENShapeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENShapeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"shape", "shape"},
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
} // ENShapeEntity
/// <summary>
/// Static Entity <code>ENShapeEntity</code> gets the values for this static entity records in runtime
///  <code>Shape</code>
/// </summary>
    partial class ENShapeEntity {
        

        public static EN_d11562be18a7e40ca777aa336c946163EntityRecord GetRecordById(string id) {
return (EN_d11562be18a7e40ca777aa336c946163EntityRecord) RsseSpaceOutSystemsUI.ENShapeEntity.GetRecordById<EN_d11562be18a7e40ca777aa336c946163EntityRecord>(id);
}


        public static EN_d11562be18a7e40ca777aa336c946163EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_d11562be18a7e40ca777aa336c946163EntityRecord) RsseSpaceOutSystemsUI.ENShapeEntity.GetRecordByKey<EN_d11562be18a7e40ca777aa336c946163EntityRecord>(key);
}

    } // ENShapeEntity;

}

