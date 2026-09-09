using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// APIOutput2Record
public class RESTRC_e4b3818aab18afe673c72bba366c601e : AbstractRESTStructure<RC_e4b3818aab18afe673c72bba366c601e> {
[JsonProperty("APIOutput2")]
public ssConectaProveedores.RestRecords.RESTST_8509a484f6b6eac99c83feddd35d5004Structure AttrAPIOutput2;

public RESTRC_e4b3818aab18afe673c72bba366c601e() { }

public RESTRC_e4b3818aab18afe673c72bba366c601e (RC_e4b3818aab18afe673c72bba366c601e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAPIOutput2 = ConvertToRestWithoutDefaults(s.ssSTAPIOutput2, new ST_8509a484f6b6eac99c83feddd35d5004Structure(), ssConectaProveedores.RestRecords.RESTST_8509a484f6b6eac99c83feddd35d5004Structure.FromStructure, config);
  } else {
AttrAPIOutput2 = ssConectaProveedores.RestRecords.RESTST_8509a484f6b6eac99c83feddd35d5004Structure.FromStructure(s.ssSTAPIOutput2, config);
  }
}

public static RC_e4b3818aab18afe673c72bba366c601e ToStructure(ssConectaProveedores.RestRecords.RESTRC_e4b3818aab18afe673c72bba366c601e obj) { 
  RC_e4b3818aab18afe673c72bba366c601e s = new RC_e4b3818aab18afe673c72bba366c601e();
  if(obj != null) {
  s.ssSTAPIOutput2 = ssConectaProveedores.RestRecords.RESTST_8509a484f6b6eac99c83feddd35d5004Structure.ToStructure(obj.AttrAPIOutput2);
  }
  return s;
}

public static Func<RC_e4b3818aab18afe673c72bba366c601e, ssConectaProveedores.RestRecords.RESTRC_e4b3818aab18afe673c72bba366c601e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e4b3818aab18afe673c72bba366c601e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e4b3818aab18afe673c72bba366c601e FromStructure(RC_e4b3818aab18afe673c72bba366c601e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e4b3818aab18afe673c72bba366c601e(s, config);
}

}


