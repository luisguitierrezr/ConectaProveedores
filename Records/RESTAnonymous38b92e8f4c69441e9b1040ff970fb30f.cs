using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReturnRecord
public class RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4 : AbstractRESTStructure<RC_a2486f07cac8ccfda7e3d2f4c629f5d4> {
[JsonProperty("Return")]
public ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure AttrReturn;

public RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4() { }

public RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4 (RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReturn = ConvertToRestWithoutDefaults(s.ssSTReturn, new ST_b1b6df219277397c7c2be747d587880aStructure(), ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure.FromStructure, config);
  } else {
AttrReturn = ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure.FromStructure(s.ssSTReturn, config);
  }
}

public static RC_a2486f07cac8ccfda7e3d2f4c629f5d4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4 obj) { 
  RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s = new RC_a2486f07cac8ccfda7e3d2f4c629f5d4();
  if(obj != null) {
  s.ssSTReturn = ssConectaProveedores.RestRecords.RESTST_b1b6df219277397c7c2be747d587880aStructure.ToStructure(obj.AttrReturn);
  }
  return s;
}

public static Func<RC_a2486f07cac8ccfda7e3d2f4c629f5d4, ssConectaProveedores.RestRecords.RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4 FromStructure(RC_a2486f07cac8ccfda7e3d2f4c629f5d4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a2486f07cac8ccfda7e3d2f4c629f5d4(s, config);
}

}


