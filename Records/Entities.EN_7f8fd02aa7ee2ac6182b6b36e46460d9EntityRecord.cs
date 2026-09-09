using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENAccordionIconPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENAccordionIconPositionEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"label", "label"}
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
} // ENAccordionIconPositionEntity
/// <summary>
/// Static Entity <code>ENAccordionIconPositionEntity</code> gets the values for this static entity
///  records in runtime <code>AccordionIconPosition</code>
/// </summary>
    partial class ENAccordionIconPositionEntity {
        

        public static EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord GetRecordById(string id) {
return (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord) RsseSpaceOutSystemsUI.ENAccordionIconPositionEntity.GetRecordById<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord>(id);
}


        public static EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord) RsseSpaceOutSystemsUI.ENAccordionIconPositionEntity.GetRecordByKey<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord>(key);
}

    } // ENAccordionIconPositionEntity;

}

