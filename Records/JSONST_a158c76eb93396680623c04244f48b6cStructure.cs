using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileStruct
public class JSONST_a158c76eb93396680623c04244f48b6cStructure : AbstractRESTStructure<ST_a158c76eb93396680623c04244f48b6cStructure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("BinaryData")]
[JsonPropertyName("BinaryData")]
public byte[] AttrBinaryData;

public JSONST_a158c76eb93396680623c04244f48b6cStructure() { }

public JSONST_a158c76eb93396680623c04244f48b6cStructure (ST_a158c76eb93396680623c04244f48b6cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = s.ssName;
AttrBinaryData = s.ssBinaryData;
  } else {
AttrName = s.ssName;
AttrBinaryData = s.ssBinaryData;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_a158c76eb93396680623c04244f48b6cStructure, ST_a158c76eb93396680623c04244f48b6cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_a158c76eb93396680623c04244f48b6cStructure s) => ToStructure(s, config);
}
public static ST_a158c76eb93396680623c04244f48b6cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_a158c76eb93396680623c04244f48b6cStructure obj, IBehaviorsConfiguration config) { 
  ST_a158c76eb93396680623c04244f48b6cStructure s = new ST_a158c76eb93396680623c04244f48b6cStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssBinaryData = obj.AttrBinaryData == null ? new byte[] {} : obj.AttrBinaryData;
  }
  return s;
}

public static Func<ST_a158c76eb93396680623c04244f48b6cStructure, ssConectaProveedores.RestRecords.JSONST_a158c76eb93396680623c04244f48b6cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a158c76eb93396680623c04244f48b6cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_a158c76eb93396680623c04244f48b6cStructure FromStructure(ST_a158c76eb93396680623c04244f48b6cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_a158c76eb93396680623c04244f48b6cStructure(s, config);
}

}


