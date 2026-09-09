using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENVideoStateEntity {
private static readonly ActivitySource activitySource = new(typeof(ENVideoStateEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"state", "state"}
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
} // ENVideoStateEntity
/// <summary>
/// Static Entity <code>ENVideoStateEntity</code> gets the values for this static entity records in
///  runtime <code>VideoState</code>
/// </summary>
    partial class ENVideoStateEntity {
        

        public static EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord GetRecordById(string id) {
return (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord) RsseSpaceOutSystemsUI.ENVideoStateEntity.GetRecordById<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord>(id);
}


        public static EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord) RsseSpaceOutSystemsUI.ENVideoStateEntity.GetRecordByKey<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord>(key);
}

    } // ENVideoStateEntity;

}

