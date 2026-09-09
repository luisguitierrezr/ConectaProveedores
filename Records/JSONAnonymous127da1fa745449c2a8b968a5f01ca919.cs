using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationFilesRecord
public class JSONRC_dac4d0b34831478d401f08fdebfad1b4 : AbstractRESTStructure<RC_dac4d0b34831478d401f08fdebfad1b4> {
[JsonProperty("DocumentExtrationFiles")]
[JsonPropertyName("DocumentExtrationFiles")]
public ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure AttrDocumentExtrationFiles;

public JSONRC_dac4d0b34831478d401f08fdebfad1b4() { }

public JSONRC_dac4d0b34831478d401f08fdebfad1b4 (RC_dac4d0b34831478d401f08fdebfad1b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationFiles = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationFiles, new ST_27be19a2068bdbf4844f837df703a71bStructure(), ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure.FromStructure, config);
  } else {
AttrDocumentExtrationFiles = ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure.FromStructure(s.ssSTDocumentExtrationFiles, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_dac4d0b34831478d401f08fdebfad1b4, RC_dac4d0b34831478d401f08fdebfad1b4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_dac4d0b34831478d401f08fdebfad1b4 s) => ToStructure(s, config);
}
public static RC_dac4d0b34831478d401f08fdebfad1b4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_dac4d0b34831478d401f08fdebfad1b4 obj, IBehaviorsConfiguration config) { 
  RC_dac4d0b34831478d401f08fdebfad1b4 s = new RC_dac4d0b34831478d401f08fdebfad1b4();
  if(obj != null) {
  s.ssSTDocumentExtrationFiles = ssConectaProveedores.RestRecords.JSONST_27be19a2068bdbf4844f837df703a71bStructure.ToStructure(obj.AttrDocumentExtrationFiles, config);
  }
  return s;
}

public static Func<RC_dac4d0b34831478d401f08fdebfad1b4, ssConectaProveedores.RestRecords.JSONRC_dac4d0b34831478d401f08fdebfad1b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dac4d0b34831478d401f08fdebfad1b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_dac4d0b34831478d401f08fdebfad1b4 FromStructure(RC_dac4d0b34831478d401f08fdebfad1b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_dac4d0b34831478d401f08fdebfad1b4(s, config);
}

}


