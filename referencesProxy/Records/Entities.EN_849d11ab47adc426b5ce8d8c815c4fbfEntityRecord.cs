using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENColorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENColorEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"color", "color"},
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
} // ENColorEntity
/// <summary>
/// Static Entity <code>ENColorEntity</code> gets the values for this static entity records in runtime
///  <code>Color</code>
/// </summary>
    partial class ENColorEntity {
        

        public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetRecordById(string id) {
return (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord) RsseSpaceOutSystemsUI.ENColorEntity.GetRecordById<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord>(id);
}


        public static EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord) RsseSpaceOutSystemsUI.ENColorEntity.GetRecordByKey<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord>(key);
}

    } // ENColorEntity;

}

