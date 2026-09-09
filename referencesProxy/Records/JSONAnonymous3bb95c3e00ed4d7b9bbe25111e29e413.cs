using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SizeRecord
public class JSONRC_ca426fec0751e5b6dcf015e9fdc2120e : AbstractRESTStructure<RC_ca426fec0751e5b6dcf015e9fdc2120e> {
[JsonProperty("Size")]
[JsonPropertyName("Size")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord AttrSize;

public JSONRC_ca426fec0751e5b6dcf015e9fdc2120e() { }

public JSONRC_ca426fec0751e5b6dcf015e9fdc2120e (RC_ca426fec0751e5b6dcf015e9fdc2120e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSize = ConvertToRestWithoutDefaults(s.ssENSize, new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.FromStructure, config);
  } else {
AttrSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.FromStructure(s.ssENSize, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ca426fec0751e5b6dcf015e9fdc2120e, RC_ca426fec0751e5b6dcf015e9fdc2120e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ca426fec0751e5b6dcf015e9fdc2120e s) => ToStructure(s, config);
}
public static RC_ca426fec0751e5b6dcf015e9fdc2120e ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ca426fec0751e5b6dcf015e9fdc2120e obj, IBehaviorsConfiguration config) { 
  RC_ca426fec0751e5b6dcf015e9fdc2120e s = new RC_ca426fec0751e5b6dcf015e9fdc2120e();
  if(obj != null) {
  s.ssENSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.ToStructure(obj.AttrSize, config);
  }
  return s;
}

public static Func<RC_ca426fec0751e5b6dcf015e9fdc2120e, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ca426fec0751e5b6dcf015e9fdc2120e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ca426fec0751e5b6dcf015e9fdc2120e s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ca426fec0751e5b6dcf015e9fdc2120e FromStructure(RC_ca426fec0751e5b6dcf015e9fdc2120e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ca426fec0751e5b6dcf015e9fdc2120e(s, config);
}

}


