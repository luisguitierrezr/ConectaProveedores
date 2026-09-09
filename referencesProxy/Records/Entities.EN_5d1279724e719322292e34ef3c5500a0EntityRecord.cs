using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPositionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"position", "position"}
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
} // ENPositionEntity
/// <summary>
/// Static Entity <code>ENPositionEntity</code> gets the values for this static entity records in
///  runtime <code>Position</code>
/// </summary>
    partial class ENPositionEntity {
        

        public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetRecordById(string id) {
return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord) RsseSpaceOutSystemsUI.ENPositionEntity.GetRecordById<EN_5d1279724e719322292e34ef3c5500a0EntityRecord>(id);
}


        public static EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_5d1279724e719322292e34ef3c5500a0EntityRecord) RsseSpaceOutSystemsUI.ENPositionEntity.GetRecordByKey<EN_5d1279724e719322292e34ef3c5500a0EntityRecord>(key);
}

    } // ENPositionEntity;

}

