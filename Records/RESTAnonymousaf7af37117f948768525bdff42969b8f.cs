using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationDateRangeRecord
public class RESTRC_221a79ae57c7b1d18e3f1435bcd9694b : AbstractRESTStructure<RC_221a79ae57c7b1d18e3f1435bcd9694b> {
[JsonProperty("DocumentExtrationDateRange")]
public ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure AttrDocumentExtrationDateRange;

public RESTRC_221a79ae57c7b1d18e3f1435bcd9694b() { }

public RESTRC_221a79ae57c7b1d18e3f1435bcd9694b (RC_221a79ae57c7b1d18e3f1435bcd9694b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationDateRange = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationDateRange, new ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure(), ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure.FromStructure, config);
  } else {
AttrDocumentExtrationDateRange = ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure.FromStructure(s.ssSTDocumentExtrationDateRange, config);
  }
}

public static RC_221a79ae57c7b1d18e3f1435bcd9694b ToStructure(ssConectaProveedores.RestRecords.RESTRC_221a79ae57c7b1d18e3f1435bcd9694b obj) { 
  RC_221a79ae57c7b1d18e3f1435bcd9694b s = new RC_221a79ae57c7b1d18e3f1435bcd9694b();
  if(obj != null) {
  s.ssSTDocumentExtrationDateRange = ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure.ToStructure(obj.AttrDocumentExtrationDateRange);
  }
  return s;
}

public static Func<RC_221a79ae57c7b1d18e3f1435bcd9694b, ssConectaProveedores.RestRecords.RESTRC_221a79ae57c7b1d18e3f1435bcd9694b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_221a79ae57c7b1d18e3f1435bcd9694b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_221a79ae57c7b1d18e3f1435bcd9694b FromStructure(RC_221a79ae57c7b1d18e3f1435bcd9694b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_221a79ae57c7b1d18e3f1435bcd9694b(s, config);
}

}


