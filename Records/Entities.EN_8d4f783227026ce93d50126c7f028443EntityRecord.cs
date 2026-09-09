using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENOrientationEntity {
private static readonly ActivitySource activitySource = new(typeof(ENOrientationEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"orientation", "orientation"}
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
} // ENOrientationEntity
/// <summary>
/// Static Entity <code>ENOrientationEntity</code> gets the values for this static entity records in
///  runtime <code>Orientation</code>
/// </summary>
    partial class ENOrientationEntity {
        

        public static EN_8d4f783227026ce93d50126c7f028443EntityRecord GetRecordById(string id) {
return (EN_8d4f783227026ce93d50126c7f028443EntityRecord) RsseSpaceOutSystemsUI.ENOrientationEntity.GetRecordById<EN_8d4f783227026ce93d50126c7f028443EntityRecord>(id);
}


        public static EN_8d4f783227026ce93d50126c7f028443EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_8d4f783227026ce93d50126c7f028443EntityRecord) RsseSpaceOutSystemsUI.ENOrientationEntity.GetRecordByKey<EN_8d4f783227026ce93d50126c7f028443EntityRecord>(key);
}

    } // ENOrientationEntity;

}

