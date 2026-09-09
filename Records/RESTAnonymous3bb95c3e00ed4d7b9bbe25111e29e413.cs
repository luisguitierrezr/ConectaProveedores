using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SizeRecord
public class RESTRC_ca426fec0751e5b6dcf015e9fdc2120e : AbstractRESTStructure<RC_ca426fec0751e5b6dcf015e9fdc2120e> {
[JsonProperty("Size")]
public ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord AttrSize;

public RESTRC_ca426fec0751e5b6dcf015e9fdc2120e() { }

public RESTRC_ca426fec0751e5b6dcf015e9fdc2120e (RC_ca426fec0751e5b6dcf015e9fdc2120e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSize = ConvertToRestWithoutDefaults(s.ssENSize, new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.FromStructure, config);
  } else {
AttrSize = ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.FromStructure(s.ssENSize, config);
  }
}

public static RC_ca426fec0751e5b6dcf015e9fdc2120e ToStructure(ssConectaProveedores.RestRecords.RESTRC_ca426fec0751e5b6dcf015e9fdc2120e obj) { 
  RC_ca426fec0751e5b6dcf015e9fdc2120e s = new RC_ca426fec0751e5b6dcf015e9fdc2120e();
  if(obj != null) {
  s.ssENSize = ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord.ToStructure(obj.AttrSize);
  }
  return s;
}

public static Func<RC_ca426fec0751e5b6dcf015e9fdc2120e, ssConectaProveedores.RestRecords.RESTRC_ca426fec0751e5b6dcf015e9fdc2120e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ca426fec0751e5b6dcf015e9fdc2120e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ca426fec0751e5b6dcf015e9fdc2120e FromStructure(RC_ca426fec0751e5b6dcf015e9fdc2120e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ca426fec0751e5b6dcf015e9fdc2120e(s, config);
}

}


