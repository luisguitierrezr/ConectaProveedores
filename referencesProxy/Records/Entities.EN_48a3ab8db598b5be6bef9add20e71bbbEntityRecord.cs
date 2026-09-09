using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENGutterSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENGutterSizeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"guttersize", "guttersize"},
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
} // ENGutterSizeEntity
/// <summary>
/// Static Entity <code>ENGutterSizeEntity</code> gets the values for this static entity records in
///  runtime <code>GutterSize</code>
/// </summary>
    partial class ENGutterSizeEntity {
        

        public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetRecordById(string id) {
return (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord) RsseSpaceOutSystemsUI.ENGutterSizeEntity.GetRecordById<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord>(id);
}


        public static EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord) RsseSpaceOutSystemsUI.ENGutterSizeEntity.GetRecordByKey<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord>(key);
}

    } // ENGutterSizeEntity;

}

