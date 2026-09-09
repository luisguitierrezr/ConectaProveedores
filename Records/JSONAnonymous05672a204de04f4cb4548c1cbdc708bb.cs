using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CounterRecord
public class JSONRC_6dc2ea62d515aadb2abe8127d022eca8 : AbstractRESTStructure<RC_6dc2ea62d515aadb2abe8127d022eca8> {
[JsonProperty("Counter")]
[JsonPropertyName("Counter")]
public ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure AttrCounter;

public JSONRC_6dc2ea62d515aadb2abe8127d022eca8() { }

public JSONRC_6dc2ea62d515aadb2abe8127d022eca8 (RC_6dc2ea62d515aadb2abe8127d022eca8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCounter = ConvertToRestWithoutDefaults(s.ssSTCounter, new ST_bfed96b4bd29e9b06f0b06e901b1508bStructure(), ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure.FromStructure, config);
  } else {
AttrCounter = ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure.FromStructure(s.ssSTCounter, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6dc2ea62d515aadb2abe8127d022eca8, RC_6dc2ea62d515aadb2abe8127d022eca8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6dc2ea62d515aadb2abe8127d022eca8 s) => ToStructure(s, config);
}
public static RC_6dc2ea62d515aadb2abe8127d022eca8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6dc2ea62d515aadb2abe8127d022eca8 obj, IBehaviorsConfiguration config) { 
  RC_6dc2ea62d515aadb2abe8127d022eca8 s = new RC_6dc2ea62d515aadb2abe8127d022eca8();
  if(obj != null) {
  s.ssSTCounter = ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure.ToStructure(obj.AttrCounter, config);
  }
  return s;
}

public static Func<RC_6dc2ea62d515aadb2abe8127d022eca8, ssConectaProveedores.RestRecords.JSONRC_6dc2ea62d515aadb2abe8127d022eca8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6dc2ea62d515aadb2abe8127d022eca8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6dc2ea62d515aadb2abe8127d022eca8 FromStructure(RC_6dc2ea62d515aadb2abe8127d022eca8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6dc2ea62d515aadb2abe8127d022eca8(s, config);
}

}


