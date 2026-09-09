using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENAccordionIconTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccordionIconTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"id", "id"}
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
} // ENAccordionIconTypeEntity
/// <summary>
/// Static Entity <code>ENAccordionIconTypeEntity</code> gets the values for this static entity records
///  in runtime <code>AccordionIconType</code>
/// </summary>
    partial class ENAccordionIconTypeEntity {
        

        public static EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord GetRecordById(string id) {
return (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord) RsseSpaceOutSystemsUI.ENAccordionIconTypeEntity.GetRecordById<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord>(id);
}


        public static EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord) RsseSpaceOutSystemsUI.ENAccordionIconTypeEntity.GetRecordByKey<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord>(key);
}

    } // ENAccordionIconTypeEntity;

}

