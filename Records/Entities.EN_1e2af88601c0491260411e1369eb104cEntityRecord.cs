using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENBooleanTypesEntity {
private static readonly ActivitySource activitySource = new(typeof(ENBooleanTypesEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"label", "label"},
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
} // ENBooleanTypesEntity
/// <summary>
/// Static Entity <code>ENBooleanTypesEntity</code> gets the values for this static entity records in
///  runtime <code>BooleanTypes</code>
/// </summary>
    partial class ENBooleanTypesEntity {
        

        public static EN_1e2af88601c0491260411e1369eb104cEntityRecord GetRecordById(string id) {
return (EN_1e2af88601c0491260411e1369eb104cEntityRecord) RsseSpaceOutSystemsUI.ENBooleanTypesEntity.GetRecordById<EN_1e2af88601c0491260411e1369eb104cEntityRecord>(id);
}


        public static EN_1e2af88601c0491260411e1369eb104cEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_1e2af88601c0491260411e1369eb104cEntityRecord) RsseSpaceOutSystemsUI.ENBooleanTypesEntity.GetRecordByKey<EN_1e2af88601c0491260411e1369eb104cEntityRecord>(key);
}

    } // ENBooleanTypesEntity;

}

