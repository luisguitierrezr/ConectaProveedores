// Proxy for reference eSpace with name OutSystemsCharts and key GsJsM7MptEaLxNSsOskZsQ
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceOutSystemsCharts
/// </summary>
public partial class RsseSpaceOutSystemsCharts {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceOutSystemsCharts");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("38b70e23-50fc-4710-80cf-3682a9dc998a");
       }
   }
public sealed partial class ENSeriesTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("38b70e23-50fc-4710-80cf-3682a9dc998a");
} // ENSeriesTypeEntity
    partial class ENSeriesTypeEntity {
        

        public static TRecord GetRecordById<TRecord>(string id) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssOutSystemsCharts.ENSeriesTypeEntity.GetRecordById(id));
return rec;
}


        public static TRecord GetRecordByKey<TRecord>(ObjectKey key) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssOutSystemsCharts.ENSeriesTypeEntity.GetRecordByKey(key));
return rec;
}

    } // ENSeriesTypeEntity;

public sealed partial class ENLegendPositionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("38b70e23-50fc-4710-80cf-3682a9dc998a");
} // ENLegendPositionEntity
    partial class ENLegendPositionEntity {
        

        public static TRecord GetRecordById<TRecord>(string id) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssOutSystemsCharts.ENLegendPositionEntity.GetRecordById(id));
return rec;
}


        public static TRecord GetRecordByKey<TRecord>(ObjectKey key) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssOutSystemsCharts.ENLegendPositionEntity.GetRecordByKey(key));
return rec;
}

    } // ENLegendPositionEntity;

public sealed partial class ENLegendLayoutEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("38b70e23-50fc-4710-80cf-3682a9dc998a");
} // ENLegendLayoutEntity
    partial class ENLegendLayoutEntity {
        

        public static TRecord GetRecordById<TRecord>(string id) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssOutSystemsCharts.ENLegendLayoutEntity.GetRecordById(id));
return rec;
}


        public static TRecord GetRecordByKey<TRecord>(ObjectKey key) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssOutSystemsCharts.ENLegendLayoutEntity.GetRecordByKey(key));
return rec;
}

    } // ENLegendLayoutEntity;


public class DefaultValues {
public static string ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_xAxisId {
get { return ssOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_xAxisId; }
}
public static string ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_yAxisId {
get { return ssOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_yAxisId; }
}
public static string ReferenceStructure_ChartLegendStyling_ReferenceStructureAttribute_BackgroundColor {
get { return ssOutSystemsCharts.DefaultValues.ReferenceStructure_ChartLegendStyling_ReferenceStructureAttribute_BackgroundColor; }
}
}
}
}
