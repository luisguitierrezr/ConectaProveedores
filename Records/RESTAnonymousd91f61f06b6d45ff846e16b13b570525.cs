using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FilenameBinaryRecord
public class RESTRC_9558728eac8dc806cf1b0c0e9a8e1262 : AbstractRESTStructure<RC_9558728eac8dc806cf1b0c0e9a8e1262> {
[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("Binary")]
public byte[] AttrBinary;

public RESTRC_9558728eac8dc806cf1b0c0e9a8e1262() { }

public RESTRC_9558728eac8dc806cf1b0c0e9a8e1262 (RC_9558728eac8dc806cf1b0c0e9a8e1262 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrBinary = ConvertToRestWithoutDefaults(s.ssBinary);
  } else {
AttrFilename = s.ssFilename;
AttrBinary = s.ssBinary;
  }
}

public static RC_9558728eac8dc806cf1b0c0e9a8e1262 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9558728eac8dc806cf1b0c0e9a8e1262 obj) { 
  RC_9558728eac8dc806cf1b0c0e9a8e1262 s = new RC_9558728eac8dc806cf1b0c0e9a8e1262();
  if(obj != null) {
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssBinary = obj.AttrBinary == null ? new byte[] {} : obj.AttrBinary;
  }
  return s;
}

public static Func<RC_9558728eac8dc806cf1b0c0e9a8e1262, ssConectaProveedores.RestRecords.RESTRC_9558728eac8dc806cf1b0c0e9a8e1262> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9558728eac8dc806cf1b0c0e9a8e1262 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9558728eac8dc806cf1b0c0e9a8e1262 FromStructure(RC_9558728eac8dc806cf1b0c0e9a8e1262 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9558728eac8dc806cf1b0c0e9a8e1262(s, config);
}

}


