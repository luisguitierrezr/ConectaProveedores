using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENTriggerEntity {
private static readonly ActivitySource activitySource = new(typeof(ENTriggerEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"trigger", "trigger"}
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
} // ENTriggerEntity
/// <summary>
/// Static Entity <code>ENTriggerEntity</code> gets the values for this static entity records in
///  runtime <code>Trigger</code>
/// </summary>
    partial class ENTriggerEntity {
        

        public static EN_52e55d60c515b6016f81404afb220594EntityRecord GetRecordById(string id) {
return (EN_52e55d60c515b6016f81404afb220594EntityRecord) RsseSpaceOutSystemsUI.ENTriggerEntity.GetRecordById<EN_52e55d60c515b6016f81404afb220594EntityRecord>(id);
}


        public static EN_52e55d60c515b6016f81404afb220594EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_52e55d60c515b6016f81404afb220594EntityRecord) RsseSpaceOutSystemsUI.ENTriggerEntity.GetRecordByKey<EN_52e55d60c515b6016f81404afb220594EntityRecord>(key);
}

    } // ENTriggerEntity;

}

