using System.Diagnostics;
namespace ssConectaProveedores {

public sealed partial class ENMarginSizeEntity {
private static readonly ActivitySource activitySource = new(typeof(ENMarginSizeEntity).Namespace);
private static System.Collections.Generic.Dictionary<string,string> _entityAttributes;
private static System.Collections.Generic.Dictionary<string,string> EntityAttributes => _entityAttributes ??= InitializeEntityAttributes();

private static System.Collections.Generic.Dictionary<string,string> InitializeEntityAttributes() {
return new System.Collections.Generic.Dictionary<string,string> {
{"size", "size"},
{"label", "label"},
{"order", "order"},
{"margintop", "margintop"},
{"marginright", "marginright"},
{"marginbottom", "marginbottom"},
{"marginleft", "marginleft"},
{"isinternational", "isinternational"}
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
} // ENMarginSizeEntity
/// <summary>
/// Static Entity <code>ENMarginSizeEntity</code> gets the values for this static entity records in
///  runtime <code>MarginSize</code>
/// </summary>
    partial class ENMarginSizeEntity {
        

        public static EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord GetRecordById(string id) {
return (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord) RsseSpaceUltimatePDF.ENMarginSizeEntity.GetRecordById<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord>(id);
}


        public static EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord GetRecordByKey(ObjectKey key) {
return (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord) RsseSpaceUltimatePDF.ENMarginSizeEntity.GetRecordByKey<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord>(key);
}

    } // ENMarginSizeEntity;

}

