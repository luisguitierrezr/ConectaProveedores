using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReturnRecord
public class JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4 : AbstractRESTStructure<RC_a2486f07cac8ccfda7e3d2f4c629f5d4> {
[JsonProperty("Return")]
[JsonPropertyName("Return")]
public ssConectaProveedores.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure AttrReturn;

public JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4() { }

public JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4 (RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReturn = ConvertToRestWithoutDefaults(s.ssSTReturn, new ST_b1b6df219277397c7c2be747d587880aStructure(), ssConectaProveedores.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure.FromStructure, config);
  } else {
AttrReturn = ssConectaProveedores.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure.FromStructure(s.ssSTReturn, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4, RC_a2486f07cac8ccfda7e3d2f4c629f5d4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4 s) => ToStructure(s, config);
}
public static RC_a2486f07cac8ccfda7e3d2f4c629f5d4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4 obj, IBehaviorsConfiguration config) { 
  RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s = new RC_a2486f07cac8ccfda7e3d2f4c629f5d4();
  if(obj != null) {
  s.ssSTReturn = ssConectaProveedores.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure.ToStructure(obj.AttrReturn, config);
  }
  return s;
}

public static Func<RC_a2486f07cac8ccfda7e3d2f4c629f5d4, ssConectaProveedores.RestRecords.JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4 FromStructure(RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a2486f07cac8ccfda7e3d2f4c629f5d4(s, config);
}

}


