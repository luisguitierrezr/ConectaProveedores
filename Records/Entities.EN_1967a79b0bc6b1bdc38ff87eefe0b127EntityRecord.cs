using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENScrollbarStyleEntity {
private static readonly ActivitySource activitySource = new(typeof(ENScrollbarStyleEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"style", "style"}
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
} // ENScrollbarStyleEntity
/// <summary>
/// Static Entity <code>ENScrollbarStyleEntity</code> gets the values for this static entity records in
///  runtime <code>ScrollbarStyle</code>
/// </summary>
    partial class ENScrollbarStyleEntity {
        

        public static EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord GetRecordById(string id) {
return (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord) RsseSpaceOutSystemsUI.ENScrollbarStyleEntity.GetRecordById<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord>(id);
}


        public static EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord) RsseSpaceOutSystemsUI.ENScrollbarStyleEntity.GetRecordByKey<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord>(key);
}

    } // ENScrollbarStyleEntity;

}

