using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENLegendPositionEntity {
private static readonly ActivitySource activitySource = new(typeof(ENLegendPositionEntity).Namespace);
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
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("38b70e23-50fc-4710-80cf-3682a9dc998a");
} // ENLegendPositionEntity
/// <summary>
/// Static Entity <code>ENLegendPositionEntity</code> gets the values for this static entity records in
///  runtime <code>LegendPosition</code>
/// </summary>
    partial class ENLegendPositionEntity {
        

        public static EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord GetRecordById(string id) {
return (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord) RsseSpaceOutSystemsCharts.ENLegendPositionEntity.GetRecordById<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord>(id);
}


        public static EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord GetRecordByKey(ObjectKey key) {
return (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord) RsseSpaceOutSystemsCharts.ENLegendPositionEntity.GetRecordByKey<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord>(key);
}

    } // ENLegendPositionEntity;

}

