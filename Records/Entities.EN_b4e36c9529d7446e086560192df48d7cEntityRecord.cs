using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENDatePickerTimeFormatEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerTimeFormatEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"timeformat", "timeformat"}
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
} // ENDatePickerTimeFormatEntity
/// <summary>
/// Static Entity <code>ENDatePickerTimeFormatEntity</code> gets the values for this static entity
///  records in runtime <code>DatePickerTimeFormat</code>
/// </summary>
    partial class ENDatePickerTimeFormatEntity {
        

        public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetRecordById(string id) {
return (EN_b4e36c9529d7446e086560192df48d7cEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerTimeFormatEntity.GetRecordById<EN_b4e36c9529d7446e086560192df48d7cEntityRecord>(id);
}


        public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_b4e36c9529d7446e086560192df48d7cEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerTimeFormatEntity.GetRecordByKey<EN_b4e36c9529d7446e086560192df48d7cEntityRecord>(key);
}

    } // ENDatePickerTimeFormatEntity;

}

