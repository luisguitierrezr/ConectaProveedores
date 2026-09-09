using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENPaperSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENPaperSizeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"size", "size"},
{"label", "label"},
{"order", "order"},
{"width", "width"},
{"height", "height"},
{"isinternational", "isinternational"},
{"islandscape", "islandscape"}
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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("5be86d03-32b8-4d45-b8c8-b87a417f1574");
} // ENPaperSizeEntity
/// <summary>
/// Static Entity <code>ENPaperSizeEntity</code> gets the values for this static entity records in
///  runtime <code>PaperSize</code>
/// </summary>
    partial class ENPaperSizeEntity {
        

        public static EN_7f47ecde673669f1866fae1765d30761EntityRecord GetRecordById(string id) {
return (EN_7f47ecde673669f1866fae1765d30761EntityRecord) RsseSpaceUltimatePDF.ENPaperSizeEntity.GetRecordById<EN_7f47ecde673669f1866fae1765d30761EntityRecord>(id);
}


        public static EN_7f47ecde673669f1866fae1765d30761EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_7f47ecde673669f1866fae1765d30761EntityRecord) RsseSpaceUltimatePDF.ENPaperSizeEntity.GetRecordByKey<EN_7f47ecde673669f1866fae1765d30761EntityRecord>(key);
}

    } // ENPaperSizeEntity;

}

