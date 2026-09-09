using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENLegendLayoutEntity {
private static readonly ActivitySource activitySource = new(typeof(ENLegendLayoutEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"layout", "layout"}
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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("38b70e23-50fc-4710-80cf-3682a9dc998a");
} // ENLegendLayoutEntity
/// <summary>
/// Static Entity <code>ENLegendLayoutEntity</code> gets the values for this static entity records in
///  runtime <code>LegendLayout</code>
/// </summary>
    partial class ENLegendLayoutEntity {
        

        public static EN_f2ce8f552d142202c9a955104f8986e7EntityRecord GetRecordById(string id) {
return (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord) RsseSpaceOutSystemsCharts.ENLegendLayoutEntity.GetRecordById<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord>(id);
}


        public static EN_f2ce8f552d142202c9a955104f8986e7EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord) RsseSpaceOutSystemsCharts.ENLegendLayoutEntity.GetRecordByKey<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord>(key);
}

    } // ENLegendLayoutEntity;

}

