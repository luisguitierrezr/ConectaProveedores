using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENDatePickerWeekDayEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDatePickerWeekDayEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"weekday", "weekday"}
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
} // ENDatePickerWeekDayEntity
/// <summary>
/// Static Entity <code>ENDatePickerWeekDayEntity</code> gets the values for this static entity records
///  in runtime <code>DatePickerWeekDay</code>
/// </summary>
    partial class ENDatePickerWeekDayEntity {
        

        public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetRecordById(int id) {
return (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerWeekDayEntity.GetRecordById<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord>(id);
}


        public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord) RsseSpaceOutSystemsUI.ENDatePickerWeekDayEntity.GetRecordByKey<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord>(key);
}

    } // ENDatePickerWeekDayEntity;

}

