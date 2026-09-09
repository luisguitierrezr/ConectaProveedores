using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENBreakColumnsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENBreakColumnsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"breakcolumns", "breakcolumns"}
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
} // ENBreakColumnsEntity
/// <summary>
/// Static Entity <code>ENBreakColumnsEntity</code> gets the values for this static entity records in
///  runtime <code>BreakColumns</code>
/// </summary>
    partial class ENBreakColumnsEntity {
        

        public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetRecordById(string id) {
return (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord) RsseSpaceOutSystemsUI.ENBreakColumnsEntity.GetRecordById<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord>(id);
}


        public static EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord) RsseSpaceOutSystemsUI.ENBreakColumnsEntity.GetRecordByKey<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord>(key);
}

    } // ENBreakColumnsEntity;

}

