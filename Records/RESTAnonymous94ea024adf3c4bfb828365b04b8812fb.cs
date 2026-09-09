using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PasswordComplexityPolicyRecord
public class RESTRC_4d77cfdd567b208680377834fc8205a2 : AbstractRESTStructure<RC_4d77cfdd567b208680377834fc8205a2> {
[JsonProperty("PasswordComplexityPolicy")]
public ssConectaProveedores.RestRecords.RESTST_0774152396050b877fe73fc0db09d4f4Structure AttrPasswordComplexityPolicy;

public RESTRC_4d77cfdd567b208680377834fc8205a2() { }

public RESTRC_4d77cfdd567b208680377834fc8205a2 (RC_4d77cfdd567b208680377834fc8205a2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPasswordComplexityPolicy = ConvertToRestWithoutDefaults(s.ssSTPasswordComplexityPolicy, new ST_0774152396050b877fe73fc0db09d4f4Structure(), ssConectaProveedores.RestRecords.RESTST_0774152396050b877fe73fc0db09d4f4Structure.FromStructure, config);
  } else {
AttrPasswordComplexityPolicy = ssConectaProveedores.RestRecords.RESTST_0774152396050b877fe73fc0db09d4f4Structure.FromStructure(s.ssSTPasswordComplexityPolicy, config);
  }
}

public static RC_4d77cfdd567b208680377834fc8205a2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4d77cfdd567b208680377834fc8205a2 obj) { 
  RC_4d77cfdd567b208680377834fc8205a2 s = new RC_4d77cfdd567b208680377834fc8205a2();
  if(obj != null) {
  s.ssSTPasswordComplexityPolicy = ssConectaProveedores.RestRecords.RESTST_0774152396050b877fe73fc0db09d4f4Structure.ToStructure(obj.AttrPasswordComplexityPolicy);
  }
  return s;
}

public static Func<RC_4d77cfdd567b208680377834fc8205a2, ssConectaProveedores.RestRecords.RESTRC_4d77cfdd567b208680377834fc8205a2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d77cfdd567b208680377834fc8205a2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4d77cfdd567b208680377834fc8205a2 FromStructure(RC_4d77cfdd567b208680377834fc8205a2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4d77cfdd567b208680377834fc8205a2(s, config);
}

}


