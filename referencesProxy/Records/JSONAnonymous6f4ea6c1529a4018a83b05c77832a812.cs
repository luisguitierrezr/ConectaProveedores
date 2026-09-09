using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_HEADER5Record
public class JSONRC_28bce23859a55ab059649bad680a14c2 : AbstractRESTStructure<RC_28bce23859a55ab059649bad680a14c2> {
[JsonProperty("PI_HEADER5")]
[JsonPropertyName("PI_HEADER5")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure AttrPI_HEADER5;

public JSONRC_28bce23859a55ab059649bad680a14c2() { }

public JSONRC_28bce23859a55ab059649bad680a14c2 (RC_28bce23859a55ab059649bad680a14c2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER5 = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER5, new ST_976925bffb49d1800d61d6274bd325dfStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure.FromStructure, config);
  } else {
AttrPI_HEADER5 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure.FromStructure(s.ssSTPI_HEADER5, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_28bce23859a55ab059649bad680a14c2, RC_28bce23859a55ab059649bad680a14c2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_28bce23859a55ab059649bad680a14c2 s) => ToStructure(s, config);
}
public static RC_28bce23859a55ab059649bad680a14c2 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_28bce23859a55ab059649bad680a14c2 obj, IBehaviorsConfiguration config) { 
  RC_28bce23859a55ab059649bad680a14c2 s = new RC_28bce23859a55ab059649bad680a14c2();
  if(obj != null) {
  s.ssSTPI_HEADER5 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure.ToStructure(obj.AttrPI_HEADER5, config);
  }
  return s;
}

public static Func<RC_28bce23859a55ab059649bad680a14c2, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_28bce23859a55ab059649bad680a14c2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_28bce23859a55ab059649bad680a14c2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_28bce23859a55ab059649bad680a14c2 FromStructure(RC_28bce23859a55ab059649bad680a14c2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_28bce23859a55ab059649bad680a14c2(s, config);
}

}


