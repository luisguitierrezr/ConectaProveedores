using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationDateRange
public class RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure : AbstractRESTStructure<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure> {
[JsonProperty("Desde")]
public string AttrDesde;

[JsonProperty("Hasta")]
public string AttrHasta;

[JsonProperty("Space")]
public string AttrSpace;

[JsonProperty("Desde2")]
public string AttrDesde2;

[JsonProperty("Hasta2")]
public string AttrHasta2;

public RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure() { }

public RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDesde = ConvertToRestWithoutDefaults(s.ssDesde, "");
AttrHasta = ConvertToRestWithoutDefaults(s.ssHasta, "");
AttrSpace = ConvertToRestWithoutDefaults(s.ssSpace, "");
AttrDesde2 = ConvertToRestWithoutDefaults(s.ssDesde2, "");
AttrHasta2 = ConvertToRestWithoutDefaults(s.ssHasta2, "");
  } else {
AttrDesde = s.ssDesde;
AttrHasta = s.ssHasta;
AttrSpace = s.ssSpace;
AttrDesde2 = s.ssDesde2;
AttrHasta2 = s.ssHasta2;
  }
}

public static ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure obj) { 
  ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure s = new ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure();
  if(obj != null) {
  s.ssDesde = obj.AttrDesde == null ? "" : obj.AttrDesde;
  s.ssHasta = obj.AttrHasta == null ? "" : obj.AttrHasta;
  s.ssSpace = obj.AttrSpace == null ? "" : obj.AttrSpace;
  s.ssDesde2 = obj.AttrDesde2 == null ? "" : obj.AttrDesde2;
  s.ssHasta2 = obj.AttrHasta2 == null ? "" : obj.AttrHasta2;
  }
  return s;
}

public static Func<ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure, ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure FromStructure(ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure(s, config);
}

}


