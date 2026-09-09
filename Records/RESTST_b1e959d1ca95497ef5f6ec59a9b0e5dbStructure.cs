using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_POS_In
public class RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure : AbstractRESTStructure<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> {
[JsonProperty("PARAMETRO")]
public string AttrPARAMETRO;

public RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure() { }

public RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPARAMETRO = ConvertToRestWithoutDefaults(s.ssPARAMETRO, "");
  } else {
AttrPARAMETRO = s.ssPARAMETRO;
  }
}

public static ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure obj) { 
  ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s = new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure();
  if(obj != null) {
  s.ssPARAMETRO = obj.AttrPARAMETRO == null ? "" : obj.AttrPARAMETRO;
  }
  return s;
}

public static Func<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure, ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure FromStructure(ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(s, config);
}

}


