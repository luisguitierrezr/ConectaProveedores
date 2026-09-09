using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENSideMenuBehaviorEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSideMenuBehaviorEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"sidemenubehavior", "sidemenubehavior"}
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
} // ENSideMenuBehaviorEntity
/// <summary>
/// Static Entity <code>ENSideMenuBehaviorEntity</code> gets the values for this static entity records
///  in runtime <code>SideMenuBehavior</code>
/// </summary>
    partial class ENSideMenuBehaviorEntity {
        

        public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetRecordById(string id) {
return (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord) RsseSpaceOutSystemsUI.ENSideMenuBehaviorEntity.GetRecordById<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord>(id);
}


        public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord) RsseSpaceOutSystemsUI.ENSideMenuBehaviorEntity.GetRecordByKey<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord>(key);
}

    } // ENSideMenuBehaviorEntity;

}

