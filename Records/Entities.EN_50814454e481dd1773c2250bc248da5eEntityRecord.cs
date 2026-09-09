using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENDirectionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENDirectionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"direction", "direction"},
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
} // ENDirectionEntity
/// <summary>
/// Static Entity <code>ENDirectionEntity</code> gets the values for this static entity records in
///  runtime <code>Direction</code>
/// </summary>
    partial class ENDirectionEntity {
        

        public static EN_50814454e481dd1773c2250bc248da5eEntityRecord GetRecordById(string id) {
return (EN_50814454e481dd1773c2250bc248da5eEntityRecord) RsseSpaceOutSystemsUI.ENDirectionEntity.GetRecordById<EN_50814454e481dd1773c2250bc248da5eEntityRecord>(id);
}


        public static EN_50814454e481dd1773c2250bc248da5eEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_50814454e481dd1773c2250bc248da5eEntityRecord) RsseSpaceOutSystemsUI.ENDirectionEntity.GetRecordByKey<EN_50814454e481dd1773c2250bc248da5eEntityRecord>(key);
}

    } // ENDirectionEntity;

}

