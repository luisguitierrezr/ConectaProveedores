using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationDateRangeRecord
public class JSONRC_221a79ae57c7b1d18e3f1435bcd9694b : AbstractRESTStructure<RC_221a79ae57c7b1d18e3f1435bcd9694b> {
[JsonProperty("DocumentExtrationDateRange")]
[JsonPropertyName("DocumentExtrationDateRange")]
public ssConectaProveedores.RestRecords.JSONST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure AttrDocumentExtrationDateRange;

public JSONRC_221a79ae57c7b1d18e3f1435bcd9694b() { }

public JSONRC_221a79ae57c7b1d18e3f1435bcd9694b (RC_221a79ae57c7b1d18e3f1435bcd9694b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationDateRange = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationDateRange, new ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure(), ssConectaProveedores.RestRecords.JSONST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure.FromStructure, config);
  } else {
AttrDocumentExtrationDateRange = ssConectaProveedores.RestRecords.JSONST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure.FromStructure(s.ssSTDocumentExtrationDateRange, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_221a79ae57c7b1d18e3f1435bcd9694b, RC_221a79ae57c7b1d18e3f1435bcd9694b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_221a79ae57c7b1d18e3f1435bcd9694b s) => ToStructure(s, config);
}
public static RC_221a79ae57c7b1d18e3f1435bcd9694b ToStructure(ssConectaProveedores.RestRecords.JSONRC_221a79ae57c7b1d18e3f1435bcd9694b obj, IBehaviorsConfiguration config) { 
  RC_221a79ae57c7b1d18e3f1435bcd9694b s = new RC_221a79ae57c7b1d18e3f1435bcd9694b();
  if(obj != null) {
  s.ssSTDocumentExtrationDateRange = ssConectaProveedores.RestRecords.JSONST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure.ToStructure(obj.AttrDocumentExtrationDateRange, config);
  }
  return s;
}

public static Func<RC_221a79ae57c7b1d18e3f1435bcd9694b, ssConectaProveedores.RestRecords.JSONRC_221a79ae57c7b1d18e3f1435bcd9694b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_221a79ae57c7b1d18e3f1435bcd9694b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_221a79ae57c7b1d18e3f1435bcd9694b FromStructure(RC_221a79ae57c7b1d18e3f1435bcd9694b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_221a79ae57c7b1d18e3f1435bcd9694b(s, config);
}

}


