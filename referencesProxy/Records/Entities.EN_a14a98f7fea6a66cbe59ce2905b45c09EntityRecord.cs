using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSizeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"size", "size"}
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
} // ENSizeEntity
/// <summary>
/// Static Entity <code>ENSizeEntity</code> gets the values for this static entity records in runtime
///  <code>Size</code>
/// </summary>
    partial class ENSizeEntity {
        

        public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetRecordById(string id) {
return (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord) RsseSpaceOutSystemsUI.ENSizeEntity.GetRecordById<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord>(id);
}


        public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord) RsseSpaceOutSystemsUI.ENSizeEntity.GetRecordByKey<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord>(key);
}

    } // ENSizeEntity;

}

