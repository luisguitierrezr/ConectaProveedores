using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImporteSumRecord
public class JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1 : AbstractRESTStructure<RC_f4d76e3d3fccb22411e2fbf1d069c4d1> {
[JsonProperty("ImporteSum")]
[JsonPropertyName("ImporteSum")]
public decimal? AttrImporteSum;

public JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1() { }

public JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1 (RC_f4d76e3d3fccb22411e2fbf1d069c4d1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrImporteSum = ConvertToRestWithoutDefaults(s.ssImporteSum, 0.0M);
  } else {
AttrImporteSum = (decimal?) s.ssImporteSum;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1, RC_f4d76e3d3fccb22411e2fbf1d069c4d1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1 s) => ToStructure(s, config);
}
public static RC_f4d76e3d3fccb22411e2fbf1d069c4d1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1 obj, IBehaviorsConfiguration config) { 
  RC_f4d76e3d3fccb22411e2fbf1d069c4d1 s = new RC_f4d76e3d3fccb22411e2fbf1d069c4d1();
  if(obj != null) {
  s.ssImporteSum = obj.AttrImporteSum == null ? 0.0M : obj.AttrImporteSum.Value;
  }
  return s;
}

public static Func<RC_f4d76e3d3fccb22411e2fbf1d069c4d1, ssConectaProveedores.RestRecords.JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f4d76e3d3fccb22411e2fbf1d069c4d1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1 FromStructure(RC_f4d76e3d3fccb22411e2fbf1d069c4d1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f4d76e3d3fccb22411e2fbf1d069c4d1(s, config);
}

}


