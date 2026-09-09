using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

public sealed partial class ENSeriesTypeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENSeriesTypeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"type", "type"}
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
} // ENSeriesTypeEntity
/// <summary>
/// Static Entity <code>ENSeriesTypeEntity</code> gets the values for this static entity records in
///  runtime <code>SeriesType</code>
/// </summary>
    partial class ENSeriesTypeEntity {
        

        public static EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord GetRecordById(string id) {
return (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord) RsseSpaceOutSystemsCharts.ENSeriesTypeEntity.GetRecordById<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord>(id);
}


        public static EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord) RsseSpaceOutSystemsCharts.ENSeriesTypeEntity.GetRecordByKey<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord>(key);
}

    } // ENSeriesTypeEntity;

}

