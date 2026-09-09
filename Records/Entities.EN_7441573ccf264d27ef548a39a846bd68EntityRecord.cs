using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENStepsEntity {
private static readonly ActivitySource activitySource = new(typeof(ENStepsEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"steps", "steps"}
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
} // ENStepsEntity
/// <summary>
/// Static Entity <code>ENStepsEntity</code> gets the values for this static entity records in runtime
///  <code>Steps</code>
/// </summary>
    partial class ENStepsEntity {
        

        public static EN_7441573ccf264d27ef548a39a846bd68EntityRecord GetRecordById(string id) {
return (EN_7441573ccf264d27ef548a39a846bd68EntityRecord) RsseSpaceOutSystemsUI.ENStepsEntity.GetRecordById<EN_7441573ccf264d27ef548a39a846bd68EntityRecord>(id);
}


        public static EN_7441573ccf264d27ef548a39a846bd68EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_7441573ccf264d27ef548a39a846bd68EntityRecord) RsseSpaceOutSystemsUI.ENStepsEntity.GetRecordByKey<EN_7441573ccf264d27ef548a39a846bd68EntityRecord>(key);
}

    } // ENStepsEntity;

}

